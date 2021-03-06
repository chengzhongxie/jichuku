﻿// <auto-generated />
using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181226022435_To2")]
    partial class To2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Model.FAdministrativeCoercion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FAdministrativeOrgan")
                        .HasMaxLength(200);

                    b.Property<string>("FBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FEntryName")
                        .HasMaxLength(200);

                    b.Property<string>("FExecutionDate")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FMandatoryContent")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FAdministrativeCoercion");
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeExamination", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("FExaminationResult")
                        .HasMaxLength(200);

                    b.Property<string>("FInspectionBasis")
                        .HasMaxLength(200);

                    b.Property<string>("FInspectionDate")
                        .HasMaxLength(200);

                    b.Property<string>("FInspectionOrgan")
                        .HasMaxLength(200);

                    b.Property<string>("FInspectionReason")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FAdministrativeExamination");
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeLicensing", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FApprovalCategory")
                        .HasMaxLength(200);

                    b.Property<string>("FBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("FDeadline")
                        .HasMaxLength(200);

                    b.Property<string>("FEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("FEntryName")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FLicensingAuthority")
                        .HasMaxLength(200);

                    b.Property<string>("FLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("FPermissionContent")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FAdministrativeLicensing");
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeReward", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FCommendationDate")
                        .HasMaxLength(200);

                    b.Property<string>("FCommendationSymbol")
                        .HasMaxLength(200);

                    b.Property<string>("FCommendationUnit")
                        .HasMaxLength(200);

                    b.Property<string>("FHonoraryTitle")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FAdministrativeReward");
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeSanction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("FDeadline")
                        .HasMaxLength(200);

                    b.Property<string>("FEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("FNameOfCase")
                        .HasMaxLength(200);

                    b.Property<string>("FPenaltyResult")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentBasis")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentCategory")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentCause")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentOrgan")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FAdministrativeSanction");
                });

            modelBuilder.Entity("DAL.Model.FDishonestExecutor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BreachOfFaith")
                        .HasMaxLength(200);

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FCaseStatus")
                        .HasMaxLength(200);

                    b.Property<string>("FCourtOfExecution")
                        .HasMaxLength(200);

                    b.Property<string>("FDefiniteObligations")
                        .HasColumnType("ntext");

                    b.Property<string>("FEnforcementCase")
                        .HasMaxLength(200);

                    b.Property<string>("FEnforcementNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FExecutionNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FFilingDate")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FPerformance")
                        .HasMaxLength(200);

                    b.Property<string>("ReleaseTime")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FDishonestExecutor");
                });

            modelBuilder.Entity("DAL.Model.FLegalPerson", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FApprovalDate")
                        .HasMaxLength(200);

                    b.Property<string>("FBranchIdentification")
                        .HasMaxLength(200);

                    b.Property<string>("FBusinessScope")
                        .HasMaxLength(200);

                    b.Property<string>("FBusinessTermTo")
                        .HasMaxLength(200);

                    b.Property<string>("FCreditCode")
                        .HasMaxLength(200);

                    b.Property<string>("FCurrency")
                        .HasMaxLength(200);

                    b.Property<string>("FDataSources")
                        .HasMaxLength(200);

                    b.Property<string>("FEnterpriseName")
                        .HasMaxLength(200);

                    b.Property<string>("FEstablishDate")
                        .HasMaxLength(200);

                    b.Property<string>("FForeignCurrency")
                        .HasMaxLength(200);

                    b.Property<string>("FIDNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FIndustryCode")
                        .HasMaxLength(200);

                    b.Property<string>("FManagementState")
                        .HasMaxLength(200);

                    b.Property<string>("FOrganizationalCode")
                        .HasMaxLength(200);

                    b.Property<string>("FPlaceOfBusiness")
                        .HasMaxLength(200);

                    b.Property<string>("FRegisteredCapital")
                        .HasMaxLength(200);

                    b.Property<string>("FRegistrationAuthority")
                        .HasMaxLength(200);

                    b.Property<string>("FRegistrationNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FResidence")
                        .HasMaxLength(200);

                    b.Property<string>("FSubjectionName")
                        .HasMaxLength(200);

                    b.Property<string>("FTaxRegistrationNumber")
                        .HasMaxLength(200);

                    b.Property<string>("FTypesOfEnterprises")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.ToTable("FLegalPerson");
                });

            modelBuilder.Entity("DAL.Model.FOtherCommendation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FCommendationDate")
                        .HasMaxLength(200);

                    b.Property<string>("FCommendationSymbol")
                        .HasMaxLength(200);

                    b.Property<string>("FCommendationUnit")
                        .HasMaxLength(200);

                    b.Property<string>("FHonoraryTitle")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FOtherCommendation");
                });

            modelBuilder.Entity("DAL.Model.FOtherPenalties", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("FDeadline")
                        .HasMaxLength(200);

                    b.Property<string>("FEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("FLegalPersonID");

                    b.Property<string>("FLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("FNameOfCase")
                        .HasMaxLength(200);

                    b.Property<string>("FPenaltyResult")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentBasis")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentCategory")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentCause")
                        .HasMaxLength(200);

                    b.Property<string>("FPunishmentOrgan")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("FLegalPersonID");

                    b.ToTable("FOtherPenalties");
                });

            modelBuilder.Entity("DAL.Model.SysException", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CreatePerson")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("LeiXing")
                        .HasMaxLength(200);

                    b.Property<string>("Message")
                        .HasMaxLength(2000);

                    b.Property<string>("Remarks")
                        .HasMaxLength(1000);

                    b.Property<string>("Result")
                        .HasMaxLength(200);

                    b.Property<int?>("Sort");

                    b.Property<string>("State")
                        .HasMaxLength(200);

                    b.Property<string>("UpdatePerson")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("SysException");
                });

            modelBuilder.Entity("DAL.Model.SysLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Callsite");

                    b.Property<string>("Exception");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Logged");

                    b.Property<string>("Logger")
                        .HasMaxLength(250);

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SysLog");
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeCoercion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZAdministrativeOrgan")
                        .HasMaxLength(200);

                    b.Property<string>("ZBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZEntryName")
                        .HasMaxLength(200);

                    b.Property<string>("ZExecutionDate")
                        .HasMaxLength(200);

                    b.Property<string>("ZMandatoryContent")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZAdministrativeCoercion");
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeLicensing", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZApprovalCategory")
                        .HasMaxLength(200);

                    b.Property<string>("ZBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("ZDeadline")
                        .HasMaxLength(200);

                    b.Property<string>("ZEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("ZEntryName")
                        .HasMaxLength(200);

                    b.Property<string>("ZLicensingAuthority")
                        .HasMaxLength(200);

                    b.Property<string>("ZLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<string>("ZPermissionContent")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZAdministrativeLicensing");
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeReward", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZCommendationDate")
                        .HasMaxLength(200);

                    b.Property<string>("ZCommendationSymbol")
                        .HasMaxLength(200);

                    b.Property<string>("ZCommendationUnit")
                        .HasMaxLength(200);

                    b.Property<string>("ZHonoraryTitle")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZAdministrativeReward");
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeSanction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZBookNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("ZDeadline")
                        .HasMaxLength(200);

                    b.Property<string>("ZEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("ZLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("ZNameOfCase")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<string>("ZPenaltyResult")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentBasis")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentCategory")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentCause")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentOrgan")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZAdministrativeSanction");
                });

            modelBuilder.Entity("DAL.Model.ZDishonestExecutor", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BreachOfFaith")
                        .HasMaxLength(200);

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("ReleaseTime")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZCaseStatus")
                        .HasMaxLength(200);

                    b.Property<string>("ZCourtOfExecution")
                        .HasMaxLength(200);

                    b.Property<string>("ZDefiniteObligations")
                        .HasColumnType("ntext");

                    b.Property<string>("ZEnforcementCase")
                        .HasMaxLength(200);

                    b.Property<string>("ZEnforcementNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZExecutionNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZFilingDate")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<string>("ZPerformance")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZDishonestExecutor");
                });

            modelBuilder.Entity("DAL.Model.ZNaturalPerson", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZCompany")
                        .HasMaxLength(200);

                    b.Property<string>("ZDataSources")
                        .HasMaxLength(200);

                    b.Property<string>("ZDocumentType")
                        .HasMaxLength(200);

                    b.Property<string>("ZLdentificationNumber")
                        .HasMaxLength(200);

                    b.Property<string>("ZName")
                        .HasMaxLength(200);

                    b.Property<string>("ZPost")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.ToTable("ZNaturalPerson");
                });

            modelBuilder.Entity("DAL.Model.ZOtherCommendation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZCommendationDate")
                        .HasMaxLength(200);

                    b.Property<string>("ZCommendationSymbol")
                        .HasMaxLength(200);

                    b.Property<string>("ZCommendationUnit")
                        .HasMaxLength(200);

                    b.Property<string>("ZHonoraryTitle")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZOtherCommendation");
                });

            modelBuilder.Entity("DAL.Model.ZOtherPenalties", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatePerson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remarks");

                    b.Property<string>("State");

                    b.Property<string>("UpdatePerson");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<DateTime?>("Version");

                    b.Property<string>("ZCurrentState")
                        .HasMaxLength(200);

                    b.Property<string>("ZEffectivePeriod")
                        .HasMaxLength(200);

                    b.Property<string>("ZLocalCoding")
                        .HasMaxLength(200);

                    b.Property<string>("ZNameOfCase")
                        .HasMaxLength(200);

                    b.Property<string>("ZNaturalPersonID");

                    b.Property<string>("ZPenaltyResult")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentBasis")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentCategory")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentCause")
                        .HasMaxLength(200);

                    b.Property<string>("ZPunishmentOrgan")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ZUpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("ZNaturalPersonID");

                    b.ToTable("ZOtherPenalties");
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeCoercion", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FAdministrativeCoercions")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeExamination", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FAdministrativeExaminations")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeLicensing", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FAdministrativeLicensings")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeReward", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FAdministrativeRewards")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FAdministrativeSanction", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FAdministrativeSanctions")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FDishonestExecutor", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FDishonestExecutors")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FOtherCommendation", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FOtherCommendations")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.FOtherPenalties", b =>
                {
                    b.HasOne("DAL.Model.FLegalPerson", "FLegalPerson")
                        .WithMany("FOtherPenaltiess")
                        .HasForeignKey("FLegalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeCoercion", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZAdministrativeCoercions")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeLicensing", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZAdministrativeLicensings")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeReward", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZAdministrativeRewards")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZAdministrativeSanction", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZAdministrativeSanctions")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZDishonestExecutor", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZDishonestExecutors")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZOtherCommendation", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZOtherCommendations")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.ZOtherPenalties", b =>
                {
                    b.HasOne("DAL.Model.ZNaturalPerson", "ZNaturalPerson")
                        .WithMany("ZOtherPenaltiess")
                        .HasForeignKey("ZNaturalPersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
