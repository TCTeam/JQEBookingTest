//-----------------------------------------------------------------------
// <copyright company="同程网" file="ShowSplitData.cs">
//    作者：asp.net全体组员
//    功能：分页处理封装
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;
using JQEBookingTest.Business.TableBusiness;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Model;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Injector;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Web
{
    public class ShowSplitData
    {
        /// <summary>
        /// 分页处理封装
        /// </summary>
        /// <param name="showFields">显示选项</param>
        /// <param name="whereFields">显示条件</param>
        /// <param name="orderFields">排序条件</param>
        /// <param name="pageSize">页面大小</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>结果集</returns>
        //public List<OrderTableModel> GetServerTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        //{
        //    DataBaseType dbType = DataBaseType.Read;
        //    return new JQEBookingTest.DataAccess.Tables.OrderTableAccess().GetOrderTableList(dbType, showFields, whereFields, orderFields, pageSize, pageIndex);
        //}
        public DataTable GetServerTableExtend(List<OrderTableFields> orderTableShowFields, List<TicketTypeFields> ticketTypeShowFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
            DataBaseType dbType = DataBaseType.Read;
            return JQEBookingTest.Injector.DependencyInjector.GetInstance<IOrderTableServices>().GetOrderTableExtend(dbType, orderTableShowFields, ticketTypeShowFields, whereFields, orderFields, pageSize, pageIndex);
        }
    }
}
