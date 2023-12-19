using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData(
            new Order
            {
                Id = 1,
                Number = "1-1",
                Date = new DateTime(2023, 10, 10),
                ProviderId = 1,
            },
            new Order
            {
                Id = 2,
                Number = "1-2",
                Date = new DateTime(2023, 10, 11),
                ProviderId = 1,
            },
            new Order
            {
                Id = 3,
                Number = "1-3",
                Date = new DateTime(2023, 10, 11),
                ProviderId = 1,
            },
            new Order
            {
                Id = 4,
                Number = "2-1",
                Date = new DateTime(2023, 10, 12),
                ProviderId = 2,
            },
            new Order
            {
                Id = 5,
                Number = "2-2",
                Date = new DateTime(2023, 10, 13),
                ProviderId = 2,
            },
            new Order
            {
                Id = 6,
                Number = "2-3",
                Date = new DateTime(2023, 10, 13),
                ProviderId = 2,
            },
            new Order
            {
                Id = 7,
                Number = "3-1",
                Date = new DateTime(2023, 10, 21),
                ProviderId = 3,
            },
            new Order
            {
                Id = 8,
                Number = "3-2",
                Date = new DateTime(2023, 10, 25),
                ProviderId = 3,
            },
            new Order
            {
                Id = 9,
                Number = "3-3",
                Date = new DateTime(2023, 10, 27),
                ProviderId = 3,
            },
            new Order
            {
                Id = 10,
                Number = "4-1",
                Date = new DateTime(2023, 11, 05),
                ProviderId = 4,
            },
            new Order
            {
                Id = 11,
                Number = "4-2",
                Date = new DateTime(2023, 11, 10),
                ProviderId = 4,
            },
            new Order
            {
                Id = 12,
                Number = "4-3",
                Date = new DateTime(2023, 11, 17),
                ProviderId = 4,
            },
            new Order
            {
                Id = 13,
                Number = "5-1",
                Date = new DateTime(2023, 11, 19),
                ProviderId = 5,
            },
            new Order
            {
                Id = 14,
                Number = "5-2",
                Date = new DateTime(2023, 11, 21),
                ProviderId = 5,
            },
            new Order
            {
                Id = 15,
                Number = "5-3",
                Date = new DateTime(2023, 11, 25),
                ProviderId = 5,
            },
            new Order
            {
                Id = 16,
                Number = "6-1",
                Date = new DateTime(2023, 11, 27),
                ProviderId = 6,
            },
            new Order
            {
                Id = 17,
                Number = "6-2",
                Date = new DateTime(2023, 11, 29),
                ProviderId = 6,
            },
            new Order
            {
                Id = 18,
                Number = "6-3",
                Date = new DateTime(2023, 12, 1),
                ProviderId = 6,
            },
            new Order
            {
                Id = 19,
                Number = "7-1",
                Date = new DateTime(2023, 12, 2),
                ProviderId = 7,
            },
            new Order
            {
                Id = 20,
                Number = "7-2",
                Date = new DateTime(2023, 12, 3),
                ProviderId = 7,
            },
            new Order
            {
                Id = 21,
                Number = "7-3",
                Date = new DateTime(2023, 12, 4),
                ProviderId = 7,
            }
        );
    }
}
