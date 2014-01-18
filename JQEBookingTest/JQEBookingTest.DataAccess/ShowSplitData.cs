using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.DataAccess.Tables;

namespace JQEBookingTest.DataAccess
{
    public class ShowSplitData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="showFields"></param>
        /// <param name="whereFields"></param>
        /// <param name="orderFields"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<OrderTableModel> GetServerTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
            DataBaseType dbType = DataBaseType.Read;
            return new JQEBookingTest.DataAccess.Tables.OrderTableAccess().GetOrderTableList(dbType, showFields, whereFields, orderFields, pageSize, pageIndex);
        }
    }
}
