//-----------------------------------------------------------------------
// <copyright company="同程网" file="OrderTableServices.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表数据库业务层自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Business.TableBusiness
{
    /// <summary>
    /// OrderTable表数据库业务层自定义扩展开发
    /// </summary>
    public partial class OrderTableServices
    {
        public DataTable GetOrderTableExtend(DataBaseType dbType, List<OrderTableFields> orderTableShowFields, List<TicketTypeFields> ticketTypeShowFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
            return dataAccess.GetOrderTableExtend(dbType, orderTableShowFields, ticketTypeShowFields, whereFields, orderFields, pageSize, pageIndex);
        }
    }
}
