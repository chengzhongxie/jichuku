﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 其他表彰
    /// </summary>
    public class ZOtherCommendation : FatherClass
    {
        /// <summary>
        /// 荣誉称号/获奖名称
        /// </summary>
        public string ZHonoraryTitle { get; set; }
        /// <summary>
        /// 表彰（授予/评定）单位
        /// </summary>
        public string ZCommendationUnit { get; set; }
        /// <summary>
        /// 表彰（授予/评定）日期
        /// </summary>
        public string ZCommendationDate { get; set; }
        /// <summary>
        /// 表彰（授予/评定）文号
        /// </summary>
        public string ZCommendationSymbol { get; set; }
        /// <summary>
        /// 自然人基本数据id
        /// </summary>
        public string ZNaturalPersonID { get; set; }
        /// <summary>
        /// 自然人基本数据
        /// </summary>
        public ZNaturalPerson ZNaturalPerson { get; set; }
    }
    public class ZOtherCommendationConfiguration : IEntityTypeConfiguration<ZOtherCommendation>
    {
        public void Configure(EntityTypeBuilder<ZOtherCommendation> builder)
        {
            builder.Property(x => x.ZHonoraryTitle).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCommendationUnit).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCommendationDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCommendationSymbol).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.ZNaturalPerson).WithMany(x => x.ZOtherCommendations).HasForeignKey(x => x.ZNaturalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
