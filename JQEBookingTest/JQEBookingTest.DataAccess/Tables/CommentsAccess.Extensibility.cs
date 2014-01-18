//-----------------------------------------------------------------------
// <copyright company="同程网" file="CommentsAccess.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：asp.net全体组员
//    功能：Comments表的数据操作自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using TCSmartFramework.DataAccess;

namespace JQEBookingTest.DataAccess.Tables
{
    /// <summary>
    /// Comments表的数据操作自定义扩展开发
    /// </summary>
    public partial class CommentsAccess
    {
        /// <summary>
        /// 获取所有评论列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCommentsExtend(List<CommentsWhereFields> whereFields, int scenicId, int pageSize, int pageIndex)
        {
            scenicId = 3320;
            int start = (pageIndex - 1) * pageSize + 1;
            int end = start + pageSize - 1;
            StringBuilder sqlsb = new StringBuilder();
            sqlsb.AppendFormat(@"SELECT * FROM 
                (SELECT ROW_NUMBER() OVER 
                ( order by [{0}].[dbo].[OrderTable].OTId) 
                AS rowNumber
                ,Comments.COrderSerialNo
                ,Comments.CCommentsType
                ,Comments.CCommentsContent
                ,Comments.CCommentsTime
                ,Comments.CCommentsReply
                ,Comments.CCommentsState
                ,OrderTable.OTOrderName from ", DatabaseManager.Db_JQEBookingDataBase);
            sqlsb.AppendFormat("[{0}].[dbo].[Comments]", DatabaseManager.Db_JQEBookingDataBase);
            sqlsb.Append(" with(nolock) left join ");
            sqlsb.AppendFormat("[{0}].[dbo].[OrderTable]", DatabaseManager.Db_JQEBookingDataBase);
            sqlsb.Append(" on Comments.COrderSerialNo=OrderTable.OTOrderSerialNo");
            sqlsb.AppendFormat(" where OrderTable.OTScenicId={0} ", scenicId);
            sqlsb.Append(GetSqlString(null, whereFields));
            sqlsb.Append(") AS sp WHERE rowNumber BETWEEN ");
            sqlsb.Append(start.ToString());
            sqlsb.Append(" AND ");
            sqlsb.Append(end.ToString());
            sqlsb.Append(" --Flat:Asp.net小组/Author:谢超/For:获取订单统计列表/File :CommentsAccess.Extensibility.cs/Fun:GetCommentsExtend");
            DataTable datatable = SqlHelper.ExecuteDataTable(sqlsb.ToString());
            return datatable;
        }
        /// <summary>
        /// 获取某个景区的评论数
        /// </summary>
        /// <param name="scenicId"></param>
        /// <returns></returns>
        public int GetCommentsCount(List<CommentsWhereFields> whereFields, int scenicId)
        {
            StringBuilder sqlsb = new StringBuilder();
            sqlsb.Append("select count(Comments.COrderSerialNo) from ");
            sqlsb.AppendFormat("[{0}].[dbo].[Comments]", DatabaseManager.Db_JQEBookingDataBase);
            sqlsb.Append(" with(nolock) left join");
            sqlsb.AppendFormat("[{0}].[dbo].[OrderTable]", DatabaseManager.Db_JQEBookingDataBase);
            sqlsb.Append(" on Comments.COrderSerialNo=OrderTable.OTOrderSerialNo");
            sqlsb.AppendFormat(" where OrderTable.OTScenicId={0} ", scenicId);
            sqlsb.Append(GetSqlString(null, whereFields));
            sqlsb.Append(" --Flat:Asp.net小组/Author:谢超/For:获取订单统计列表/File :CommentsAccess.Extensibility.cs/Fun:GetCommentsExtend");
            return SqlHelper.ExecuteScalarByInt(sqlsb.ToString());
        }
    }
}
