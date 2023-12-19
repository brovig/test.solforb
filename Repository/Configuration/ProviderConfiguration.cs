using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> builder)
    {
        builder.HasData(
            new Provider
            {
                Id = 1,
                Name = "ООО \"Компания 1\"",
            },
            new Provider
            {
                Id = 2,
                Name = "ООО \"Компания 2\"",
            },
            new Provider
            {
                Id = 3,
                Name = "ООО \"Компания 3\"",
            },
            new Provider
            {
                Id = 4,
                Name = "ООО \"Компания 4\"",
            },
            new Provider
            {
                Id = 5,
                Name = "ООО \"Компания 5\"",
            },
            new Provider
            {
                Id = 6,
                Name = "ООО \"Компания 6\"",
            },
            new Provider
            {
                Id = 7,
                Name = "ООО \"Компания 7\"",
            }
        );
    }
}
