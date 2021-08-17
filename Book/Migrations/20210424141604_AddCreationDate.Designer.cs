﻿// <auto-generated />
using System;
using Book.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Book.Migrations
{
    [DbContext(typeof(StoreWebSite2Context))]
    [Migration("20210424141604_AddCreationDate")]
    partial class AddCreationDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Book.Models.FinalyInvoice", b =>
                {
                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<double?>("Total")
                        .HasColumnType("float");

                    b.ToView("Finaly_Invoice");
                });

            modelBuilder.Entity("Book.Models.TbBusniesInfu", b =>
                {
                    b.Property<int>("BusniesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("BusniesCardNum")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("BusniesId");

                    b.HasIndex(new[] { "CustomerId" }, "IX_TbBusniesInfu_CustomerId")
                        .IsUnique();

                    b.ToTable("TbBusniesInfu");
                });

            modelBuilder.Entity("Book.Models.TbCashTransaction", b =>
                {
                    b.Property<int>("CashTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CashDate")
                        .HasColumnType("date");

                    b.Property<decimal>("CashValue")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CashTransactionId");

                    b.HasIndex("CustomerId");

                    b.ToTable("TbCashTransaction");
                });

            modelBuilder.Entity("Book.Models.TbCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("CategoryId");

                    b.ToTable("TbCategories");
                });

            modelBuilder.Entity("Book.Models.TbCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("CustomerId");

                    b.ToTable("TbCustomers");
                });

            modelBuilder.Entity("Book.Models.TbCustomerItem", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ItemId");

                    b.HasIndex(new[] { "ItemId" }, "IX_TbCustomerItems_ItemId");

                    b.ToTable("TbCustomerItems");
                });

            modelBuilder.Entity("Book.Models.TbItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TbItems");
                });

            modelBuilder.Entity("Book.Models.TbItemImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbItemImages");
                });

            modelBuilder.Entity("Book.Models.TbPurchaseInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("SupplierId");

                    b.ToTable("TbPurchaseInvoices");
                });

            modelBuilder.Entity("Book.Models.TbPurchaseInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("Book.Models.TbSalesInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DelivryDate")
                        .HasColumnType("date");

                    b.Property<int>("DelivryManId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("TbSalesInvoices");
                });

            modelBuilder.Entity("Book.Models.TbSalesInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Book.Models.TbSupplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                    b.HasKey("SupplierId")
                        .HasName("PK_TbSupplier");

                    b.ToTable("TbSuppliers");
                });

            modelBuilder.Entity("Models.TbSlider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discribtion")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Titel")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SliderId");

                    b.ToTable("TbSlider");
                });

            modelBuilder.Entity("Book.Models.TbBusniesInfu", b =>
                {
                    b.HasOne("Book.Models.TbCustomer", "Customer")
                        .WithOne("TbBusniesInfu")
                        .HasForeignKey("Book.Models.TbBusniesInfu", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Book.Models.TbCashTransaction", b =>
                {
                    b.HasOne("Book.Models.TbCustomer", "Customer")
                        .WithMany("TbCashTransactions")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_TbCashTransaction_TbCustomers")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Book.Models.TbCustomerItem", b =>
                {
                    b.HasOne("Book.Models.TbCustomer", "Customer")
                        .WithMany("TbCustomerItems")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book.Models.TbItem", "Item")
                        .WithMany("TbCustomerItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Book.Models.TbItem", b =>
                {
                    b.HasOne("Book.Models.TbCategory", "Category")
                        .WithMany("TbItems")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_TbItems_TbCategories")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Book.Models.TbItemImage", b =>
                {
                    b.HasOne("Book.Models.TbItem", "Item")
                        .WithMany("TbItemImages")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbItemImages_TbItems")
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Book.Models.TbPurchaseInvoice", b =>
                {
                    b.HasOne("Book.Models.TbSupplier", "Supplier")
                        .WithMany("TbPurchaseInvoices")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_TbPurchaseInvoices_TbSuppliers")
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Book.Models.TbPurchaseInvoiceItem", b =>
                {
                    b.HasOne("Book.Models.TbPurchaseInvoice", "Invoice")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbPurchaseInvoices")
                        .IsRequired();

                    b.HasOne("Book.Models.TbItem", "Item")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbItems")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Book.Models.TbSalesInvoice", b =>
                {
                    b.HasOne("Book.Models.TbCustomer", "Customer")
                        .WithMany("TbSalesInvoices")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_TbSalesInvoices_TbCustomers")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Book.Models.TbSalesInvoiceItem", b =>
                {
                    b.HasOne("Book.Models.TbSalesInvoice", "Invoice")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbSalesInvoices")
                        .IsRequired();

                    b.HasOne("Book.Models.TbItem", "Item")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbItems")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Book.Models.TbCategory", b =>
                {
                    b.Navigation("TbItems");
                });

            modelBuilder.Entity("Book.Models.TbCustomer", b =>
                {
                    b.Navigation("TbBusniesInfu");

                    b.Navigation("TbCashTransactions");

                    b.Navigation("TbCustomerItems");

                    b.Navigation("TbSalesInvoices");
                });

            modelBuilder.Entity("Book.Models.TbItem", b =>
                {
                    b.Navigation("TbCustomerItems");

                    b.Navigation("TbItemImages");

                    b.Navigation("TbPurchaseInvoiceItems");

                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Book.Models.TbPurchaseInvoice", b =>
                {
                    b.Navigation("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("Book.Models.TbSalesInvoice", b =>
                {
                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Book.Models.TbSupplier", b =>
                {
                    b.Navigation("TbPurchaseInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
