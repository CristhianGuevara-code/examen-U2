﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using examen_U2.Database;

#nullable disable

namespace examen_U2.Migrations
{
    [DbContext(typeof(ExamenContext))]
    partial class ExamenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("examen_U2.Database.Entities.ClienteEntity", b =>
                {
                    b.Property<Guid>("identityNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("commissionRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("disbursementDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("firstPaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("interestRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loanAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("term")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("identityNumber");

                    b.ToTable("clientes", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
