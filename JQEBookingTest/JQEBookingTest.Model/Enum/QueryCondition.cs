//-----------------------------------------------------------------------
// <copyright company="同程网" file="QueryCondition.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：查询操作关系
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.ComponentModel;

namespace JQEBookingTest.Model.Enum
{
    /// <summary>
    /// 查询操作关系
    /// </summary>
    public enum QueryCondition
    {
        /// <summary>
        /// 等于
        /// </summary>
        [Description("=")]
        Equal =0,

        /// <summary>
        /// 不等于
        /// </summary>
        [Description("!= ")]
        NotEqual =1,

        /// <summary>
        /// 大于
        /// </summary>
        [Description(">")]
        GreaterThan=2,

        /// <summary>
        /// 小于
        /// </summary>
        [Description("<")]
        LessThan=3,

        /// <summary>
        /// 大于等于
        /// </summary>
        [Description(">=")]
        GreaterThanAndEqual=4,

        /// <summary>
        /// 小于等于
        /// </summary>
        [Description("<=")]
        LessThanAndEqual=5,

        /// <summary>
        /// in 操作
        /// </summary>
       [Description(" in ")]
       InOpertion = 6,
    }
}
