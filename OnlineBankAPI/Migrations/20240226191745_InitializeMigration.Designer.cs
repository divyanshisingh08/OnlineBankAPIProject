﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBankAPI.Models;

#nullable disable

namespace OnlineBankAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240226191745_InitializeMigration")]
    partial class InitializeMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineBankAPI.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<int>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfOpening")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountTypeName = "Current"
                        },
                        new
                        {
                            Id = 2,
                            AccountTypeName = "Savings"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Beneficiary", b =>
                {
                    b.Property<int>("BeneficiaryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BeneficiaryID"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("BeneficiaryAccountNumber")
                        .HasColumnType("float");

                    b.Property<string>("BeneficiaryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("BeneficiaryID");

                    b.ToTable("Beneficiaries");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.ChequeBook", b =>
                {
                    b.Property<int>("ChqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChqId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID1")
                        .HasColumnType("int");

                    b.HasKey("ChqId");

                    b.HasIndex("StatusID");

                    b.HasIndex("StatusID1");

                    b.ToTable("Chequeboooks");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("PAN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleTypeId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.HasIndex("GenderId");

                    b.HasIndex("RoleTypeId");

                    b.HasIndex("StatusID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("GenderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderType = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderType = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            GenderType = "Others"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Login", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("SecurityQuestionSqId")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("SecurityQuestionSqId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.RoleType", b =>
                {
                    b.Property<int>("RoleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleTypeId"));

                    b.Property<string>("RoleTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RoleTypeId");

                    b.ToTable("RoleTypes");

                    b.HasData(
                        new
                        {
                            RoleTypeId = 1,
                            RoleTypeName = "Manager"
                        },
                        new
                        {
                            RoleTypeId = 2,
                            RoleTypeName = "Customer"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.SecurityQuestion", b =>
                {
                    b.Property<int>("SqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SqId"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Question");

                    b.HasKey("SqId");

                    b.ToTable("SecurityQuestions");

                    b.HasData(
                        new
                        {
                            SqId = 1,
                            Question = "What is your mother's maiden name?"
                        },
                        new
                        {
                            SqId = 2,
                            Question = "What is the name of your first pet?"
                        },
                        new
                        {
                            SqId = 3,
                            Question = "What is your nick name?"
                        },
                        new
                        {
                            SqId = 4,
                            Question = "What elementary school did you attend?"
                        },
                        new
                        {
                            SqId = 5,
                            Question = "What is the name of the town where you were born?"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("StatusType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuss");

                    b.HasData(
                        new
                        {
                            StatusID = 1,
                            StatusType = "Pending"
                        },
                        new
                        {
                            StatusID = 2,
                            StatusType = "Approved"
                        },
                        new
                        {
                            StatusID = 3,
                            StatusType = "Rejected"
                        },
                        new
                        {
                            StatusID = 4,
                            StatusType = "Requested"
                        },
                        new
                        {
                            StatusID = 5,
                            StatusType = "Issued"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BeneficiaryId")
                        .HasColumnType("int");

                    b.Property<decimal>("ClosingBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("OpeningBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("TraId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionTypeTraId")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("AccountId");

                    b.HasIndex("BeneficiaryId");

                    b.HasIndex("StatusID");

                    b.HasIndex("TransactionTypeTraId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.TransactionType", b =>
                {
                    b.Property<int>("TraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraId"));

                    b.Property<string>("TransactionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraId");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            TraId = 1,
                            TransactionName = "Debit"
                        },
                        new
                        {
                            TraId = 2,
                            TransactionName = "Credit"
                        });
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Account", b =>
                {
                    b.HasOne("OnlineBankAPI.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.Customer", "Customer")
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.ChequeBook", b =>
                {
                    b.HasOne("OnlineBankAPI.Models.Account", "Account")
                        .WithMany("ChequeBooks")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.Status", "Status")
                        .WithMany("ChequeBooks")
                        .HasForeignKey("StatusID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Customer", b =>
                {
                    b.HasOne("OnlineBankAPI.Models.Gender", "Gender")
                        .WithMany("Customers")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.RoleType", "RoleType")
                        .WithMany("Customer")
                        .HasForeignKey("RoleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.Status", "Status")
                        .WithMany("Customers")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("RoleType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Login", b =>
                {
                    b.HasOne("OnlineBankAPI.Models.SecurityQuestion", null)
                        .WithMany("Login")
                        .HasForeignKey("SecurityQuestionSqId");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Transaction", b =>
                {
                    b.HasOne("OnlineBankAPI.Models.Account", "Accounts")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.Beneficiary", "Beneficiary")
                        .WithMany("Transactions")
                        .HasForeignKey("BeneficiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBankAPI.Models.TransactionType", "TransactionType")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionTypeTraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");

                    b.Navigation("Beneficiary");

                    b.Navigation("Status");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Account", b =>
                {
                    b.Navigation("ChequeBooks");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Beneficiary", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Customer", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Gender", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.RoleType", b =>
                {
                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.SecurityQuestion", b =>
                {
                    b.Navigation("Login");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.Status", b =>
                {
                    b.Navigation("ChequeBooks");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("OnlineBankAPI.Models.TransactionType", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
