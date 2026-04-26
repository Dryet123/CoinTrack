using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyAgregator.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MoneyAgregator.Core.Entity;
public class CurencyConfiguration : IEntityTypeConfiguration<CurrencyEntity>
{
    public void Configure(EntityTypeBuilder<CurrencyEntity> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(k => k.Id)
            .IsRequired();
        
    }
}