﻿using DAL.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 法人基本数据
    /// </summary>
    public class FLegalPerson : EntityBase
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string FEnterpriseName { get; set; }
        /// <summary>
        /// 工商注册号
        /// </summary>
        public string FRegistrationNumber { get; set; }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string FOrganizationalCode { get; set; }
        /// <summary>
        /// 税务登记号
        /// </summary>
        public string FTaxRegistrationNumber { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string FIDNumber { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string FResidence { get; set; }
        /// <summary>
        /// 注册资本（金）
        /// </summary>
        public string FRegisteredCapital { get; set; }
        /// <summary>
        /// 注册资本中外币
        /// </summary>
        public string FCurrency { get; set; }
        /// <summary>
        /// 外币币种
        /// </summary>
        public string FForeignCurrency { get; set; }
        /// <summary>
        /// 企业类型
        /// </summary>
        public string FTypesOfEnterprises { get; set; }
        /// <summary>
        /// 经营范围
        /// </summary>
        public string FBusinessScope { get; set; }
        /// <summary>
        /// 经营期限至
        /// </summary>
        public string FBusinessTermTo { get; set; }
        /// <summary>
        /// 成立日期
        /// </summary>
        public string FEstablishDate { get; set; }
        /// <summary>
        /// 隶属企业名称
        /// </summary>
        public string FSubjectionName { get; set; }
        /// <summary>
        /// 经营状态
        /// </summary>
        public string FManagementState { get; set; }
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string FCreditCode { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string FDataSources { get; set; }
        /// <summary>
        /// 核准日期
        /// </summary>
        public string FApprovalDate { get; set; }
        /// <summary>
        /// 行业代码
        /// </summary>
        public string FIndustryCode { get; set; }
        /// <summary>
        /// 登记机关
        /// </summary>
        public string FRegistrationAuthority { get; set; }
        /// <summary>
        /// 经营场所
        /// </summary>
        public string FPlaceOfBusiness { get; set; }
        /// <summary>
        /// 分支机构标识
        /// </summary>
        public string FBranchIdentification { get; set; }
        /// <summary>
        /// 其他表彰F集合
        /// </summary>
        public ICollection<FOtherCommendation> FOtherCommendations { get; set; }
        /// <summary>
        /// 行政许可F集合
        /// </summary>
        public ICollection<FAdministrativeLicensing> FAdministrativeLicensings { get; set; }
        /// <summary>
        /// 行政处罚F集合
        /// </summary>
        public ICollection<FAdministrativeSanction> FAdministrativeSanctions { get; set; }
        /// <summary>
        /// 行政奖励F集合
        /// </summary>
        public ICollection<FAdministrativeReward> FAdministrativeRewards { get; set; }
        /// <summary>
        /// 行政检查F集合
        /// </summary>
        public ICollection<FAdministrativeExamination> FAdministrativeExaminations { get; set; }
        /// <summary>
        /// 行政强制F集合
        /// </summary>
        public ICollection<FAdministrativeCoercion> FAdministrativeCoercions { get; set; }
        /// <summary>
        /// 失信被执行人F集合
        /// </summary>
        public ICollection<FDishonestExecutor> FDishonestExecutors { get; set; }
        /// <summary>
        /// 其他处罚F集合
        /// </summary>
        public ICollection<FOtherPenalties> FOtherPenaltiess { get; set; }
    }
    public class FLegalPersonConfiguration : IEntityTypeConfiguration<FLegalPerson>
    {
        public void Configure(EntityTypeBuilder<FLegalPerson> builder)
        {
            builder.Property(x => x.FEnterpriseName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FRegistrationNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FOrganizationalCode).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FTaxRegistrationNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FIDNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FResidence).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FRegisteredCapital).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCurrency).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FForeignCurrency).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FTypesOfEnterprises).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FBusinessScope).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FBusinessTermTo).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEstablishDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FSubjectionName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FManagementState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCreditCode).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FDataSources).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FApprovalDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FIndustryCode).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FRegistrationAuthority).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPlaceOfBusiness).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FBranchIdentification).IsRequired(false).HasMaxLength(200);
        }
    }
}
