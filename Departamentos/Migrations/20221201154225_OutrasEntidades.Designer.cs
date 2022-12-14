// <auto-generated />
using System;
using Departamentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Departamentos.Migrations
{
    [DbContext(typeof(DepartamentoContext))]
    [Migration("20221201154225_OutrasEntidades")]
    partial class OutrasEntidades
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Departamentos.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Departamentos.Models.RegistroDeVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("vendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("vendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Departamentos.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("float");

                    b.Property<int>("departamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departamentoId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Departamentos.Models.RegistroDeVendas", b =>
                {
                    b.HasOne("Departamentos.Models.Vendedor", "vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("vendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vendedor");
                });

            modelBuilder.Entity("Departamentos.Models.Vendedor", b =>
                {
                    b.HasOne("Departamentos.Models.Departamento", "departamento")
                        .WithMany("Vendedor")
                        .HasForeignKey("departamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("departamento");
                });

            modelBuilder.Entity("Departamentos.Models.Departamento", b =>
                {
                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Departamentos.Models.Vendedor", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
