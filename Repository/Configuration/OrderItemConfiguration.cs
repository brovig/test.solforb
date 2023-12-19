using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasData(
            new OrderItem
            {
                Id = 1,
                OrderId = 1,
                Name = "Товар №1",
                Quantity = 5,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 2,
                OrderId = 1,
                Name = "Товар №2",
                Quantity = 1,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 3,
                OrderId = 2,
                Name = "Товар №3",
                Quantity = 8,
                Unit = "кг"
            },
            new OrderItem
            {
                Id = 4,
                OrderId = 3,
                Name = "Товар №4",
                Quantity = 1,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 5,
                OrderId = 3,
                Name = "Товар №5",
                Quantity = 8,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 6,
                OrderId = 4,
                Name = "Товар №6",
                Quantity = 5,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 7,
                OrderId = 5,
                Name = "Товар №7",
                Quantity = 1,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 8,
                OrderId = 5,
                Name = "Товар №8",
                Quantity = 10,
                Unit = "т"
            },
            new OrderItem
            {
                Id = 9,
                OrderId = 6,
                Name = "Товар №9",
                Quantity = 10,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 10,
                OrderId = 7,
                Name = "Товар №10",
                Quantity = 15,
                Unit = "шт"
            },
            new OrderItem
            {
                Id = 11,
                OrderId = 7,
                Name = "Товар №11",
                Quantity = 3,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 12,
                OrderId = 8,
                Name = "Товар №12",
                Quantity = 5,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 13,
                OrderId = 9,
                Name = "Товар №13",
                Quantity = 4,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 14,
                OrderId = 9,
                Name = "Товар №14",
                Quantity = 20,
                Unit = "т"
            },
            new OrderItem
            {
                Id = 15,
                OrderId = 10,
                Name = "Товар №15",
                Quantity = 5,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 16,
                OrderId = 11,
                Name = "Товар №16",
                Quantity = 1,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 17,
                OrderId = 11,
                Name = "Товар №17",
                Quantity = 8,
                Unit = "кг"
            },
            new OrderItem
            {
                Id = 18,
                OrderId = 12,
                Name = "Товар №18",
                Quantity = 1,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 19,
                OrderId = 13,
                Name = "Товар №19",
                Quantity = 8,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 20,
                OrderId = 13,
                Name = "Товар №20",
                Quantity = 5,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 21,
                OrderId = 14,
                Name = "Товар №21",
                Quantity = 1,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 22,
                OrderId = 15,
                Name = "Товар №22",
                Quantity = 10,
                Unit = "т"
            },
            new OrderItem
            {
                Id = 23,
                OrderId = 15,
                Name = "Товар №23",
                Quantity = 10,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 24,
                OrderId = 16,
                Name = "Товар №24",
                Quantity = 15,
                Unit = "шт"
            },
            new OrderItem
            {
                Id = 25,
                OrderId = 17,
                Name = "Товар №25",
                Quantity = 3,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 26,
                OrderId = 18,
                Name = "Товар №26",
                Quantity = 17,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 27,
                OrderId = 18,
                Name = "Товар №27",
                Quantity = 1,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 28,
                OrderId = 19,
                Name = "Товар №28",
                Quantity = 16,
                Unit = "т"
            },
            new OrderItem
            {
                Id = 29,
                OrderId = 20,
                Name = "Товар №29",
                Quantity = 3,
                Unit = "м"
            },
            new OrderItem
            {
                Id = 30,
                OrderId = 20,
                Name = "Товар №30",
                Quantity = 3,
                Unit = "шт."
            },
            new OrderItem
            {
                Id = 31,
                OrderId = 21,
                Name = "Товар №31",
                Quantity = 6,
                Unit = "м2"
            },
            new OrderItem
            {
                Id = 32,
                OrderId = 21,
                Name = "Товар №32",
                Quantity = 30,
                Unit = "т"
            }
        );
    }
}
