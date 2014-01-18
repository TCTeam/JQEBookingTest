//-------------------------------------------------------------
//  <copyright company="同程网" file="PayWay.cs">
//   Copyright(c)  V1.0
//   作者:asp.net全体组员
//   功能:支付方式枚举
//    
//  </copyright>
//-------------------------------------------------------------
using System;
using System.Text;

namespace JQEBookingTest.Model.Enum
{
    /// <summary>
    /// 支付方式
    /// </summary>
    public enum PayWay
    {
        /// <summary>
        /// 景区到付
        /// </summary>
        景区到付=0,
        /// <summary>
        /// 在线支付
        /// </summary>
        在线支付=1,
    }
}