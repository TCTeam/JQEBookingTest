//-------------------------------------------------------------
//  <copyright company="同程网" file="OrderStatus.cs">
//   Copyright(c)  V1.0
//   作者: asp.net全体组员
//   功能:订单状态枚举
//    
//  </copyright>
//-------------------------------------------------------------
using System;
using System.Text;

namespace JQEBookingTest.Model.Enum
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {

        /// <summary>
        /// NoShow
        /// </summary>
        NoShow = 0,

        /// <summary>
        /// 新订单
        /// </summary>
        新订单=1,

        /// <summary>
        /// 已核单
        /// </summary>
        已核单=2,

        /// <summary>
        /// 景区确认
        /// </summary>
        景区确认=3,
        
    }
}