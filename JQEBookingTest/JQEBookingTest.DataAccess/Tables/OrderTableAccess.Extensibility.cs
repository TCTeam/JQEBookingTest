//-----------------------------------------------------------------------
// <copyright company="同程网" file="OrderTableAccess.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表的数据操作自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.DataAccess.Tables
{
    /// <summary>
    /// OrderTable表的数据操作自定义扩展开发
    /// </summary>
    public partial class OrderTableAccess
    {
        public DataTable GetOrderTableExtend(DataBaseType dbType, List<OrderTableFields> orderTableShowFields, List<TicketTypeFields> ticketTypeShowFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
            StringBuilder sql = new StringBuilder();
            string orderTableShowFieldsSql = GetOrderShowFields("OrderTable", orderTableShowFields);
            string ticketTypeShowFieldsSql = GetTicketShowFields("TicketType", ticketTypeShowFields);
            int start = (pageIndex - 1) * pageSize + 1;
            int end = start + pageSize - 1;
            sql.Append("SELECT * FROM (SELECT ROW_NUMBER() OVER (");
            if (string.IsNullOrEmpty(GetOrderFields(orderFields)))
            {
                sql.Append(" order by ");
                sql.AppendFormat("[{0}].[dbo].[OrderTable].OTId", DatabaseManager.Db_JQEBookingDataBase);
            }
            else
            {
                sql.Append(GetOrderFields(orderFields));
            }
            sql.Append(") AS rowNumber,");
            sql.Append(orderTableShowFieldsSql);
            sql.Append(",");
            sql.Append(ticketTypeShowFieldsSql);
            sql.Append(" from ");
            sql.AppendFormat("[{0}].[dbo].[OrderTable]", DatabaseManager.Db_JQEBookingDataBase);
            sql.Append(" with(nolock) ");
            sql.Append("left join ");
            sql.AppendFormat("[{0}].[dbo].[TicketType]", DatabaseManager.Db_JQEBookingDataBase);
            sql.Append(" on ");
            sql.AppendFormat("[{0}].[dbo].[OrderTable].OTTicketTypeId=[{0}].[dbo].[TicketType].TTTypeId", DatabaseManager.Db_JQEBookingDataBase);
            sql.Append(" where ");
            sql.Append(GetSqlString(null, whereFields));
            sql.Append(") AS sp WHERE rowNumber BETWEEN ");
            sql.Append(start.ToString());
            sql.Append(" AND ");
            sql.Append(end.ToString());

            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if (whereFields != null && whereFields.Count > 0)
            {
                GetSqlParameterWrapperCollection(collection, null, whereFields);
            }

            DataTable datatable = SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig, dbType), sql.ToString(), collection);
            return datatable;
        }

        public string GetOrderShowFields(string tableName, List<OrderTableFields> showFieldsList)
        {
            if (showFieldsList == null || showFieldsList.Count == 0)
            {
                return " * ";
            }
            tableName += ".";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < showFieldsList.Count; i++)
            {
                sb.Append(tableName + showFieldsList[i].ToString());
                if (i != showFieldsList.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        public string GetTicketShowFields(string tableName, List<TicketTypeFields> showFieldsList)
        {
            if (showFieldsList == null || showFieldsList.Count == 0)
            {
                return " * ";
            }
            tableName += ".";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < showFieldsList.Count; i++)
            {
                sb.Append(tableName + showFieldsList[i].ToString());
                if (i != showFieldsList.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
    }
}
