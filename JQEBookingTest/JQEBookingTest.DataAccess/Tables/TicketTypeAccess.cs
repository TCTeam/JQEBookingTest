//-----------------------------------------------------------------------
// <copyright company="同程网" file="TicketTypeAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：TicketType表添删改查操作
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
    /// TicketType表添删改查操作
    /// </summary>
    public partial class TicketTypeAccess
    {
        /// <summary>
        /// TicketType 添加操作
        /// </summary>
        /// <param name="tickettype">TicketType实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(TicketTypeModel tickettype)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表增加操作/File:TicketTypeAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] (TTTypeId,TTTypeName,TTScenicId,TTStartTime,TTDeadline,TTRowValid,TTCreateTime) values(@TTTypeId,@TTTypeName,@TTScenicId,@TTStartTime,@TTDeadline,@TTRowValid,@TTCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@TTTypeId", tickettype.TTTypeId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTTypeName", tickettype.TTTypeName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTScenicId", tickettype.TTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTStartTime", tickettype.TTStartTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@TTDeadline", tickettype.TTDeadline,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@TTRowValid", tickettype.TTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@TTCreateTime", tickettype.TTCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// TicketType 添加操作
        /// </summary>
        /// <param name="tickettype">TicketType实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(TicketTypeModel tickettype,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表增加操作/File:TicketTypeAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] (TTTypeId,TTTypeName,TTScenicId,TTStartTime,TTDeadline,TTRowValid,TTCreateTime) values(@TTTypeId,@TTTypeName,@TTScenicId,@TTStartTime,@TTDeadline,@TTRowValid,@TTCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@TTTypeId", tickettype.TTTypeId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTTypeName", tickettype.TTTypeName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTScenicId", tickettype.TTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@TTStartTime", tickettype.TTStartTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@TTDeadline", tickettype.TTDeadline,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@TTRowValid", tickettype.TTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@TTCreateTime", tickettype.TTCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<TicketTypeFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表增加操作/File:TicketTypeAccess.cs/Fun:Add*/";
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
        public bool Add(List<TicketTypeFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表增加操作/File:TicketTypeAccess.cs/Fun:Add*/";
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
        /// <param name="list">TicketType实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<TicketTypeModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(TicketTypeModel tickettype in  list)
                  {
                       Add(tickettype,trans.DbTransaction); 
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
        /// TicketType 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表删除操作/File:TicketTypeAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// TicketType 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表删除操作/File:TicketTypeAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }


        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<TicketTypeWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表删除操作/File:TicketTypeAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] where ");
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
        public bool Delete(List<TicketTypeWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表删除操作/File:TicketTypeAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] where ");
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
        public bool Delete(TicketTypeWhereFields where)
        {
           List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(TicketTypeWhereFields where,DbTransaction transaction)
        {
           List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }


        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<TicketTypeFieldValuePair> update, List<TicketTypeWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表更新操作/File:TicketTypeAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] set ");
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
        public bool Update(List<TicketTypeFieldValuePair> update, List<TicketTypeWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表更新操作/File:TicketTypeAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] set ");
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
        public bool Update(List<TicketTypeFieldValuePair> update,TicketTypeWhereFields where)
        {
            List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields>();
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
        public bool Update(List<TicketTypeFieldValuePair> update, TicketTypeWhereFields where,DbTransaction transaction)
        {
            List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(TicketTypeFieldValuePair update, TicketTypeWhereFields where)
        {
            List<TicketTypeFieldValuePair> updates=new List<TicketTypeFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields>();
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
        public bool Update(TicketTypeFieldValuePair update,TicketTypeWhereFields where,DbTransaction transaction)
        {
            List<TicketTypeFieldValuePair> updates=new List<TicketTypeFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<TicketTypeWhereFields> wheres = new List<TicketTypeWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select TTId,TTTypeId,TTTypeName,TTScenicId,TTStartTime,TTDeadline,TTRowValid,TTCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable()
        {
            return GetTicketTypeTable(DataBaseType.Read);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select TTId,TTTypeId,TTTypeName,TTScenicId,TTStartTime,TTDeadline,TTRowValid,TTCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList()
        {
            return GetTicketTypeList(DataBaseType.Read);
        }


        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields where)
        {
              List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
              whereFields.Add(where);
              return GetTicketTypeTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(TicketTypeWhereFields where)
        {
            return  GetTicketTypeTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields where)
        {
              List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
              whereFields.Add(where);
              return GetTicketTypeList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields where)
        {
            return GetTicketTypeList(DataBaseType.Read,where);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetTicketTypeTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
             return GetTicketTypeTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetTicketTypeList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public static List<TicketTypeModel> GetTicketTypeListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public static List<TicketTypeModel> GetTicketTypeListBySql(string sql, List<TicketTypeWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeList*/";
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
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            return GetTicketTypeList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
             return GetTicketTypeTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTicketTypeList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
               return GetTicketTypeList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
               return GetTicketTypeTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
              return GetTicketTypeTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeWhereFields> whereFields)
        {
               return GetTicketTypeList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeWhereFields> whereFields)
        {
             return GetTicketTypeList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeWhereFields> whereFields)
        {
               return GetTicketTypeTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(List<TicketTypeWhereFields> whereFields)
        {
               return GetTicketTypeTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType, List<TicketTypeOrderFields> orderFields)
        {
               return GetTicketTypeTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(List<TicketTypeOrderFields> orderFields)
        {
             return GetTicketTypeTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType, List<TicketTypeOrderFields> orderFields)
        {
               return GetTicketTypeList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeOrderFields> orderFields)
        {
              return GetTicketTypeList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
               return GetTicketTypeList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
              return  GetTicketTypeList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public int GetCount(DataBaseType dbType, List<TicketTypeWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTopTicketTypeTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
       /// <returns>返回TicketType表格</returns>
        public int GetCount(List<TicketTypeWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public object GetObject(DataBaseType dbType, TicketTypeFields showField, List<TicketTypeWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTopTicketTypeTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
       /// <returns>返回TicketType表格</returns>
        public object GetObject(TicketTypeFields showField, List<TicketTypeWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTopTicketTypeTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
             return GetTopTicketTypeTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:TicketType表查询操作/File:TicketTypeAccess.cs/Fun:GetTopTicketTypeList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[TicketType] with(nolock)");
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
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
             return GetTopTicketTypeList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<TicketTypeFieldValuePair> fieldsList)
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

            return "insert [JQEBooking].[dbo].[TicketType] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<TicketTypeFields> showFieldsList)
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
        public string GetOrderFields(List<TicketTypeOrderFields> orderList)
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
        public static string GetSqlString(List<TicketTypeFieldValuePair> updates, List<TicketTypeWhereFields> where)
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
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, TicketTypeFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case TicketTypeFields.TTId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case TicketTypeFields.TTTypeId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case TicketTypeFields.TTTypeName:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case TicketTypeFields.TTScenicId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case TicketTypeFields.TTStartTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case TicketTypeFields.TTDeadline:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case TicketTypeFields.TTRowValid:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case TicketTypeFields.TTCreateTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

            }
        }

        /// <summary>
        /// 获取SqlParameterWrapperCollection
        /// </summary>
        /// <param name="collection">SqlParameterWrapperCollection</param>
        /// <param name="updates">更新列表</param>
        /// <param name="where">条件列表</param>
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<TicketTypeFieldValuePair> updates, List<TicketTypeWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( TicketTypeFieldValuePair values in updates )
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
      public static string IsWhereField(List<TicketTypeWhereFields> where, int index)
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
        public static  bool IsExistField(List<TicketTypeFieldValuePair> list, TicketTypeFields field)
        {
            foreach ( TicketTypeFieldValuePair f in list )
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
        public static bool IsExistField(List<TicketTypeFields> list, TicketTypeFields field)
        {
            foreach ( TicketTypeFields f in list )
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
        /// <returns>返回TicketType实体列表</returns>
        public static  List<TicketTypeModel> GetList(List<TicketTypeFields> showFields, IDataReader reader)
        {
            List< TicketTypeModel> list = new List< TicketTypeModel>();
            while ( reader.Read() )
            {
                 TicketTypeModel tickettype= new TicketTypeModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTId)) && reader["TTId"] !=DBNull.Value)
                {
                   tickettype.TTId = Convert.ToInt32(reader["TTId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTTypeId)) && reader["TTTypeId"] !=DBNull.Value)
                {
                   tickettype.TTTypeId = reader["TTTypeId"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTTypeName)) && reader["TTTypeName"] !=DBNull.Value)
                {
                   tickettype.TTTypeName = reader["TTTypeName"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTScenicId)) && reader["TTScenicId"] !=DBNull.Value)
                {
                   tickettype.TTScenicId = reader["TTScenicId"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTStartTime)) && reader["TTStartTime"] !=DBNull.Value)
                {
                   tickettype.TTStartTime = Convert.ToDateTime(reader["TTStartTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTDeadline)) && reader["TTDeadline"] !=DBNull.Value)
                {
                   tickettype.TTDeadline = Convert.ToDateTime(reader["TTDeadline"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTRowValid)) && reader["TTRowValid"] !=DBNull.Value)
                {
                   tickettype.TTRowValid = Convert.ToByte(reader["TTRowValid"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, TicketTypeFields.TTCreateTime)) && reader["TTCreateTime"] !=DBNull.Value)
                {
                   tickettype.TTCreateTime = Convert.ToDateTime(reader["TTCreateTime"]);
                }

                  list.Add(tickettype);
            }
            reader.Close();
            return list;
        }
    }
}
