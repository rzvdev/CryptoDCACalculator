﻿// <auto-generated />
using System;
using CryptoDCA.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241016165217_AddCurrenciesAndCurrenciesTypes")]
    partial class AddCurrenciesAndCurrenciesTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CryptoDCA.DataModel.Context.Currencies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GOT_CURRENCY_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("GOT_CURRENCY_ISACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GOT_CURRENCY_NAME");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GOT_CURRENCY_SYMBOL");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("GOT_CURRENCY_TYPE_ID");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("GOT_CURRENCY");
                });

            modelBuilder.Entity("CryptoDCA.DataModel.Context.CurrencyTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GOT_CURRENCY_TYPE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GOT_CURRENCY_TYPE_DESCRIPTION");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("GOT_CURRENCY_TYPE_ISACTIVE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GOT_CURRENCY_TYPE_NAME");

                    b.Property<string>("ProgId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GOT_CURRENCY_TYPE_PROGID");

                    b.HasKey("Id");

                    b.ToTable("GOT_CURRENCY_TYPE");
                });

            modelBuilder.Entity("CryptoDCA.DataModel.Context.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BOT_INVESTMENT_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CryptoValue")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BOT_INVESTMENT_CRYPTOCURRENCYAMOUNT");

                    b.Property<string>("Cryptocurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BOT_INVESTMENT_CRYPTOCURRENCY");

                    b.Property<decimal>("CurrentValue")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BOT_INVESTMENT_CURRENTVALUE");

                    b.Property<decimal>("InvestedAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BOT_INVESTMENT_INVESTEDAMOUNT");

                    b.Property<DateTime>("InvestmentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BOT_INVESTMENT_DATE");

                    b.Property<decimal>("ROI")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BOT_INVESTMENT_ROI");

                    b.HasKey("Id");

                    b.ToTable("BOT_INVESTMENT");
                });

            modelBuilder.Entity("CryptoDCA.DataModel.Context.Currencies", b =>
                {
                    b.HasOne("CryptoDCA.DataModel.Context.CurrencyTypes", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
