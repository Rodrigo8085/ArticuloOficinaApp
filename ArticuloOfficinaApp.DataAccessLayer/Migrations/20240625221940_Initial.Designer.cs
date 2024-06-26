﻿// <auto-generated />
using System;
using ArticuloOficinaApp.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArticuloOfficinaApp.DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240625221940_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArticuloOficinaApp.Models.Articulos", b =>
                {
                    b.Property<int>("IdArticulos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idArticulo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArticulos"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("codigo");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar")
                        .HasColumnName("descripcion");

                    b.Property<string>("Imagen")
                        .HasColumnType("varchar")
                        .HasColumnName("imagen");

                    b.Property<double>("Precio")
                        .HasColumnType("float")
                        .HasColumnName("precio");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("IdArticulos");

                    b.ToTable("articulos");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Cliente", b =>
                {
                    b.Property<int>("IdClientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idClientes");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClientes"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("apellidos");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("IdClientes");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Login", b =>
                {
                    b.Property<int>("IdLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idLogin");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLogin"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("eMail");

                    b.Property<int>("IdClientes")
                        .HasColumnType("int")
                        .HasColumnName("idClientes");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("IdLogin");

                    b.HasIndex("IdClientes");

                    b.ToTable("login");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Tienda", b =>
                {
                    b.Property<int>("IdTienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idTienda");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTienda"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<string>("Sucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sucursal");

                    b.HasKey("IdTienda");

                    b.ToTable("tienda");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Tienda_Articulos", b =>
                {
                    b.Property<int>("IdTiendaArticulos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idTiendaArticulos");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTiendaArticulos"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<int>("IdArticulos")
                        .HasColumnType("int")
                        .HasColumnName("idArticulos");

                    b.Property<int>("IdTienda")
                        .HasColumnType("int")
                        .HasColumnName("idTienda");

                    b.HasKey("IdTiendaArticulos");

                    b.HasIndex("IdArticulos");

                    b.HasIndex("IdTienda");

                    b.ToTable("tiendaArticulos");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idVenta");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<int>("IdArticulo")
                        .HasColumnType("int")
                        .HasColumnName("idArticulo");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.HasKey("IdVenta");

                    b.HasIndex("IdArticulo");

                    b.HasIndex("IdCliente");

                    b.ToTable("venta");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Login", b =>
                {
                    b.HasOne("ArticuloOficinaApp.Models.Cliente", "Cliente")
                        .WithMany("Login")
                        .HasForeignKey("IdClientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Tienda_Articulos", b =>
                {
                    b.HasOne("ArticuloOficinaApp.Models.Articulos", "Articulos")
                        .WithMany("Tienda_Articulos")
                        .HasForeignKey("IdArticulos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticuloOficinaApp.Models.Tienda", "Tienda")
                        .WithMany("Tienda_Articulos")
                        .HasForeignKey("IdTienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulos");

                    b.Navigation("Tienda");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Venta", b =>
                {
                    b.HasOne("ArticuloOficinaApp.Models.Articulos", "Articulos")
                        .WithMany("Venta")
                        .HasForeignKey("IdArticulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticuloOficinaApp.Models.Cliente", "Cliente")
                        .WithMany("Venta")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulos");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Articulos", b =>
                {
                    b.Navigation("Tienda_Articulos");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Cliente", b =>
                {
                    b.Navigation("Login");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("ArticuloOficinaApp.Models.Tienda", b =>
                {
                    b.Navigation("Tienda_Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
