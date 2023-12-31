﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace OrdersApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "1-1",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "1-2",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "1-3",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "2-1",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "2-2",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "2-3",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "3-1",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "3-2",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "3-3",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "4-1",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "4-2",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "4-3",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "5-1",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "5-2",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "5-3",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "6-1",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "6-2",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "6-3",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "7-1",
                            ProviderId = 7
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "7-2",
                            ProviderId = 7
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "7-3",
                            ProviderId = 7
                        });
                });

            modelBuilder.Entity("Domain.Entities.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,3)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Товар №1",
                            OrderId = 1,
                            Quantity = 5m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Товар №2",
                            OrderId = 1,
                            Quantity = 1m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Товар №3",
                            OrderId = 2,
                            Quantity = 8m,
                            Unit = "кг"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Товар №4",
                            OrderId = 3,
                            Quantity = 1m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Товар №5",
                            OrderId = 3,
                            Quantity = 8m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 6,
                            Name = "Товар №6",
                            OrderId = 4,
                            Quantity = 5m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Товар №7",
                            OrderId = 5,
                            Quantity = 1m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Товар №8",
                            OrderId = 5,
                            Quantity = 10m,
                            Unit = "т"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Товар №9",
                            OrderId = 6,
                            Quantity = 10m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Товар №10",
                            OrderId = 7,
                            Quantity = 15m,
                            Unit = "шт"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Товар №11",
                            OrderId = 7,
                            Quantity = 3m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Товар №12",
                            OrderId = 8,
                            Quantity = 5m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 13,
                            Name = "Товар №13",
                            OrderId = 9,
                            Quantity = 4m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Товар №14",
                            OrderId = 9,
                            Quantity = 20m,
                            Unit = "т"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Товар №15",
                            OrderId = 10,
                            Quantity = 5m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Товар №16",
                            OrderId = 11,
                            Quantity = 1m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 17,
                            Name = "Товар №17",
                            OrderId = 11,
                            Quantity = 8m,
                            Unit = "кг"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Товар №18",
                            OrderId = 12,
                            Quantity = 1m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Товар №19",
                            OrderId = 13,
                            Quantity = 8m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 20,
                            Name = "Товар №20",
                            OrderId = 13,
                            Quantity = 5m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Товар №21",
                            OrderId = 14,
                            Quantity = 1m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Товар №22",
                            OrderId = 15,
                            Quantity = 10m,
                            Unit = "т"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Товар №23",
                            OrderId = 15,
                            Quantity = 10m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Товар №24",
                            OrderId = 16,
                            Quantity = 15m,
                            Unit = "шт"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Товар №25",
                            OrderId = 17,
                            Quantity = 3m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Товар №26",
                            OrderId = 18,
                            Quantity = 17m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 27,
                            Name = "Товар №27",
                            OrderId = 18,
                            Quantity = 1m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Товар №28",
                            OrderId = 19,
                            Quantity = 16m,
                            Unit = "т"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Товар №29",
                            OrderId = 20,
                            Quantity = 3m,
                            Unit = "м"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Товар №30",
                            OrderId = 20,
                            Quantity = 3m,
                            Unit = "шт."
                        },
                        new
                        {
                            Id = 31,
                            Name = "Товар №31",
                            OrderId = 21,
                            Quantity = 6m,
                            Unit = "м2"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Товар №32",
                            OrderId = 21,
                            Quantity = 30m,
                            Unit = "т"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ООО \"Компания 1\""
                        },
                        new
                        {
                            Id = 2,
                            Name = "ООО \"Компания 2\""
                        },
                        new
                        {
                            Id = 3,
                            Name = "ООО \"Компания 3\""
                        },
                        new
                        {
                            Id = 4,
                            Name = "ООО \"Компания 4\""
                        },
                        new
                        {
                            Id = 5,
                            Name = "ООО \"Компания 5\""
                        },
                        new
                        {
                            Id = 6,
                            Name = "ООО \"Компания 6\""
                        },
                        new
                        {
                            Id = 7,
                            Name = "ООО \"Компания 7\""
                        });
                });

            modelBuilder.Entity("Domain.Entities.Models.Order", b =>
                {
                    b.HasOne("Domain.Entities.Models.Provider", "Provider")
                        .WithMany("Orders")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Domain.Entities.Models.OrderItem", b =>
                {
                    b.HasOne("Domain.Entities.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Domain.Entities.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Domain.Entities.Models.Provider", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
