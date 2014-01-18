//-----------------------------------------------------------------------
// <copyright company="同程网" file="RemarkAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Remark表添删改查操作
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
    /// Remark表添删改查操作
    /// </summary>
    public partial class RemarkAccess
    {
        /// <summary>
        /// Remark 添加操作
        /// </summary>
        /// <param name="remark">Remark实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(RemarkModel remark)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表增加操作/File:RemarkAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] (ROrderSerialNo,RRemarkType,RRemarkContent,RRemarkTime,RRemarkReply,RReplyTime,RRemarkState,RRowValid) values(@ROrderSerialNo,@RRemarkType,@RRemarkContent,@RRemarkTime,@RRemarkReply,@RReplyTime,@RRemarkState,@RRowValid)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@ROrderSerialNo", remark.ROrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RRemarkType", remark.RRemarkType,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@RRemarkContent", remark.RRemarkContent,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RRemarkTime", remark.RRemarkTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@RRemarkReply", remark.RRemarkReply,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RReplyTime", remark.RReplyTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@RRemarkState", remark.RRemarkState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@RRowValid", remark.RRowValid,SqlDbType.TinyInt));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// Remark 添加操作
        /// </summary>
        /// <param name="remark">Remark实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(RemarkModel remark,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表增加操作/File:RemarkAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] (ROrderSerialNo,RRemarkType,RRemarkContent,RRemarkTime,RRemarkReply,RReplyTime,RRemarkState,RRowValid) values(@ROrderSerialNo,@RRemarkType,@RRemarkContent,@RRemarkTime,@RRemarkReply,@RReplyTime,@RRemarkState,@RRowValid)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@ROrderSerialNo", remark.ROrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RRemarkType", remark.RRemarkType,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@RRemarkContent", remark.RRemarkContent,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RRemarkTime", remark.RRemarkTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@RRemarkReply", remark.RRemarkReply,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@RReplyTime", remark.RReplyTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@RRemarkState", remark.RRemarkState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@RRowValid", remark.RRowValid,SqlDbType.TinyInt));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<RemarkFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表增加操作/File:RemarkAccess.cs/Fun:Add*/";
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
        public bool Add(List<RemarkFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表增加操作/File:RemarkAccess.cs/Fun:Add*/";
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
        /// <param name="list">Remark实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<RemarkModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(RemarkModel remark in  list)
                  {
                       Add(remark,trans.DbTransaction); 
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
        /// Remark 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表删除操作/File:RemarkAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// Remark 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表删除操作/File:RemarkAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }


        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<RemarkWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表删除操作/File:RemarkAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] where ");
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
        public bool Delete(List<RemarkWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表删除操作/File:RemarkAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] where ");
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
        public bool Delete(RemarkWhereFields where)
        {
           List<RemarkWhereFields> wheres = new List<RemarkWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(RemarkWhereFields where,DbTransaction transaction)
        {
           List<RemarkWhereFields> wheres = new List<RemarkWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }


        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<RemarkFieldValuePair> update, List<RemarkWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表更新操作/File:RemarkAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] set ");
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
        public bool Update(List<RemarkFieldValuePair> update, List<RemarkWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表更新操作/File:RemarkAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] set ");
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
        public bool Update(List<RemarkFieldValuePair> update,RemarkWhereFields where)
        {
            List<RemarkWhereFields> wheres = new List<RemarkWhereFields>();
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
        public bool Update(List<RemarkFieldValuePair> update, RemarkWhereFields where,DbTransaction transaction)
        {
            List<RemarkWhereFields> wheres = new List<RemarkWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(RemarkFieldValuePair update, RemarkWhereFields where)
        {
            List<RemarkFieldValuePair> updates=new List<RemarkFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<RemarkWhereFields> wheres = new List<RemarkWhereFields>();
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
        public bool Update(RemarkFieldValuePair update,RemarkWhereFields where,DbTransaction transaction)
        {
            List<RemarkFieldValuePair> updates=new List<RemarkFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<RemarkWhereFields> wheres = new List<RemarkWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select RId,ROrderSerialNo,RRemarkType,RRemarkContent,RRemarkTime,RRemarkReply,RReplyTime,RRemarkState,RRowValid from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable()
        {
            return GetRemarkTable(DataBaseType.Read);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select RId,ROrderSerialNo,RRemarkType,RRemarkContent,RRemarkTime,RRemarkReply,RReplyTime,RRemarkState,RRowValid from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList()
        {
            return GetRemarkList(DataBaseType.Read);
        }


        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields where)
        {
              List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
              whereFields.Add(where);
              return GetRemarkTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(RemarkWhereFields where)
        {
            return  GetRemarkTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields where)
        {
              List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
              whereFields.Add(where);
              return GetRemarkList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(RemarkWhereFields where)
        {
            return GetRemarkList(DataBaseType.Read,where);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetRemarkTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
             return GetRemarkTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetRemarkList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public static List<RemarkModel> GetRemarkListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public static List<RemarkModel> GetRemarkListBySql(string sql, List<RemarkWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkList*/";
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
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            return GetRemarkList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
             return GetRemarkTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetRemarkList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
               return GetRemarkList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
               return GetRemarkTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
              return GetRemarkTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkWhereFields> whereFields)
        {
               return GetRemarkList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkWhereFields> whereFields)
        {
             return GetRemarkList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,List<RemarkWhereFields> whereFields)
        {
               return GetRemarkTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(List<RemarkWhereFields> whereFields)
        {
               return GetRemarkTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType, List<RemarkOrderFields> orderFields)
        {
               return GetRemarkTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(List<RemarkOrderFields> orderFields)
        {
             return GetRemarkTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType, List<RemarkOrderFields> orderFields)
        {
               return GetRemarkList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkOrderFields> orderFields)
        {
              return GetRemarkList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
               return GetRemarkList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
              return  GetRemarkList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public int GetCount(DataBaseType dbType, List<RemarkWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetTopRemarkTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
       /// <returns>返回Remark表格</returns>
        public int GetCount(List<RemarkWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public object GetObject(DataBaseType dbType, RemarkFields showField, List<RemarkWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetTopRemarkTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
       /// <returns>返回Remark表格</returns>
        public object GetObject(RemarkFields showField, List<RemarkWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetTopRemarkTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
             return GetTopRemarkTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Remark表查询操作/File:RemarkAccess.cs/Fun:GetTopRemarkList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Remark] with(nolock)");
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
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
             return GetTopRemarkList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<RemarkFieldValuePair> fieldsList)
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

            return "insert [JQEBooking].[dbo].[Remark] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<RemarkFields> showFieldsList)
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
        public string GetOrderFields(List<RemarkOrderFields> orderList)
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
        public static string GetSqlString(List<RemarkFieldValuePair> updates, List<RemarkWhereFields> where)
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
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, RemarkFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case RemarkFields.RId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case RemarkFields.ROrderSerialNo:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case RemarkFields.RRemarkType:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case RemarkFields.RRemarkContent:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case RemarkFields.RRemarkTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case RemarkFields.RRemarkReply:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case RemarkFields.RReplyTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case RemarkFields.RRemarkState:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case RemarkFields.RRowValid:
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
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<RemarkFieldValuePair> updates, List<RemarkWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( RemarkFieldValuePair values in updates )
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
      public static string IsWhereField(List<RemarkWhereFields> where, int index)
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
        public static  bool IsExistField(List<RemarkFieldValuePair> list, RemarkFields field)
        {
            foreach ( RemarkFieldValuePair f in list )
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
        public static bool IsExistField(List<RemarkFields> list, RemarkFields field)
        {
            foreach ( RemarkFields f in list )
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
        /// <returns>返回Remark实体列表</returns>
        public static  List<RemarkModel> GetList(List<RemarkFields> showFields, IDataReader reader)
        {
            List< RemarkModel> list = new List< RemarkModel>();
            while ( reader.Read() )
            {
                 RemarkModel remark= new RemarkModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RId)) && reader["RId"] !=DBNull.Value)
                {
                   remark.RId = Convert.ToInt32(reader["RId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.ROrderSerialNo)) && reader["ROrderSerialNo"] !=DBNull.Value)
                {
                   remark.ROrderSerialNo = reader["ROrderSerialNo"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRemarkType)) && reader["RRemarkType"] !=DBNull.Value)
                {
                   remark.RRemarkType = Convert.ToByte(reader["RRemarkType"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRemarkContent)) && reader["RRemarkContent"] !=DBNull.Value)
                {
                   remark.RRemarkContent = reader["RRemarkContent"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRemarkTime)) && reader["RRemarkTime"] !=DBNull.Value)
                {
                   remark.RRemarkTime = Convert.ToDateTime(reader["RRemarkTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRemarkReply)) && reader["RRemarkReply"] !=DBNull.Value)
                {
                   remark.RRemarkReply = reader["RRemarkReply"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RReplyTime)) && reader["RReplyTime"] !=DBNull.Value)
                {
                   remark.RReplyTime = Convert.ToDateTime(reader["RReplyTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRemarkState)) && reader["RRemarkState"] !=DBNull.Value)
                {
                   remark.RRemarkState = Convert.ToByte(reader["RRemarkState"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, RemarkFields.RRowValid)) && reader["RRowValid"] !=DBNull.Value)
                {
                   remark.RRowValid = Convert.ToByte(reader["RRowValid"]);
                }

                  list.Add(remark);
            }
            reader.Close();
            return list;
        }
    }
}
