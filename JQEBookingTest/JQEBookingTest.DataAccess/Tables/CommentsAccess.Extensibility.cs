//-----------------------------------------------------------------------
// <copyright company="同程网" file="CommentsAccess.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：谢超
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
        public DataTable GetCommentsExtend()
        {
            String sql = @"/****** Script for SelectTopNRows command from SSMS  ******/
                SELECT TOP 1000
                Comments.COrderSerialNo
                ,Comments.CCommentsType
                ,Comments.CCommentsContent
                ,Comments.CCommentsTime
                ,Comments.CCommentsReply
                ,Comments.CCommentsState
                ,OrderTable.OTOrderName
                FROM [JQEBooking].[dbo].[Comments] left join [JQEBooking].[dbo].[OrderTable] on Comments.COrderSerialNo=OrderTable.OTOrderSerialNo;";
            DataTable datatable = SqlHelper.ExecuteDataTable(sql);
            return datatable;
        }
    }
}
