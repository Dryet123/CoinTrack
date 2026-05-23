using MoneyAgregator.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using MoneyAgregator.Core.Entity;

namespace MoneyAgregator.Aplication.Services;

public class CurrencySyncService 
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly INbuApiClient _nbuApiClient;
    private readonly ILogger<CurrencySyncService> _logger;
    public CurrencySyncService(INbuApiClient nbuApiClient, ICurrencyRepository currencyRepository, ILogger<CurrencySyncService> logger)
    {
        this._nbuApiClient = nbuApiClient;
        this._currencyRepository = currencyRepository;
        this._logger = logger;
    }

    public async Task SyncService()
    {
        var today  = DateTime.UtcNow;
        var updatedDate = await this._currencyRepository.TimeUpdatedAsync(); 
        if (today.Date == updatedDate.Date)
        {
            _logger.LogInformation("rates currently updated, SyncService skipped");
            return;
        }

        try
        {
            var data = await _nbuApiClient.GetCurrencyAsync();

            var entities = data
                .Select(d => new Currency
                    {
                        Code = d.Code,
                        CurrencyCode =  d.CurrencyCode,
                        Rate =  d.Rate,
                        RateUpdateDate =  d.RateUpdateDate,
                        
                    }
                );
            await _currencyRepository.UpsertCurrenciesAsync(entities);



        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "SyncService failed");
            
        }
        
    }
    
    
     
    
    
    
}