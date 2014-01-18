//-----------------------------------------------------------------------
// <copyright company="同程网" file="AdminAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Admin表添删改查操作
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
    /// Admin表添删改查操作
    /// </summary>
    public partial class AdminAccess
    {
        /// <summary>
        /// Admin 添加操作
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(AdminModel admin)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] (AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId) values(@AName,@APassword,@AEmail,@ATelephone,@ARowValid,@ACreateTime,@AScenicId,@AUserId)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@AName", admin.AName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@APassword", admin.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", admin.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", admin.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", admin.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", admin.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", admin.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AUserId", admin.AUserId,SqlDbType.NVarChar));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// Admin 添加操作
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(AdminModel admin,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] (AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId) values(@AName,@APassword,@AEmail,@ATelephone,@ARowValid,@ACreateTime,@AScenicId,@AUserId)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@AName", admin.AName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@APassword", admin.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", admin.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", admin.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", admin.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", admin.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", admin.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AUserId", admin.AUserId,SqlDbType.NVarChar));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<AdminFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:Add*/";
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
        public bool Add(List<AdminFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:Add*/";
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
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<AdminModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(AdminModel admin in  list)
                  {
                       Add(admin,trans.DbTransaction); 
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
        /// Admin 添加操作返回主键的编号
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(AdminModel admin)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] (AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId) values(@AName,@APassword,@AEmail,@ATelephone,@ARowValid,@ACreateTime,@AScenicId,@AUserId)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@AName", admin.AName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@APassword", admin.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", admin.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", admin.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", admin.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", admin.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", admin.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AUserId", admin.AUserId,SqlDbType.NVarChar));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection);
        }

        /// <summary>
        /// Admin 添加操作返回主键的编号
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(AdminModel admin,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] (AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId) values(@AName,@APassword,@AEmail,@ATelephone,@ARowValid,@ACreateTime,@AScenicId,@AUserId)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@AName", admin.AName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@APassword", admin.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", admin.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", admin.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", admin.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", admin.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", admin.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AUserId", admin.AUserId,SqlDbType.NVarChar));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(List<AdminFieldValuePair> list)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:AddByIdentity*/";
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
        public int AddByIdentity(List<AdminFieldValuePair> list,DbTransaction transaction)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表增加操作/File:AdminAccess.cs/Fun:AddByIdentity*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(GetInsertSql(list));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection,transaction);
        }

        /// <summary>
        /// Admin 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// Admin 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }

        /// <summary>
        /// Admin 根据主键删除操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int aId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] where AId=@AId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@AId",aId,SqlDbType.Int)) > 0;
        }

        /// <summary>
        /// Admin 根据主键删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <param name="aId">景区用户Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int aId,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] where AId=@AId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@AId",aId,SqlDbType.Int),transaction) > 0;
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">Admin主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(int aid in  list)
                  {
                       Delete(aid,trans.DbTransaction); 
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
        public bool Delete(List<AdminWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] where ");
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
        public bool Delete(List<AdminWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表删除操作/File:AdminAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] where ");
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
        public bool Delete(AdminWhereFields where)
        {
           List<AdminWhereFields> wheres = new List<AdminWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(AdminWhereFields where,DbTransaction transaction)
        {
           List<AdminWhereFields> wheres = new List<AdminWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }

        /// <summary>
        /// Admin根据主键修改
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <param name="updateModel">要修改Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int aId,AdminModel updateModel)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表更新操作/File:AdminAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] set APassword=@APassword,AEmail=@AEmail,ATelephone=@ATelephone,ARowValid=@ARowValid,ACreateTime=@ACreateTime,AScenicId=@AScenicId, where AId=@AId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@APassword", updateModel.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", updateModel.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", updateModel.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", updateModel.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", updateModel.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", updateModel.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AId", aId,SqlDbType.Int));
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// Admin修改操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <param name="updateModel">要修改Admin实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int aId,AdminModel updateModel,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表更新操作/File:AdminAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] set APassword=@APassword,AEmail=@AEmail,ATelephone=@ATelephone,ARowValid=@ARowValid,ACreateTime=@ACreateTime,AScenicId=@AScenicId, where AId=@AId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@APassword", updateModel.APassword,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AEmail", updateModel.AEmail,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ATelephone", updateModel.ATelephone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@ARowValid", updateModel.ARowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@ACreateTime", updateModel.ACreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@AScenicId", updateModel.AScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@AId", aId,SqlDbType.Int));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<AdminModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(AdminModel admin in  list)
                  {
                       Update(admin.AId,admin,trans.DbTransaction); 
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
        public bool Update(List<AdminFieldValuePair> update, List<AdminWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表更新操作/File:AdminAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] set ");
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
        public bool Update(List<AdminFieldValuePair> update, List<AdminWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表更新操作/File:AdminAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] set ");
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
        public bool Update(List<AdminFieldValuePair> update,AdminWhereFields where)
        {
            List<AdminWhereFields> wheres = new List<AdminWhereFields>();
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
        public bool Update(List<AdminFieldValuePair> update, AdminWhereFields where,DbTransaction transaction)
        {
            List<AdminWhereFields> wheres = new List<AdminWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(AdminFieldValuePair update, AdminWhereFields where)
        {
            List<AdminFieldValuePair> updates=new List<AdminFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<AdminWhereFields> wheres = new List<AdminWhereFields>();
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
        public bool Update(AdminFieldValuePair update,AdminWhereFields where,DbTransaction transaction)
        {
            List<AdminFieldValuePair> updates=new List<AdminFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<AdminWhereFields> wheres = new List<AdminWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select AId,AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable()
        {
            return GetAdminTable(DataBaseType.Read);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select AId,AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList()
        {
            return GetAdminList(DataBaseType.Read);
        }

        /// <summary>
        /// Admin 跟主键查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回Admin实体</returns>
        public AdminModel GetAdminList(DataBaseType dbType,int aId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select AId,AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock) where AId=@AId");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@AId",aId,SqlDbType.Int));
            List<AdminModel> list= GetList(null, reader);
            if(list ==null || list.Count==0)
            {
                return null;
            }
            return list[0];
        }

        /// <summary>
        /// Admin 跟主键查询操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回Admin实体</returns>
        public AdminModel GetAdminList(int aId)
        {
              return GetAdminList(DataBaseType.Read,aId);
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,int aId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select AId,AName,APassword,AEmail,ATelephone,ARowValid,ACreateTime,AScenicId,AUserId from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock) where AId=@AId");
           return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@AId",aId,SqlDbType.Int));
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回表格</returns>
        public DataTable GetAdminTable(int aId)
        {
             return GetAdminTable(DataBaseType.Read,aId);
        }


        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields where)
        {
              List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
              whereFields.Add(where);
              return GetAdminTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(AdminWhereFields where)
        {
            return  GetAdminTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields where)
        {
              List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
              whereFields.Add(where);
              return GetAdminList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(AdminWhereFields where)
        {
            return GetAdminList(DataBaseType.Read,where);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetAdminTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(AdminWhereFields whereField,AdminOrderFields orderField)
        {
             return GetAdminTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetAdminList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public static List<AdminModel> GetAdminListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public static List<AdminModel> GetAdminListBySql(string sql, List<AdminWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
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
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(AdminWhereFields whereField,AdminOrderFields orderField)
        {
            return GetAdminList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
             return GetAdminTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
               return GetAdminList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
               return GetAdminTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
              return GetAdminTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminWhereFields> whereFields)
        {
               return GetAdminList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminWhereFields> whereFields)
        {
             return GetAdminList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminWhereFields> whereFields)
        {
               return GetAdminTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(List<AdminWhereFields> whereFields)
        {
               return GetAdminTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType, List<AdminOrderFields> orderFields)
        {
               return GetAdminTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(List<AdminOrderFields> orderFields)
        {
             return GetAdminTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType, List<AdminOrderFields> orderFields)
        {
               return GetAdminList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminOrderFields> orderFields)
        {
              return GetAdminList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
               return GetAdminList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
              return  GetAdminList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public int GetCount(DataBaseType dbType, List<AdminWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetTopAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
       /// <returns>返回Admin表格</returns>
        public int GetCount(List<AdminWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public object GetObject(DataBaseType dbType, AdminFields showField, List<AdminWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetTopAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
       /// <returns>返回Admin表格</returns>
        public object GetObject(AdminFields showField, List<AdminWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetTopAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
             return GetTopAdminTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表查询操作/File:AdminAccess.cs/Fun:GetTopAdminList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[Admin] with(nolock)");
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
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
             return GetTopAdminList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
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
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表分页查询操作/File:AdminAccess.cs/Fun:GetAdminList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("Admin", "AId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
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
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetAdminList(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
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
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:Admin表分页查询操作/File:AdminAccess.cs/Fun:GetAdminTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("Admin", "AId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
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
        public DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetAdminTable(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<AdminFieldValuePair> fieldsList)
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

            return "insert [JQEBooking].[dbo].[Admin] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<AdminFields> showFieldsList)
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
        public string GetOrderFields(List<AdminOrderFields> orderList)
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
        public static string GetSqlString(List<AdminFieldValuePair> updates, List<AdminWhereFields> where)
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
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, AdminFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case AdminFields.AId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case AdminFields.AName:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case AdminFields.APassword:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case AdminFields.AEmail:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case AdminFields.ATelephone:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case AdminFields.ARowValid:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case AdminFields.ACreateTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case AdminFields.AScenicId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case AdminFields.AUserId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

            }
        }

        /// <summary>
        /// 获取SqlParameterWrapperCollection
        /// </summary>
        /// <param name="collection">SqlParameterWrapperCollection</param>
        /// <param name="updates">更新列表</param>
        /// <param name="where">条件列表</param>
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<AdminFieldValuePair> updates, List<AdminWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( AdminFieldValuePair values in updates )
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
      public static string IsWhereField(List<AdminWhereFields> where, int index)
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
        public static  bool IsExistField(List<AdminFieldValuePair> list, AdminFields field)
        {
            foreach ( AdminFieldValuePair f in list )
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
        public static bool IsExistField(List<AdminFields> list, AdminFields field)
        {
            foreach ( AdminFields f in list )
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
        /// <returns>返回Admin实体列表</returns>
        public static  List<AdminModel> GetList(List<AdminFields> showFields, IDataReader reader)
        {
            List< AdminModel> list = new List< AdminModel>();
            while ( reader.Read() )
            {
                 AdminModel admin= new AdminModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.AId)) && reader["AId"] !=DBNull.Value)
                {
                   admin.AId = Convert.ToInt32(reader["AId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.AName)) && reader["AName"] !=DBNull.Value)
                {
                   admin.AName = reader["AName"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.APassword)) && reader["APassword"] !=DBNull.Value)
                {
                   admin.APassword = reader["APassword"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.AEmail)) && reader["AEmail"] !=DBNull.Value)
                {
                   admin.AEmail = reader["AEmail"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.ATelephone)) && reader["ATelephone"] !=DBNull.Value)
                {
                   admin.ATelephone = reader["ATelephone"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.ARowValid)) && reader["ARowValid"] !=DBNull.Value)
                {
                   admin.ARowValid = Convert.ToByte(reader["ARowValid"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.ACreateTime)) && reader["ACreateTime"] !=DBNull.Value)
                {
                   admin.ACreateTime = Convert.ToDateTime(reader["ACreateTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.AScenicId)) && reader["AScenicId"] !=DBNull.Value)
                {
                   admin.AScenicId = reader["AScenicId"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, AdminFields.AUserId)) && reader["AUserId"] !=DBNull.Value)
                {
                   admin.AUserId = reader["AUserId"].ToString();
                }

                  list.Add(admin);
            }
            reader.Close();
            return list;
        }
    }
}
