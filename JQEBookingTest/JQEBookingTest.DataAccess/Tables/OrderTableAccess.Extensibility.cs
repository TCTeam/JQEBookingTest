//-----------------------------------------------------------------------
// <copyright company="同程网" file="OrderTableAccess.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：Asp.net组 谢超
//    功能：OrderTable表与TicketType表连表查询
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;

namespace JQEBookingTest.DataAccess.Tables
{
    /// <summary>
    /// OrderTable表的数据操作自定义扩展开发
    /// </summary>
    public partial class OrderTableAccess
    {
        /// <summary>
        /// 获取订单表
        /// </summary>
        /// <param name="dbType"></param>
        /// <param name="orderTableShowFields"></param>
        /// <param name="ticketTypeShowFields"></param>
        /// <param name="whereFields"></param>
        /// <param name="orderFields"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="mainTableName"></param>
        /// <param name="joinTableName"></param>
        /// <param name="joinCondition"></param>
        /// <returns></returns>
        public DataTable GetOrderTableExtend(DataBaseType dbType, List<OrderTableFields> orderTableShowFields, List<TicketTypeFields> ticketTypeShowFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex,string mainTableName,string joinTableName,string joinCondition)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:谢超/For:OrderTable表分页查询操作、订单表和票型表连表查询/File:OrderTableAccess.Extensibility.cs/Fun:GetOrderTableListExtend*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            string orderTableShowFieldsSql = GetOrderShowFields(mainTableName, orderTableShowFields);
            string ticketTypeShowFieldsSql = GetTicketShowFields(joinTableName, ticketTypeShowFields);
            int start = (pageIndex - 1) * pageSize + 1;
            int end = start + pageSize - 1;
            sql.Append("SELECT * FROM (SELECT ROW_NUMBER() OVER (");
            if (string.IsNullOrEmpty(GetOrderFields(orderFields)))
            {
                sql.Append(" order by ");
                sql.Append(mainTableName + "." + "OTId");
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
            sql.Append(mainTableName);
            sql.Append(" with(nolock) ");
            sql.Append("left join ");
            sql.Append("TicketType");
            sql.Append(" on ");
            sql.Append(joinCondition);
            sql.Append(" where ");
            sql.Append(GetSqlString(null,whereFields));
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
                sb.Append(tableName+showFieldsList[i].ToString());
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
