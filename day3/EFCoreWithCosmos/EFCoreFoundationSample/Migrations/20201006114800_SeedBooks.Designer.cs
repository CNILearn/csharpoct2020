﻿// <auto-generated />
using EFCoreFoundationSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreFoundationSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20201006114800_SeedBooks")]
    partial class SeedBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("EFCoreFoundationSample.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Publisher")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Publisher = "sample pub",
                            Title = "title 1"
                        },
                        new
                        {
                            BookId = 2,
                            Publisher = "sample pub",
                            Title = "title 2"
                        },
                        new
                        {
                            BookId = 3,
                            Publisher = "sample pub",
                            Title = "title 3"
                        },
                        new
                        {
                            BookId = 4,
                            Publisher = "sample pub",
                            Title = "title 4"
                        },
                        new
                        {
                            BookId = 5,
                            Publisher = "sample pub",
                            Title = "title 5"
                        },
                        new
                        {
                            BookId = 6,
                            Publisher = "sample pub",
                            Title = "title 6"
                        },
                        new
                        {
                            BookId = 7,
                            Publisher = "sample pub",
                            Title = "title 7"
                        },
                        new
                        {
                            BookId = 8,
                            Publisher = "sample pub",
                            Title = "title 8"
                        },
                        new
                        {
                            BookId = 9,
                            Publisher = "sample pub",
                            Title = "title 9"
                        },
                        new
                        {
                            BookId = 10,
                            Publisher = "sample pub",
                            Title = "title 10"
                        },
                        new
                        {
                            BookId = 11,
                            Publisher = "sample pub",
                            Title = "title 11"
                        },
                        new
                        {
                            BookId = 12,
                            Publisher = "sample pub",
                            Title = "title 12"
                        },
                        new
                        {
                            BookId = 13,
                            Publisher = "sample pub",
                            Title = "title 13"
                        },
                        new
                        {
                            BookId = 14,
                            Publisher = "sample pub",
                            Title = "title 14"
                        },
                        new
                        {
                            BookId = 15,
                            Publisher = "sample pub",
                            Title = "title 15"
                        },
                        new
                        {
                            BookId = 16,
                            Publisher = "sample pub",
                            Title = "title 16"
                        },
                        new
                        {
                            BookId = 17,
                            Publisher = "sample pub",
                            Title = "title 17"
                        },
                        new
                        {
                            BookId = 18,
                            Publisher = "sample pub",
                            Title = "title 18"
                        },
                        new
                        {
                            BookId = 19,
                            Publisher = "sample pub",
                            Title = "title 19"
                        },
                        new
                        {
                            BookId = 20,
                            Publisher = "sample pub",
                            Title = "title 20"
                        },
                        new
                        {
                            BookId = 21,
                            Publisher = "sample pub",
                            Title = "title 21"
                        },
                        new
                        {
                            BookId = 22,
                            Publisher = "sample pub",
                            Title = "title 22"
                        },
                        new
                        {
                            BookId = 23,
                            Publisher = "sample pub",
                            Title = "title 23"
                        },
                        new
                        {
                            BookId = 24,
                            Publisher = "sample pub",
                            Title = "title 24"
                        },
                        new
                        {
                            BookId = 25,
                            Publisher = "sample pub",
                            Title = "title 25"
                        },
                        new
                        {
                            BookId = 26,
                            Publisher = "sample pub",
                            Title = "title 26"
                        },
                        new
                        {
                            BookId = 27,
                            Publisher = "sample pub",
                            Title = "title 27"
                        },
                        new
                        {
                            BookId = 28,
                            Publisher = "sample pub",
                            Title = "title 28"
                        },
                        new
                        {
                            BookId = 29,
                            Publisher = "sample pub",
                            Title = "title 29"
                        },
                        new
                        {
                            BookId = 30,
                            Publisher = "sample pub",
                            Title = "title 30"
                        },
                        new
                        {
                            BookId = 31,
                            Publisher = "sample pub",
                            Title = "title 31"
                        },
                        new
                        {
                            BookId = 32,
                            Publisher = "sample pub",
                            Title = "title 32"
                        },
                        new
                        {
                            BookId = 33,
                            Publisher = "sample pub",
                            Title = "title 33"
                        },
                        new
                        {
                            BookId = 34,
                            Publisher = "sample pub",
                            Title = "title 34"
                        },
                        new
                        {
                            BookId = 35,
                            Publisher = "sample pub",
                            Title = "title 35"
                        },
                        new
                        {
                            BookId = 36,
                            Publisher = "sample pub",
                            Title = "title 36"
                        },
                        new
                        {
                            BookId = 37,
                            Publisher = "sample pub",
                            Title = "title 37"
                        },
                        new
                        {
                            BookId = 38,
                            Publisher = "sample pub",
                            Title = "title 38"
                        },
                        new
                        {
                            BookId = 39,
                            Publisher = "sample pub",
                            Title = "title 39"
                        },
                        new
                        {
                            BookId = 40,
                            Publisher = "sample pub",
                            Title = "title 40"
                        },
                        new
                        {
                            BookId = 41,
                            Publisher = "sample pub",
                            Title = "title 41"
                        },
                        new
                        {
                            BookId = 42,
                            Publisher = "sample pub",
                            Title = "title 42"
                        },
                        new
                        {
                            BookId = 43,
                            Publisher = "sample pub",
                            Title = "title 43"
                        },
                        new
                        {
                            BookId = 44,
                            Publisher = "sample pub",
                            Title = "title 44"
                        },
                        new
                        {
                            BookId = 45,
                            Publisher = "sample pub",
                            Title = "title 45"
                        },
                        new
                        {
                            BookId = 46,
                            Publisher = "sample pub",
                            Title = "title 46"
                        },
                        new
                        {
                            BookId = 47,
                            Publisher = "sample pub",
                            Title = "title 47"
                        },
                        new
                        {
                            BookId = 48,
                            Publisher = "sample pub",
                            Title = "title 48"
                        },
                        new
                        {
                            BookId = 49,
                            Publisher = "sample pub",
                            Title = "title 49"
                        },
                        new
                        {
                            BookId = 50,
                            Publisher = "sample pub",
                            Title = "title 50"
                        },
                        new
                        {
                            BookId = 51,
                            Publisher = "sample pub",
                            Title = "title 51"
                        },
                        new
                        {
                            BookId = 52,
                            Publisher = "sample pub",
                            Title = "title 52"
                        },
                        new
                        {
                            BookId = 53,
                            Publisher = "sample pub",
                            Title = "title 53"
                        },
                        new
                        {
                            BookId = 54,
                            Publisher = "sample pub",
                            Title = "title 54"
                        },
                        new
                        {
                            BookId = 55,
                            Publisher = "sample pub",
                            Title = "title 55"
                        },
                        new
                        {
                            BookId = 56,
                            Publisher = "sample pub",
                            Title = "title 56"
                        },
                        new
                        {
                            BookId = 57,
                            Publisher = "sample pub",
                            Title = "title 57"
                        },
                        new
                        {
                            BookId = 58,
                            Publisher = "sample pub",
                            Title = "title 58"
                        },
                        new
                        {
                            BookId = 59,
                            Publisher = "sample pub",
                            Title = "title 59"
                        },
                        new
                        {
                            BookId = 60,
                            Publisher = "sample pub",
                            Title = "title 60"
                        },
                        new
                        {
                            BookId = 61,
                            Publisher = "sample pub",
                            Title = "title 61"
                        },
                        new
                        {
                            BookId = 62,
                            Publisher = "sample pub",
                            Title = "title 62"
                        },
                        new
                        {
                            BookId = 63,
                            Publisher = "sample pub",
                            Title = "title 63"
                        },
                        new
                        {
                            BookId = 64,
                            Publisher = "sample pub",
                            Title = "title 64"
                        },
                        new
                        {
                            BookId = 65,
                            Publisher = "sample pub",
                            Title = "title 65"
                        },
                        new
                        {
                            BookId = 66,
                            Publisher = "sample pub",
                            Title = "title 66"
                        },
                        new
                        {
                            BookId = 67,
                            Publisher = "sample pub",
                            Title = "title 67"
                        },
                        new
                        {
                            BookId = 68,
                            Publisher = "sample pub",
                            Title = "title 68"
                        },
                        new
                        {
                            BookId = 69,
                            Publisher = "sample pub",
                            Title = "title 69"
                        },
                        new
                        {
                            BookId = 70,
                            Publisher = "sample pub",
                            Title = "title 70"
                        },
                        new
                        {
                            BookId = 71,
                            Publisher = "sample pub",
                            Title = "title 71"
                        },
                        new
                        {
                            BookId = 72,
                            Publisher = "sample pub",
                            Title = "title 72"
                        },
                        new
                        {
                            BookId = 73,
                            Publisher = "sample pub",
                            Title = "title 73"
                        },
                        new
                        {
                            BookId = 74,
                            Publisher = "sample pub",
                            Title = "title 74"
                        },
                        new
                        {
                            BookId = 75,
                            Publisher = "sample pub",
                            Title = "title 75"
                        },
                        new
                        {
                            BookId = 76,
                            Publisher = "sample pub",
                            Title = "title 76"
                        },
                        new
                        {
                            BookId = 77,
                            Publisher = "sample pub",
                            Title = "title 77"
                        },
                        new
                        {
                            BookId = 78,
                            Publisher = "sample pub",
                            Title = "title 78"
                        },
                        new
                        {
                            BookId = 79,
                            Publisher = "sample pub",
                            Title = "title 79"
                        },
                        new
                        {
                            BookId = 80,
                            Publisher = "sample pub",
                            Title = "title 80"
                        },
                        new
                        {
                            BookId = 81,
                            Publisher = "sample pub",
                            Title = "title 81"
                        },
                        new
                        {
                            BookId = 82,
                            Publisher = "sample pub",
                            Title = "title 82"
                        },
                        new
                        {
                            BookId = 83,
                            Publisher = "sample pub",
                            Title = "title 83"
                        },
                        new
                        {
                            BookId = 84,
                            Publisher = "sample pub",
                            Title = "title 84"
                        },
                        new
                        {
                            BookId = 85,
                            Publisher = "sample pub",
                            Title = "title 85"
                        },
                        new
                        {
                            BookId = 86,
                            Publisher = "sample pub",
                            Title = "title 86"
                        },
                        new
                        {
                            BookId = 87,
                            Publisher = "sample pub",
                            Title = "title 87"
                        },
                        new
                        {
                            BookId = 88,
                            Publisher = "sample pub",
                            Title = "title 88"
                        },
                        new
                        {
                            BookId = 89,
                            Publisher = "sample pub",
                            Title = "title 89"
                        },
                        new
                        {
                            BookId = 90,
                            Publisher = "sample pub",
                            Title = "title 90"
                        },
                        new
                        {
                            BookId = 91,
                            Publisher = "sample pub",
                            Title = "title 91"
                        },
                        new
                        {
                            BookId = 92,
                            Publisher = "sample pub",
                            Title = "title 92"
                        },
                        new
                        {
                            BookId = 93,
                            Publisher = "sample pub",
                            Title = "title 93"
                        },
                        new
                        {
                            BookId = 94,
                            Publisher = "sample pub",
                            Title = "title 94"
                        },
                        new
                        {
                            BookId = 95,
                            Publisher = "sample pub",
                            Title = "title 95"
                        },
                        new
                        {
                            BookId = 96,
                            Publisher = "sample pub",
                            Title = "title 96"
                        },
                        new
                        {
                            BookId = 97,
                            Publisher = "sample pub",
                            Title = "title 97"
                        },
                        new
                        {
                            BookId = 98,
                            Publisher = "sample pub",
                            Title = "title 98"
                        },
                        new
                        {
                            BookId = 99,
                            Publisher = "sample pub",
                            Title = "title 99"
                        },
                        new
                        {
                            BookId = 100,
                            Publisher = "sample pub",
                            Title = "title 100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
