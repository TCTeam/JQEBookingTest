//-----------------------------------------------------------------------
// <copyright company="同程网" file="PageSplitQuery.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：页面查询
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using TCSmartFramework.DataAccess;

namespace JQEBookingTest.DataAccess
{
    /// <summary>
    /// 页面查询
    /// </summary>
    public class PageSplitQuery
    {
        /// <summary>
        /// 获取分页查询SQL语句[只支持SQLServer2005或SQLServer2008]
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="keyField">主键字段</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="joinOn">连接查询语句</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderFields">排序</param>
        /// <param name="pageSize">每页查询数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回分页查询SQL语句</returns>
        public static string GetPageSplitSql2005(string tableName,string keyField, string showFields,string joinOn, string where,string orderFields,int pageSize, int pageIndex)
        {
            int start = (pageIndex-1) * pageSize + 1;
            int end = start + pageSize - 1;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM (SELECT ROW_NUMBER() OVER (");
            if(string.IsNullOrEmpty(orderFields))
             {
                sql.Append(" order by ");
                sql.Append(tableName+"."+keyField);
             }
            else
             {
                sql.Append(orderFields);
             }
            sql.Append(") AS rowNumber,");
            sql.Append(showFields);
            sql.Append(" from ");
            sql.Append(tableName);
            sql.Append(" with(nolock) ");
            if ( !string.IsNullOrEmpty(joinOn) )
            {
                sql.Append(joinOn);
            }
            if ( !string.IsNullOrEmpty(where) )
            {
               sql.Append(" where ");
            }
            sql.Append(where);
            sql.Append(") AS sp WHERE rowNumber BETWEEN ");
            sql.Append(start.ToString());
            sql.Append(" AND ");
            sql.Append(end.ToString());
            return sql.ToString();
         }
        /// <summary>
        /// 获取分页查询SQL语句[只支持SQLServer2000]
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="keyField">主键字段</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="joinOn">连接查询语句</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderFields">排序</param>
        /// <param name="pageSize">每页查询数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回分页查询SQL语句</returns>
        public static string GetPageSplitSql2000(string tableName, string keyField, string showFields, string joinOn, string where, string orderFields, int pageSize, int pageIndex)
        {
            StringBuilder sql = new StringBuilder();
            if (pageIndex == 1)
           {
            sql.Append("select top ");
             sql.Append(pageSize);
            sql.Append(" ");
             sql.Append(showFields);
            sql.Append(" from ");
             sql.Append(tableName);
            sql.Append(" with(nolock) ");
             sql.Append(joinOn);
             if (!string.IsNullOrEmpty(where))
             {
              sql.Append(" where ");
             }
             sql.Append(where);
             sql.Append(orderFields);
           }
           else
           {
             int start = (pageIndex-1) * pageSize + 1;
             int end = start + pageSize - 1;
            sql.Append("declare @temp table(rowNumber int PRIMARY KEY IDENTITY(1,1) ,keyId int)");
            sql.Append("insert into @temp (keyId) ");
            sql.Append("select top ");
             sql.Append(end);
            sql.Append(" ");
            sql.Append(tableName + "." + keyField);
            sql.Append(" from ");
             sql.Append(tableName);
            sql.Append(" with(nolock) ");
             sql.Append(joinOn);
             if (!string.IsNullOrEmpty(where))
             {
               sql.Append(" where ");
             }
             sql.Append(where);
            if (string.IsNullOrEmpty(orderFields))
            {
             sql.Append(" order by ");
             sql.Append(tableName + "." + keyField);
             }
            else
            {
              sql.Append(orderFields);
            }
            sql.AppendLine(" select * from @temp as t inner join (");
            sql.Append(" select top ");
             sql.Append(end);
            sql.Append(" ");
             sql.Append(showFields);
            sql.Append(" from ");
             sql.Append(tableName);
            sql.Append(" with(nolock) ");
             sql.Append(joinOn);
            if (!string.IsNullOrEmpty(where))
            {
              sql.Append(" where ");
            }
            sql.Append(where);
           if (string.IsNullOrEmpty(orderFields))
            {
              sql.Append(" order by ");
              sql.Append(tableName+"."+keyField);
            }
           else
           {
               sql.Append(orderFields);
            }
           sql.Append(") as z on t.keyId=z." + keyField);
           sql.Append(" where t.rowNumber BETWEEN  ");
            sql.Append(start.ToString());
           sql.Append(" AND ");
            sql.Append(end.ToString());
            }
           return sql.ToString();
        }
    }
}
