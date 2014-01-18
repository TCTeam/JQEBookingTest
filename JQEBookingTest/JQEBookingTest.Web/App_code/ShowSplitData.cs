using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.DataAccess.Tables;

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
        public List<OrderTableModel> GetServerTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
            DataBaseType dbType = DataBaseType.Read;
            return new JQEBookingTest.DataAccess.Tables.OrderTableAccess().GetOrderTableList(dbType, showFields, whereFields, orderFields, pageSize, pageIndex);
        }
    }
}
