//-----------------------------------------------------------------------
// <copyright company="同程网" file="CommentsAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表添删改查操作
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Model.Enum;
using TCSmartFramework.DataAccess;
using TCSmartFramework.Utility;

namespace JQEBookingTest.DataAccess.Tables
{
    /// <summary>
    /// Comments表添删改查操作
    /// </summary>
    public partial class CommentsAccess
    {
        /// <summary>
        /// Comments 添加操作
        /// </summary>
        /// <param name="comments">Comments实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(CommentsModel comments)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表增加操作/File:CommentsAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] (COrderSerialNo,CCommentsType,CCommentsContent,CCommentsTime,CCommentsReply,CReplyTime,CCommentsState,CRowValid) values(@COrderSerialNo,@CCommentsType,@CCommentsContent,@CCommentsTime,@CCommentsReply,@CReplyTime,@CCommentsState,@CRowValid)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@COrderSerialNo", comments.COrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CCommentsType", comments.CCommentsType,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@CCommentsContent", comments.CCommentsContent,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CCommentsTime", comments.CCommentsTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@CCommentsReply", comments.CCommentsReply,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CReplyTime", comments.CReplyTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@CCommentsState", comments.CCommentsState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@CRowValid", comments.CRowValid,SqlDbType.TinyInt));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// Comments 添加操作
        /// </summary>
        /// <param name="comments">Comments实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(CommentsModel comments,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表增加操作/File:CommentsAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] (COrderSerialNo,CCommentsType,CCommentsContent,CCommentsTime,CCommentsReply,CReplyTime,CCommentsState,CRowValid) values(@COrderSerialNo,@CCommentsType,@CCommentsContent,@CCommentsTime,@CCommentsReply,@CReplyTime,@CCommentsState,@CRowValid)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@COrderSerialNo", comments.COrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CCommentsType", comments.CCommentsType,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@CCommentsContent", comments.CCommentsContent,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CCommentsTime", comments.CCommentsTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@CCommentsReply", comments.CCommentsReply,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@CReplyTime", comments.CReplyTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@CCommentsState", comments.CCommentsState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@CRowValid", comments.CRowValid,SqlDbType.TinyInt));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<CommentsFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表增加操作/File:CommentsAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append(GetInsertSql(list));
           SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
           GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<CommentsFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表增加操作/File:CommentsAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append(GetInsertSql(list));
           SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
           GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection,transaction) > 0;
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Comments实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<CommentsModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(CommentsModel comments in  list)
                  {
                       Add(comments,trans.DbTransaction); 
                  }
                  trans.Complete();
               }
                 return true;
             }
             catch
             {
                 return false;
             }
        }


        /// <summary>
        /// Comments 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表删除操作/File:CommentsAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// Comments 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表删除操作/File:CommentsAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }


        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<CommentsWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表删除操作/File:CommentsAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] where ");
            sql.Append(GetSqlString(null, where));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, null, where);
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig), sql.ToString(), collection) > 0;
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<CommentsWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表删除操作/File:CommentsAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] where ");
            sql.Append(GetSqlString(null, where));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, null, where);
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig), sql.ToString(), collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(CommentsWhereFields where)
        {
           List<CommentsWhereFields> wheres = new List<CommentsWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(CommentsWhereFields where,DbTransaction transaction)
        {
           List<CommentsWhereFields> wheres = new List<CommentsWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }


        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<CommentsFieldValuePair> update, List<CommentsWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表更新操作/File:CommentsAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] set ");
            sql.Append(GetSqlString(update, null));
            if(where !=null && where.Count > 0)
            {
                 sql.Append(" where ");
                 sql.Append(GetSqlString(null, where));
            }
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, update, where);
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig), sql.ToString(), collection) > 0;
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<CommentsFieldValuePair> update, List<CommentsWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表更新操作/File:CommentsAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] set ");
            sql.Append(GetSqlString(update, null));
            if(where !=null && where.Count > 0)
            {
                 sql.Append(" where ");
                 sql.Append(GetSqlString(null, where));
            }
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, update, where);
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig), sql.ToString(), collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<CommentsFieldValuePair> update,CommentsWhereFields where)
        {
            List<CommentsWhereFields> wheres = new List<CommentsWhereFields>();
            wheres.Add(where);
            return Update(update, wheres);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<CommentsFieldValuePair> update, CommentsWhereFields where,DbTransaction transaction)
        {
            List<CommentsWhereFields> wheres = new List<CommentsWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(CommentsFieldValuePair update, CommentsWhereFields where)
        {
            List<CommentsFieldValuePair> updates=new List<CommentsFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<CommentsWhereFields> wheres = new List<CommentsWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(CommentsFieldValuePair update,CommentsWhereFields where,DbTransaction transaction)
        {
            List<CommentsFieldValuePair> updates=new List<CommentsFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<CommentsWhereFields> wheres = new List<CommentsWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select CId,COrderSerialNo,CCommentsType,CCommentsContent,CCommentsTime,CCommentsReply,CReplyTime,CCommentsState,CRowValid from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable()
        {
            return GetCommentsTable(DataBaseType.Read);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select CId,COrderSerialNo,CCommentsType,CCommentsContent,CCommentsTime,CCommentsReply,CReplyTime,CCommentsState,CRowValid from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList()
        {
            return GetCommentsList(DataBaseType.Read);
        }


        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields where)
        {
              List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
              whereFields.Add(where);
              return GetCommentsTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(CommentsWhereFields where)
        {
            return  GetCommentsTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields where)
        {
              List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
              whereFields.Add(where);
              return GetCommentsList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(CommentsWhereFields where)
        {
            return GetCommentsList(DataBaseType.Read,where);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetCommentsTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
             return GetCommentsTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetCommentsList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public static List<CommentsModel> GetCommentsListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public static List<CommentsModel> GetCommentsListBySql(string sql, List<CommentsWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sqlStr.Append(" where ");
                sqlStr.Append(GetSqlString(null, whereFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString(), collection);
            return  GetList(null,reader);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            return GetCommentsList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            if ( orderFields != null && orderFields.Count > 0 )
            {
                sql.Append(GetOrderFields(orderFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),collection);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
             return GetCommentsTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetCommentsList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            if ( orderFields != null && orderFields.Count > 0 )
            {
                sql.Append(GetOrderFields(orderFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(), collection);
            return  GetList(showFields,reader);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
               return GetCommentsList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
               return GetCommentsTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
              return GetCommentsTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsWhereFields> whereFields)
        {
               return GetCommentsList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsWhereFields> whereFields)
        {
             return GetCommentsList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,List<CommentsWhereFields> whereFields)
        {
               return GetCommentsTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(List<CommentsWhereFields> whereFields)
        {
               return GetCommentsTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType, List<CommentsOrderFields> orderFields)
        {
               return GetCommentsTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(List<CommentsOrderFields> orderFields)
        {
             return GetCommentsTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType, List<CommentsOrderFields> orderFields)
        {
               return GetCommentsList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsOrderFields> orderFields)
        {
              return GetCommentsList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
               return GetCommentsList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
              return  GetCommentsList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public int GetCount(DataBaseType dbType, List<CommentsWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetTopCommentsTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            return SqlHelper.ExecuteScalarByInt(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),collection);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public int GetCount(List<CommentsWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public object GetObject(DataBaseType dbType, CommentsFields showField, List<CommentsWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetTopCommentsTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            return SqlHelper.ExecuteScalar(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),collection);
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public object GetObject(CommentsFields showField, List<CommentsWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetTopCommentsTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            if ( orderFields != null && orderFields.Count > 0 )
            {
                sql.Append(GetOrderFields(orderFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),collection);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
             return GetTopCommentsTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Comments表查询操作/File:CommentsAccess.cs/Fun:GetTopCommentsList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Comments] with(nolock)");
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                sql.Append(" where ");
                sql.Append(GetSqlString(null, whereFields));
            }

            if ( orderFields != null && orderFields.Count > 0 )
            {
                sql.Append(GetOrderFields(orderFields));
            }

            GetSqlParameterWrapperCollection(collection, null, whereFields);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(), collection);
            return  GetList(showFields,reader);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
             return GetTopCommentsList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<CommentsFieldValuePair> fieldsList)
        {
            StringBuilder fields = new StringBuilder();
            StringBuilder values = new StringBuilder();
            for (int i = 0; i < fieldsList.Count; i++)
            {
                fields.Append(fieldsList[i].Field.ToString());
                values.Append("@"+ fieldsList[i].Field.ToString());
                if (i != fieldsList.Count - 1)
                {
                    fields.Append(", ");
                    values.Append(", ");
                }
            }

            return "insert [JQEBooking].[dbo].[Comments] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<CommentsFields> showFieldsList)
        {
            if ( showFieldsList == null || showFieldsList.Count == 0 )
            {
                return " * ";
            }

            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < showFieldsList.Count; i++ )
            {
                sb.Append(showFieldsList[i].ToString());
                if ( i != showFieldsList.Count - 1 )
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取排序字段
        /// </summary>
        /// <param name="orderList">排序字段列表</param>
        /// <returns>返回排序字段</returns>
        public string GetOrderFields(List<CommentsOrderFields> orderList)
        {
            if ( orderList == null || orderList.Count == 0 )
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(" order by");
            for ( int i = 0; i < orderList.Count; i++ )
            {
                sb.Append(" ");
                sb.Append(orderList[i].Field.ToString());
                sb.Append(" ");
                sb.Append(orderList[i].Order.ToString());

                if ( i != orderList.Count - 1 )
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取SQL字符串
        /// </summary>
        /// <param name="updates">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>返回SQL字符串</returns>
        public static string GetSqlString(List<CommentsFieldValuePair> updates, List<CommentsWhereFields> where)
        {
            StringBuilder sb = new StringBuilder();
            if ( updates != null && updates.Count > 0 )
            {
                for ( int i = 0; i < updates.Count; i++ )
                {
                    sb.Append(updates[i].Field.ToString());
                    sb.Append("=@");
                    sb.Append(updates[i].Field.ToString());

                     if ( i != updates.Count - 1 )
                     {
                        sb.Append(",");
                     }
                }
             }

            if ( where != null && where.Count > 0 )
            {

                for ( int i = 0; i < where.Count; i++ )
                {
                    sb.Append(where[i].Field.ToString());
                    sb.Append(Utils.GetEnumDescription(where[i].Condition));
                    if (where[i].Condition != QueryCondition.InOpertion)
                    {
                      sb.Append("@");
                    }

                    string suffix = string.Empty;

                     if ( updates != null && IsExistField(updates, where[i].Field) )
                     {
                          suffix = "1";
                     }

                     suffix = IsWhereField(where, i);
                     if (where[i].Condition == QueryCondition.InOpertion)
                     {
                        sb.Append("("+ where[i].FieldValue.ToString() +")");
                     }
                     else
                     {
                         sb.Append(where[i].Field.ToString() + suffix);
                     }

                     if ( i != where.Count - 1 )
                     {
                          sb.Append(" " +where[i].Operator.ToString() + " ");
                     }
                 }
             }
            return sb.ToString();
        }

        /// <summary>
        /// 设置SqlParameterWrapperCollection
        /// </summary>
        /// <param name="collection">SqlParameterWrapperCollection</param>
        /// <param name="field">字段</param>
        /// <param name="fieldVariable">字段变量</param>
        /// <param name="fieldValue">值</param>
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, CommentsFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case CommentsFields.CId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case CommentsFields.COrderSerialNo:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case CommentsFields.CCommentsType:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case CommentsFields.CCommentsContent:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case CommentsFields.CCommentsTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case CommentsFields.CCommentsReply:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case CommentsFields.CReplyTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case CommentsFields.CCommentsState:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case CommentsFields.CRowValid:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

            }
        }

        /// <summary>
        /// 获取SqlParameterWrapperCollection
        /// </summary>
        /// <param name="collection">SqlParameterWrapperCollection</param>
        /// <param name="updates">更新列表</param>
        /// <param name="where">条件列表</param>
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<CommentsFieldValuePair> updates, List<CommentsWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( CommentsFieldValuePair values in updates )
                {
                    SetSqlParameterWrapperCollection(collection, values.Field, values.Field.ToString(), values.FieldValue);
                }
            }

            if ( where != null && where.Count > 0 )
            {
                for( int i=0; i< where.Count; i++)
                {
                     if (where[i].Condition == QueryCondition.InOpertion)
                      { 
                          continue;
                      }
                    string suffix = string.Empty;
                    if ( updates != null && IsExistField(updates, where[i].Field) )
                    {
                        suffix = "1";
                    }
                    suffix = IsWhereField(where, i);
                    SetSqlParameterWrapperCollection(collection, where[i].Field, where[i].Field.ToString() + suffix, where[i].FieldValue);
                }
            }
        }

       /// <summary>
       /// 判断条件中是否有重复的
       /// </summary>
       /// <param name="where">条件列表</param>
       /// <param name="index">索引</param>
       /// <returns>返回后缀</returns>
      public static string IsWhereField(List<CommentsWhereFields> where, int index)
      {
           if ( where.Count > 1 )
           {
             string fieldName = where[index].Field.ToString();
             int searchIndex = 0;
             for ( int i = 0; i < where.Count; i++ )
             {
                 if ( fieldName.Equals(where[i].Field.ToString()) )
                 {
                   searchIndex = searchIndex + 1;
                 }
                 if ( fieldName.Equals(where[i].Field.ToString()) && ( i == index ) )
                 {
                    return searchIndex.ToString();
                 }
              }
           }
           return string.Empty;
      }

        /// <summary>
        /// 判断字段是否存在
        /// </summary>
        /// <param name="list">列表</param>
        /// <param name="field">字段</param>
        /// <returns>返回true存在,否则不存在</returns>
        public static  bool IsExistField(List<CommentsFieldValuePair> list, CommentsFields field)
        {
            foreach ( CommentsFieldValuePair f in list )
            {
                if ( f.Field == field )
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断字段是否存在
        /// </summary>
        /// <param name="list">列表</param>
        /// <param name="field">字段</param>
        /// <returns>返回true存在,否则不存在</returns>
        public static bool IsExistField(List<CommentsFields> list, CommentsFields field)
        {
            foreach ( CommentsFields f in list )
            {
                if ( f == field )
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///  获取实体列表
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="reader">IDataReader</param>
        /// <returns>返回Comments实体列表</returns>
        public static  List<CommentsModel> GetList(List<CommentsFields> showFields, IDataReader reader)
        {
            List< CommentsModel> list = new List< CommentsModel>();
            while ( reader.Read() )
            {
                 CommentsModel comments= new CommentsModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CId)) && reader["CId"] !=DBNull.Value)
                {
                   comments.CId = Convert.ToInt32(reader["CId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.COrderSerialNo)) && reader["COrderSerialNo"] !=DBNull.Value)
                {
                   comments.COrderSerialNo = reader["COrderSerialNo"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CCommentsType)) && reader["CCommentsType"] !=DBNull.Value)
                {
                   comments.CCommentsType = Convert.ToByte(reader["CCommentsType"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CCommentsContent)) && reader["CCommentsContent"] !=DBNull.Value)
                {
                   comments.CCommentsContent = reader["CCommentsContent"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CCommentsTime)) && reader["CCommentsTime"] !=DBNull.Value)
                {
                   comments.CCommentsTime = Convert.ToDateTime(reader["CCommentsTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CCommentsReply)) && reader["CCommentsReply"] !=DBNull.Value)
                {
                   comments.CCommentsReply = reader["CCommentsReply"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CReplyTime)) && reader["CReplyTime"] !=DBNull.Value)
                {
                   comments.CReplyTime = Convert.ToDateTime(reader["CReplyTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CCommentsState)) && reader["CCommentsState"] !=DBNull.Value)
                {
                   comments.CCommentsState = Convert.ToByte(reader["CCommentsState"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, CommentsFields.CRowValid)) && reader["CRowValid"] !=DBNull.Value)
                {
                   comments.CRowValid = Convert.ToByte(reader["CRowValid"]);
                }

                  list.Add(comments);
            }
            reader.Close();
            return list;
        }
    }
}
