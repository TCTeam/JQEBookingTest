//-----------------------------------------------------------------------
// <copyright company="同程网" file="IOrderTableServices.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表数据库业务层自定义扩展开发自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.IBusiness.TableBusiness
{
    /// <summary>
    /// OrderTable表数据库业务层自定义扩展开发自定义扩展开发
    /// </summary>
    public partial interface IOrderTableServices
    {
        DataTable GetOrderTableExtend(DataBaseType dbType, List<OrderTableFields> orderTableShowFields, List<TicketTypeFields> ticketTypeShowFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex, string mainTableName, string joinTableName, string joinCondition);
    }
}
