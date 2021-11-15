﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreDL;

namespace StoreDL.Migrations
{
    [DbContext(typeof(DBp0Context))]
    [Migration("20211115001653_InvCheckTable")]
    partial class InvCheckTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LineItemPurchaseOrder", b =>
                {
                    b.Property<int>("LineItemLineId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.HasKey("LineItemLineId", "OrdersOrderId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("LineItemPurchaseOrder");
                });

            modelBuilder.Entity("StoreModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Customer_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("First_Name");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Last_Name");

                    b.Property<int>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("Phone");

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Street_Address");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("StoreModels.Inventory", b =>
                {
                    b.Property<int>("InvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Inv_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Prod_Id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.Property<int?>("StoreFrontStoreId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("Store_Id");

                    b.HasKey("InvId")
                        .HasName("PK__InvId__A2F2A30CAD3172F2");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("StoreFrontStoreId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("StoreModels.LineItem", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Line_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Prod_Id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("LineId")
                        .HasName("PK__LineId__A2F2A30CAD3172F2");

                    b.HasIndex("ProductId");

                    b.ToTable("Line_Item");
                });

            modelBuilder.Entity("StoreModels.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Product_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Category");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Description");

                    b.Property<string>("ItemName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Item_Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("Price");

                    b.Property<int?>("StoreFrontStoreId")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("PK__ProductId__A2F2A30CAD3172F2");

                    b.HasIndex("StoreFrontStoreId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("StoreModels.PurchaseOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Order_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_Id");

                    b.Property<int>("StoreFrontId")
                        .HasColumnType("int")
                        .HasColumnName("Store_Id");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("Total_Price");

                    b.HasKey("OrderId")
                        .HasName("PK__OrderId__A2F2A30CAD3172F2");

                    b.HasIndex("CustomerId");

                    b.ToTable("Purchase_Order");
                });

            modelBuilder.Entity("StoreModels.StoreFront", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Store_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("City");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("State");

                    b.Property<string>("StoreName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Store_Name");

                    b.HasKey("StoreId")
                        .HasName("PK__StoreFro__A2F2A30CAD3172F2");

                    b.ToTable("Store_Front");
                });

            modelBuilder.Entity("StoreModels.StoreInvCheck", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Product_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ItemName");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("Store_Id");

                    b.HasKey("ProductId")
                        .HasName("PK__StockProdId__");

                    b.ToTable("StoreInvCheck");
                });

            modelBuilder.Entity("LineItemPurchaseOrder", b =>
                {
                    b.HasOne("StoreModels.LineItem", null)
                        .WithMany()
                        .HasForeignKey("LineItemLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreModels.PurchaseOrder", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreModels.Inventory", b =>
                {
                    b.HasOne("StoreModels.Product", "Product")
                        .WithOne("Inventory")
                        .HasForeignKey("StoreModels.Inventory", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreModels.StoreFront", "StoreFront")
                        .WithMany()
                        .HasForeignKey("StoreFrontStoreId");

                    b.Navigation("Product");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("StoreModels.LineItem", b =>
                {
                    b.HasOne("StoreModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreModels.Product", b =>
                {
                    b.HasOne("StoreModels.StoreFront", "StoreFront")
                        .WithMany()
                        .HasForeignKey("StoreFrontStoreId");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("StoreModels.PurchaseOrder", b =>
                {
                    b.HasOne("StoreModels.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreModels.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("StoreModels.Product", b =>
                {
                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
