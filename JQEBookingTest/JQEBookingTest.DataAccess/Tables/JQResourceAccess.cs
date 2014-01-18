//-----------------------------------------------------------------------
// <copyright company="同程网" file="JQResourceAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：JQResource表添删改查操作
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
    /// JQResource表添删改查操作
    /// </summary>
    public partial class JQResourceAccess
    {
        /// <summary>
        /// JQResource 添加操作
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(JQResourceModel jqresource)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] (JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime) values(@JQRScenicId,@JQRScenicName,@JQRScenicDecribe,@JQRPrincipal,@JQRAddress,@JQRTelephone,@JQREmail,@JQRRowValid,@JQRCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicId", jqresource.JQRScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicName", jqresource.JQRScenicName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", jqresource.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", jqresource.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", jqresource.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", jqresource.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", jqresource.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", jqresource.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", jqresource.JQRCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// JQResource 添加操作
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(JQResourceModel jqresource,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] (JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime) values(@JQRScenicId,@JQRScenicName,@JQRScenicDecribe,@JQRPrincipal,@JQRAddress,@JQRTelephone,@JQREmail,@JQRRowValid,@JQRCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicId", jqresource.JQRScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicName", jqresource.JQRScenicName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", jqresource.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", jqresource.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", jqresource.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", jqresource.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", jqresource.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", jqresource.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", jqresource.JQRCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<JQResourceFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:Add*/";
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
        public bool Add(List<JQResourceFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:Add*/";
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
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<JQResourceModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(JQResourceModel jqresource in  list)
                  {
                       Add(jqresource,trans.DbTransaction); 
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
        /// JQResource 添加操作返回主键的编号
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(JQResourceModel jqresource)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] (JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime) values(@JQRScenicId,@JQRScenicName,@JQRScenicDecribe,@JQRPrincipal,@JQRAddress,@JQRTelephone,@JQREmail,@JQRRowValid,@JQRCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicId", jqresource.JQRScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicName", jqresource.JQRScenicName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", jqresource.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", jqresource.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", jqresource.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", jqresource.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", jqresource.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", jqresource.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", jqresource.JQRCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection);
        }

        /// <summary>
        /// JQResource 添加操作返回主键的编号
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(JQResourceModel jqresource,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] (JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime) values(@JQRScenicId,@JQRScenicName,@JQRScenicDecribe,@JQRPrincipal,@JQRAddress,@JQRTelephone,@JQREmail,@JQRRowValid,@JQRCreateTime)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicId", jqresource.JQRScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicName", jqresource.JQRScenicName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", jqresource.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", jqresource.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", jqresource.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", jqresource.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", jqresource.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", jqresource.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", jqresource.JQRCreateTime,SqlDbType.DateTime));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(List<JQResourceFieldValuePair> list)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:AddByIdentity*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(GetInsertSql(list));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <param name="transaction">事务</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(List<JQResourceFieldValuePair> list,DbTransaction transaction)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表增加操作/File:JQResourceAccess.cs/Fun:AddByIdentity*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(GetInsertSql(list));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection,transaction);
        }

        /// <summary>
        /// JQResource 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// JQResource 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }

        /// <summary>
        /// JQResource 根据主键删除操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int jQRId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] where JQRId=@JQRId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@JQRId",jQRId,SqlDbType.Int)) > 0;
        }

        /// <summary>
        /// JQResource 根据主键删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int jQRId,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] where JQRId=@JQRId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@JQRId",jQRId,SqlDbType.Int),transaction) > 0;
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">JQResource主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(int jqrid in  list)
                  {
                       Delete(jqrid,trans.DbTransaction); 
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
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<JQResourceWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] where ");
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
        public bool Delete(List<JQResourceWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表删除操作/File:JQResourceAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] where ");
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
        public bool Delete(JQResourceWhereFields where)
        {
           List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(JQResourceWhereFields where,DbTransaction transaction)
        {
           List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }

        /// <summary>
        /// JQResource根据主键修改
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <param name="updateModel">要修改JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int jQRId,JQResourceModel updateModel)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表更新操作/File:JQResourceAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] set JQRScenicDecribe=@JQRScenicDecribe,JQRPrincipal=@JQRPrincipal,JQRAddress=@JQRAddress,JQRTelephone=@JQRTelephone,JQREmail=@JQREmail,JQRRowValid=@JQRRowValid,JQRCreateTime=@JQRCreateTime where JQRId=@JQRId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", updateModel.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", updateModel.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", updateModel.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", updateModel.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", updateModel.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", updateModel.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", updateModel.JQRCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@JQRId", jQRId,SqlDbType.Int));
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// JQResource修改操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <param name="updateModel">要修改JQResource实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int jQRId,JQResourceModel updateModel,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表更新操作/File:JQResourceAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] set JQRScenicDecribe=@JQRScenicDecribe,JQRPrincipal=@JQRPrincipal,JQRAddress=@JQRAddress,JQRTelephone=@JQRTelephone,JQREmail=@JQREmail,JQRRowValid=@JQRRowValid,JQRCreateTime=@JQRCreateTime where JQRId=@JQRId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@JQRScenicDecribe", updateModel.JQRScenicDecribe,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRPrincipal", updateModel.JQRPrincipal,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRAddress", updateModel.JQRAddress,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRTelephone", updateModel.JQRTelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQREmail", updateModel.JQREmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@JQRRowValid", updateModel.JQRRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@JQRCreateTime", updateModel.JQRCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@JQRId", jQRId,SqlDbType.Int));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<JQResourceModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(JQResourceModel jqresource in  list)
                  {
                       Update(jqresource.JQRId,jqresource,trans.DbTransaction); 
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
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<JQResourceFieldValuePair> update, List<JQResourceWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表更新操作/File:JQResourceAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] set ");
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
        public bool Update(List<JQResourceFieldValuePair> update, List<JQResourceWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表更新操作/File:JQResourceAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] set ");
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
        public bool Update(List<JQResourceFieldValuePair> update,JQResourceWhereFields where)
        {
            List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields>();
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
        public bool Update(List<JQResourceFieldValuePair> update, JQResourceWhereFields where,DbTransaction transaction)
        {
            List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(JQResourceFieldValuePair update, JQResourceWhereFields where)
        {
            List<JQResourceFieldValuePair> updates=new List<JQResourceFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields>();
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
        public bool Update(JQResourceFieldValuePair update,JQResourceWhereFields where,DbTransaction transaction)
        {
            List<JQResourceFieldValuePair> updates=new List<JQResourceFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<JQResourceWhereFields> wheres = new List<JQResourceWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select JQRId,JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable()
        {
            return GetJQResourceTable(DataBaseType.Read);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select JQRId,JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList()
        {
            return GetJQResourceList(DataBaseType.Read);
        }

        /// <summary>
        /// JQResource 跟主键查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回JQResource实体</returns>
        public JQResourceModel GetJQResourceList(DataBaseType dbType,int jQRId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select JQRId,JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock) where JQRId=@JQRId");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@JQRId",jQRId,SqlDbType.Int));
            List<JQResourceModel> list= GetList(null, reader);
            if(list ==null || list.Count==0)
            {
                return null;
            }
            return list[0];
        }

        /// <summary>
        /// JQResource 跟主键查询操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回JQResource实体</returns>
        public JQResourceModel GetJQResourceList(int jQRId)
        {
              return GetJQResourceList(DataBaseType.Read,jQRId);
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,int jQRId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select JQRId,JQRScenicId,JQRScenicName,JQRScenicDecribe,JQRPrincipal,JQRAddress,JQRTelephone,JQREmail,JQRRowValid,JQRCreateTime from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock) where JQRId=@JQRId");
           return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@JQRId",jQRId,SqlDbType.Int));
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(int jQRId)
        {
             return GetJQResourceTable(DataBaseType.Read,jQRId);
        }


        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,JQResourceWhereFields where)
        {
              List<JQResourceWhereFields> whereFields = new List<JQResourceWhereFields>();
              whereFields.Add(where);
              return GetJQResourceTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(JQResourceWhereFields where)
        {
            return  GetJQResourceTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceWhereFields where)
        {
              List<JQResourceWhereFields> whereFields = new List<JQResourceWhereFields>();
              whereFields.Add(where);
              return GetJQResourceList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(JQResourceWhereFields where)
        {
            return GetJQResourceList(DataBaseType.Read,where);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
        {
            List<JQResourceWhereFields> whereFields = new List<JQResourceWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetJQResourceTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(JQResourceWhereFields whereField,JQResourceOrderFields orderField)
        {
             return GetJQResourceTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
        {
            List<JQResourceWhereFields> whereFields = new List<JQResourceWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetJQResourceList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public static List<JQResourceModel> GetJQResourceListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public static List<JQResourceModel> GetJQResourceListBySql(string sql, List<JQResourceWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
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
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(JQResourceWhereFields whereField,JQResourceOrderFields orderField)
        {
            return GetJQResourceList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
             return GetJQResourceTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
               return GetJQResourceList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
               return GetJQResourceTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
              return GetJQResourceTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceWhereFields> whereFields)
        {
               return GetJQResourceList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceWhereFields> whereFields)
        {
             return GetJQResourceList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceWhereFields> whereFields)
        {
               return GetJQResourceTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(List<JQResourceWhereFields> whereFields)
        {
               return GetJQResourceTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType, List<JQResourceOrderFields> orderFields)
        {
               return GetJQResourceTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(List<JQResourceOrderFields> orderFields)
        {
             return GetJQResourceTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType, List<JQResourceOrderFields> orderFields)
        {
               return GetJQResourceList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceOrderFields> orderFields)
        {
              return GetJQResourceList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
               return GetJQResourceList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
              return  GetJQResourceList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public int GetCount(DataBaseType dbType, List<JQResourceWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetTopJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
       /// <returns>返回JQResource表格</returns>
        public int GetCount(List<JQResourceWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public object GetObject(DataBaseType dbType, JQResourceFields showField, List<JQResourceWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetTopJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
       /// <returns>返回JQResource表格</returns>
        public object GetObject(JQResourceFields showField, List<JQResourceWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetTopJQResourceTable(DataBaseType dbType,int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetTopJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetTopJQResourceTable(int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
             return GetTopJQResourceTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetTopJQResourceList(DataBaseType dbType,int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表查询操作/File:JQResourceAccess.cs/Fun:GetTopJQResourceList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[JQResource] with(nolock)");
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
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetTopJQResourceList(int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
             return GetTopJQResourceList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表分页查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("JQResource", "JQRId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                GetSqlParameterWrapperCollection(collection, null, whereFields);
            }

            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(), collection);
            return  GetList(showFields,reader);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetJQResourceList(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:JQResource表分页查询操作/File:JQResourceAccess.cs/Fun:GetJQResourceTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("JQResource", "JQRId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();

            if ( whereFields != null && whereFields.Count > 0 )
            {
                GetSqlParameterWrapperCollection(collection, null, whereFields);
            }
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),collection);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetJQResourceTable(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<JQResourceFieldValuePair> fieldsList)
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

            return "insert [JQEBooking].[dbo].[JQResource] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<JQResourceFields> showFieldsList)
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
        public string GetOrderFields(List<JQResourceOrderFields> orderList)
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
        public static string GetSqlString(List<JQResourceFieldValuePair> updates, List<JQResourceWhereFields> where)
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
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, JQResourceFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case JQResourceFields.JQRId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case JQResourceFields.JQRScenicId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRScenicName:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRScenicDecribe:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRPrincipal:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRAddress:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRTelephone:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQREmail:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case JQResourceFields.JQRRowValid:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case JQResourceFields.JQRCreateTime:
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
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<JQResourceFieldValuePair> updates, List<JQResourceWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( JQResourceFieldValuePair values in updates )
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
      public static string IsWhereField(List<JQResourceWhereFields> where, int index)
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
        public static  bool IsExistField(List<JQResourceFieldValuePair> list, JQResourceFields field)
        {
            foreach ( JQResourceFieldValuePair f in list )
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
        public static bool IsExistField(List<JQResourceFields> list, JQResourceFields field)
        {
            foreach ( JQResourceFields f in list )
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
        /// <returns>返回JQResource实体列表</returns>
        public static  List<JQResourceModel> GetList(List<JQResourceFields> showFields, IDataReader reader)
        {
            List< JQResourceModel> list = new List< JQResourceModel>();
            while ( reader.Read() )
            {
                 JQResourceModel jqresource= new JQResourceModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRId)) && reader["JQRId"] !=DBNull.Value)
                {
                   jqresource.JQRId = Convert.ToInt32(reader["JQRId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRScenicId)) && reader["JQRScenicId"] !=DBNull.Value)
                {
                   jqresource.JQRScenicId = reader["JQRScenicId"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRScenicName)) && reader["JQRScenicName"] !=DBNull.Value)
                {
                   jqresource.JQRScenicName = reader["JQRScenicName"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRScenicDecribe)) && reader["JQRScenicDecribe"] !=DBNull.Value)
                {
                   jqresource.JQRScenicDecribe = reader["JQRScenicDecribe"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRPrincipal)) && reader["JQRPrincipal"] !=DBNull.Value)
                {
                   jqresource.JQRPrincipal = reader["JQRPrincipal"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRAddress)) && reader["JQRAddress"] !=DBNull.Value)
                {
                   jqresource.JQRAddress = reader["JQRAddress"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRTelephone)) && reader["JQRTelephone"] !=DBNull.Value)
                {
                   jqresource.JQRTelephone = reader["JQRTelephone"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQREmail)) && reader["JQREmail"] !=DBNull.Value)
                {
                   jqresource.JQREmail = reader["JQREmail"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRRowValid)) && reader["JQRRowValid"] !=DBNull.Value)
                {
                   jqresource.JQRRowValid = Convert.ToByte(reader["JQRRowValid"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, JQResourceFields.JQRCreateTime)) && reader["JQRCreateTime"] !=DBNull.Value)
                {
                   jqresource.JQRCreateTime = Convert.ToDateTime(reader["JQRCreateTime"]);
                }

                  list.Add(jqresource);
            }
            reader.Close();
            return list;
        }
    }
}
