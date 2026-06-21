using MoneyAgregator.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using MoneyAgregator.Aplication.Interfaces;
using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Aplication.Services;

public class CurrencySyncService 
{
    private readonly ICurrencyRepository currencyRepository;
    private readonly INbuApiClient nbuApiClient;
    private readonly ILogger<CurrencySyncService> logger;
    public CurrencySyncService(INbuApiClient nbuApiClient, ICurrencyRepository currencyRepository, ILogger<CurrencySyncService> logger)
    {
        this.nbuApiClient = nbuApiClient;
        this.currencyRepository = currencyRepository;
        this.logger = logger;
    }

    public async Task SyncService()
    {
        var today  = DateTime.UtcNow;
        var updatedDate = await this.currencyRepository.TimeUpdatedAsync(); 
        if (today.Date == updatedDate.Date)
        {
            logger.LogInformation("rates currently updated, SyncService skipped");
            return;
        }

        try
        {
            var data = await nbuApiClient.GetCurrencyAsync();

            var entities = data
                .Select(d => new Currency
                    {
                        Code = d.Code,
                        CurrencyCode =  d.CurrencyCode,
                        Rate =  d.Rate,
                        RateUpdateDate =  d.RateUpdateDate,
                        
                    }
                );
            await currencyRepository.UpsertCurrenciesAsync(entities);



        }
        catch (Exception ex)
        {
            logger.LogError(ex, "SyncService failed");
            
        }
        
    }
    
    
     
    
    
    
}