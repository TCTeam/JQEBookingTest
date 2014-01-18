//-----------------------------------------------------------------------
// <copyright company="同程网" file="OrderTableAccess.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表添删改查操作
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
    /// OrderTable表添删改查操作
    /// </summary>
    public partial class OrderTableAccess
    {
        /// <summary>
        /// OrderTable 添加操作
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(OrderTableModel ordertable)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] (OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber) values(@OTOrderSerialNo,@OTOrderComfirmNo,@OTOrderCreateTime,@OTTravelTime,@OTOrderPhone,@OTOrderName,@OTTicketPhone,@OTTicketName,@OTTicketNumber,@OTOrderState,@OTPayWay,@OTTicketPrice,@OTIdentityCard,@OTBrokerage,@OTTicketType,@OTCreateTime,@OTRowValid,@OTRemark,@OTScenicId,@OTHaveTicketNumber)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderSerialNo", ordertable.OTOrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", ordertable.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", ordertable.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", ordertable.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", ordertable.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", ordertable.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", ordertable.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", ordertable.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", ordertable.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", ordertable.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", ordertable.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", ordertable.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", ordertable.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", ordertable.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", ordertable.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", ordertable.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", ordertable.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", ordertable.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", ordertable.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", ordertable.OTHaveTicketNumber,SqlDbType.Int));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// OrderTable 添加操作
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(OrderTableModel ordertable,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:Add*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] (OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber) values(@OTOrderSerialNo,@OTOrderComfirmNo,@OTOrderCreateTime,@OTTravelTime,@OTOrderPhone,@OTOrderName,@OTTicketPhone,@OTTicketName,@OTTicketNumber,@OTOrderState,@OTPayWay,@OTTicketPrice,@OTIdentityCard,@OTBrokerage,@OTTicketType,@OTCreateTime,@OTRowValid,@OTRemark,@OTScenicId,@OTHaveTicketNumber)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderSerialNo", ordertable.OTOrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", ordertable.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", ordertable.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", ordertable.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", ordertable.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", ordertable.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", ordertable.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", ordertable.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", ordertable.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", ordertable.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", ordertable.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", ordertable.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", ordertable.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", ordertable.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", ordertable.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", ordertable.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", ordertable.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", ordertable.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", ordertable.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", ordertable.OTHaveTicketNumber,SqlDbType.Int));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<OrderTableFieldValuePair> list)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:Add*/";
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
        public bool Add(List<OrderTableFieldValuePair> list,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:Add*/";
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
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<OrderTableModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(OrderTableModel ordertable in  list)
                  {
                       Add(ordertable,trans.DbTransaction); 
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
        /// OrderTable 添加操作返回主键的编号
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(OrderTableModel ordertable)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] (OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber) values(@OTOrderSerialNo,@OTOrderComfirmNo,@OTOrderCreateTime,@OTTravelTime,@OTOrderPhone,@OTOrderName,@OTTicketPhone,@OTTicketName,@OTTicketNumber,@OTOrderState,@OTPayWay,@OTTicketPrice,@OTIdentityCard,@OTBrokerage,@OTTicketType,@OTCreateTime,@OTRowValid,@OTRemark,@OTScenicId,@OTHaveTicketNumber)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderSerialNo", ordertable.OTOrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", ordertable.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", ordertable.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", ordertable.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", ordertable.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", ordertable.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", ordertable.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", ordertable.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", ordertable.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", ordertable.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", ordertable.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", ordertable.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", ordertable.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", ordertable.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", ordertable.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", ordertable.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", ordertable.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", ordertable.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", ordertable.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", ordertable.OTHaveTicketNumber,SqlDbType.Int));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection);
        }

        /// <summary>
        /// OrderTable 添加操作返回主键的编号
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(OrderTableModel ordertable,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:AddByIdentity*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("insert ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] (OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber) values(@OTOrderSerialNo,@OTOrderComfirmNo,@OTOrderCreateTime,@OTTravelTime,@OTOrderPhone,@OTOrderName,@OTTicketPhone,@OTTicketName,@OTTicketNumber,@OTOrderState,@OTPayWay,@OTTicketPrice,@OTIdentityCard,@OTBrokerage,@OTTicketType,@OTCreateTime,@OTRowValid,@OTRemark,@OTScenicId,@OTHaveTicketNumber)");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderSerialNo", ordertable.OTOrderSerialNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", ordertable.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", ordertable.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", ordertable.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", ordertable.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", ordertable.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", ordertable.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", ordertable.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", ordertable.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", ordertable.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", ordertable.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", ordertable.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", ordertable.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", ordertable.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", ordertable.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", ordertable.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", ordertable.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", ordertable.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", ordertable.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", ordertable.OTHaveTicketNumber,SqlDbType.Int));
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        public int AddByIdentity(List<OrderTableFieldValuePair> list)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:AddByIdentity*/";
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
        public int AddByIdentity(List<OrderTableFieldValuePair> list,DbTransaction transaction)
        {
            string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表增加操作/File:OrderTableAccess.cs/Fun:AddByIdentity*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(GetInsertSql(list));
            SqlParameterWrapperCollection collection = new SqlParameterWrapperCollection();
            GetSqlParameterWrapperCollection(collection, list, null);
           return SqlHelper.ExecuteIdentity(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),collection,transaction);
        }

        /// <summary>
        /// OrderTable 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString()) > 0;
        }

        /// <summary>
        /// OrderTable 删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable]");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),transaction) > 0;
        }

        /// <summary>
        /// OrderTable 根据主键删除操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int oTId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] where OTId=@OTId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@OTId",oTId,SqlDbType.Int)) > 0;
        }

        /// <summary>
        /// OrderTable 根据主键删除操作
        /// </summary>
        /// <param name="transaction">事务</param>
        /// <param name="oTId">订单表id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int oTId,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
           StringBuilder sql = new StringBuilder();
           sql.Append(sqlDescription);
           sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] where OTId=@OTId ");
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),new SqlParameterWrapper("@OTId",oTId,SqlDbType.Int),transaction) > 0;
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">OrderTable主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(int otid in  list)
                  {
                       Delete(otid,trans.DbTransaction); 
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
        public bool Delete(List<OrderTableWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] where ");
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
        public bool Delete(List<OrderTableWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表删除操作/File:OrderTableAccess.cs/Fun:Delete*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("delete ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] where ");
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
        public bool Delete(OrderTableWhereFields where)
        {
           List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields> ();
           wheres.Add(where);
           return Delete(wheres);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="where">删除条件</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(OrderTableWhereFields where,DbTransaction transaction)
        {
           List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields> ();
           wheres.Add(where);
           return Delete(wheres,transaction);
        }

        /// <summary>
        /// OrderTable根据主键修改
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <param name="updateModel">要修改OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int oTId,OrderTableModel updateModel)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表更新操作/File:OrderTableAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] set OTOrderComfirmNo=@OTOrderComfirmNo,OTOrderCreateTime=@OTOrderCreateTime,OTTravelTime=@OTTravelTime,OTOrderPhone=@OTOrderPhone,OTOrderName=@OTOrderName,OTTicketPhone=@OTTicketPhone,OTTicketName=@OTTicketName,OTTicketNumber=@OTTicketNumber,OTOrderState=@OTOrderState,OTPayWay=@OTPayWay,OTTicketPrice=@OTTicketPrice,OTIdentityCard=@OTIdentityCard,OTBrokerage=@OTBrokerage,OTTicketType=@OTTicketType,OTCreateTime=@OTCreateTime,OTRowValid=@OTRowValid,OTRemark=@OTRemark,OTScenicId=@OTScenicId,OTHaveTicketNumber=@OTHaveTicketNumber where OTId=@OTId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", updateModel.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", updateModel.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", updateModel.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", updateModel.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", updateModel.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", updateModel.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", updateModel.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", updateModel.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", updateModel.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", updateModel.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", updateModel.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", updateModel.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", updateModel.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", updateModel.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", updateModel.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", updateModel.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", updateModel.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", updateModel.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", updateModel.OTHaveTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTId", oTId,SqlDbType.Int));
            return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection) > 0;
        }

        /// <summary>
        /// OrderTable修改操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <param name="updateModel">要修改OrderTable实体类</param>
        /// <param name="transaction">事务</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int oTId,OrderTableModel updateModel,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表更新操作/File:OrderTableAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
           sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] set OTOrderComfirmNo=@OTOrderComfirmNo,OTOrderCreateTime=@OTOrderCreateTime,OTTravelTime=@OTTravelTime,OTOrderPhone=@OTOrderPhone,OTOrderName=@OTOrderName,OTTicketPhone=@OTTicketPhone,OTTicketName=@OTTicketName,OTTicketNumber=@OTTicketNumber,OTOrderState=@OTOrderState,OTPayWay=@OTPayWay,OTTicketPrice=@OTTicketPrice,OTIdentityCard=@OTIdentityCard,OTBrokerage=@OTBrokerage,OTTicketType=@OTTicketType,OTCreateTime=@OTCreateTime,OTRowValid=@OTRowValid,OTRemark=@OTRemark,OTScenicId=@OTScenicId,OTHaveTicketNumber=@OTHaveTicketNumber where OTId=@OTId");
           SqlParameterWrapperCollection Collection = new SqlParameterWrapperCollection();
           Collection.Add(new SqlParameterWrapper("@OTOrderComfirmNo", updateModel.OTOrderComfirmNo,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderCreateTime", updateModel.OTOrderCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTTravelTime", updateModel.OTTravelTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTOrderPhone", updateModel.OTOrderPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTOrderName", updateModel.OTOrderName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketPhone", updateModel.OTTicketPhone,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketName", updateModel.OTTicketName,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTTicketNumber", updateModel.OTTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTOrderState", updateModel.OTOrderState,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTPayWay", updateModel.OTPayWay,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTTicketPrice", updateModel.OTTicketPrice,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTIdentityCard", updateModel.OTIdentityCard,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTBrokerage", updateModel.OTBrokerage,SqlDbType.Money));
           Collection.Add(new SqlParameterWrapper("@OTTicketType", updateModel.OTTicketType,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTCreateTime", updateModel.OTCreateTime,SqlDbType.DateTime));
           Collection.Add(new SqlParameterWrapper("@OTRowValid", updateModel.OTRowValid,SqlDbType.TinyInt));
           Collection.Add(new SqlParameterWrapper("@OTRemark", updateModel.OTRemark,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTScenicId", updateModel.OTScenicId,SqlDbType.NVarChar));
           Collection.Add(new SqlParameterWrapper("@OTHaveTicketNumber", updateModel.OTHaveTicketNumber,SqlDbType.Int));
           Collection.Add(new SqlParameterWrapper("@OTId", oTId,SqlDbType.Int));
           return SqlHelper.ExecuteNonQuery(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig),sql.ToString(),Collection,transaction) > 0;
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<OrderTableModel> list)
        {
             try
             {
               using (DataBaseTransaction trans = new DataBaseTransaction(DatabaseFactory.GetWriteDatabase(DatabaseManager.Db_JQEBookingConfig)))
               {
                  foreach(OrderTableModel ordertable in  list)
                  {
                       Update(ordertable.OTId,ordertable,trans.DbTransaction); 
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
        public bool Update(List<OrderTableFieldValuePair> update, List<OrderTableWhereFields> where)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表更新操作/File:OrderTableAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] set ");
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
        public bool Update(List<OrderTableFieldValuePair> update, List<OrderTableWhereFields> where,DbTransaction transaction)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表更新操作/File:OrderTableAccess.cs/Fun:Update*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("update ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] set ");
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
        public bool Update(List<OrderTableFieldValuePair> update,OrderTableWhereFields where)
        {
            List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields>();
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
        public bool Update(List<OrderTableFieldValuePair> update, OrderTableWhereFields where,DbTransaction transaction)
        {
            List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields>();
            wheres.Add(where);
            return Update(update, wheres,transaction);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="update">更新字段</param>
        /// <param name="where">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(OrderTableFieldValuePair update, OrderTableWhereFields where)
        {
            List<OrderTableFieldValuePair> updates=new List<OrderTableFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields>();
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
        public bool Update(OrderTableFieldValuePair update,OrderTableWhereFields where,DbTransaction transaction)
        {
            List<OrderTableFieldValuePair> updates=new List<OrderTableFieldValuePair> ();
            if(update !=null)
            {
                updates.Add(update); 
            }
            List<OrderTableWhereFields> wheres = new List<OrderTableWhereFields>();
            if(where !=null)
            {
                wheres.Add(where);
            }
            return Update(updates,wheres,transaction);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select OTId,OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
            return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable()
        {
            return GetOrderTableTable(DataBaseType.Read);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select OTId,OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList()
        {
            return GetOrderTableList(DataBaseType.Read);
        }

        /// <summary>
        /// OrderTable 跟主键查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回OrderTable实体</returns>
        public OrderTableModel GetOrderTableList(DataBaseType dbType,int oTId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select OTId,OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock) where OTId=@OTId");
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@OTId",oTId,SqlDbType.Int));
            List<OrderTableModel> list= GetList(null, reader);
            if(list ==null || list.Count==0)
            {
                return null;
            }
            return list[0];
        }

        /// <summary>
        /// OrderTable 跟主键查询操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回OrderTable实体</returns>
        public OrderTableModel GetOrderTableList(int oTId)
        {
              return GetOrderTableList(DataBaseType.Read,oTId);
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,int oTId)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select OTId,OTOrderSerialNo,OTOrderComfirmNo,OTOrderCreateTime,OTTravelTime,OTOrderPhone,OTOrderName,OTTicketPhone,OTTicketName,OTTicketNumber,OTOrderState,OTPayWay,OTTicketPrice,OTIdentityCard,OTBrokerage,OTTicketType,OTCreateTime,OTRowValid,OTRemark,OTScenicId,OTHaveTicketNumber from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock) where OTId=@OTId");
           return SqlHelper.ExecuteDataTable(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,dbType),sql.ToString(),new SqlParameterWrapper("@OTId",oTId,SqlDbType.Int));
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回表格</returns>
        public DataTable GetOrderTableTable(int oTId)
        {
             return GetOrderTableTable(DataBaseType.Read,oTId);
        }


        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,OrderTableWhereFields where)
        {
              List<OrderTableWhereFields> whereFields = new List<OrderTableWhereFields>();
              whereFields.Add(where);
              return GetOrderTableTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(OrderTableWhereFields where)
        {
            return  GetOrderTableTable(DataBaseType.Read,where);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="where">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableWhereFields where)
        {
              List<OrderTableWhereFields> whereFields = new List<OrderTableWhereFields>();
              whereFields.Add(where);
              return GetOrderTableList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="where">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(OrderTableWhereFields where)
        {
            return GetOrderTableList(DataBaseType.Read,where);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
        {
            List<OrderTableWhereFields> whereFields = new List<OrderTableWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetOrderTableTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(OrderTableWhereFields whereField,OrderTableOrderFields orderField)
        {
             return GetOrderTableTable(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
        {
            List<OrderTableWhereFields> whereFields = new List<OrderTableWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return GetOrderTableList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public static List<OrderTableModel> GetOrderTableListBySql(string sql)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(sqlDescription);
            sqlStr.Append(sql);
            IDataReader reader = SqlHelper.ExecuteReader(DatabaseManager.GetDataBase(DatabaseManager.Db_JQEBookingConfig,DataBaseType.Read),sqlStr.ToString());
            return  GetList(null,reader);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public static List<OrderTableModel> GetOrderTableListBySql(string sql, List<OrderTableWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
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
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(OrderTableWhereFields whereField,OrderTableOrderFields orderField)
        {
            return GetOrderTableList(DataBaseType.Read,whereField,orderField);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
             return GetOrderTableTable(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select " + GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
               return GetOrderTableList(DataBaseType.Read,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
               return GetOrderTableTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
              return GetOrderTableTable(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableWhereFields> whereFields)
        {
               return GetOrderTableList(dbType,null,whereFields,null);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableWhereFields> whereFields)
        {
             return GetOrderTableList(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableWhereFields> whereFields)
        {
               return GetOrderTableTable(dbType,null,whereFields,null);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(List<OrderTableWhereFields> whereFields)
        {
               return GetOrderTableTable(DataBaseType.Read,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType, List<OrderTableOrderFields> orderFields)
        {
               return GetOrderTableTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(List<OrderTableOrderFields> orderFields)
        {
             return GetOrderTableTable(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType, List<OrderTableOrderFields> orderFields)
        {
               return GetOrderTableList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableOrderFields> orderFields)
        {
              return GetOrderTableList(DataBaseType.Read,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
               return GetOrderTableList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
              return  GetOrderTableList(DataBaseType.Read,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public int GetCount(DataBaseType dbType, List<OrderTableWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetTopOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select count(*) from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
       /// <returns>返回OrderTable表格</returns>
        public int GetCount(List<OrderTableWhereFields> whereFields)
        {
             return GetCount(DataBaseType.Read,whereFields);
        }

        /// <summary>
        ///  获取对象
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showField">字段</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public object GetObject(DataBaseType dbType, OrderTableFields showField, List<OrderTableWhereFields> whereFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetTopOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select "+ showField.ToString()+" from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
       /// <returns>返回OrderTable表格</returns>
        public object GetObject(OrderTableFields showField, List<OrderTableWhereFields> whereFields)
        {
            return GetObject(DataBaseType.Read,showField,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetTopOrderTableTable(DataBaseType dbType,int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetTopOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetTopOrderTableTable(int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
             return GetTopOrderTableTable(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetTopOrderTableList(DataBaseType dbType,int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表查询操作/File:OrderTableAccess.cs/Fun:GetTopOrderTableList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append("select top " + topNumber.ToString()+ " "+ GetShowFields(showFields) + " from ["+ DatabaseManager.Db_JQEBookingDataBase+"].[dbo].[OrderTable] with(nolock)");
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
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetTopOrderTableList(int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
             return GetTopOrderTableList(DataBaseType.Read,topNumber,showFields,whereFields,orderFields);
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
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表分页查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableList*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("OrderTable", "OTId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
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
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetOrderTableList(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
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
        public DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
           string sqlDescription = "/*" + DatabaseManager.SqlDescription + "/Author:TCSmartFrameWork自动生成/For:OrderTable表分页查询操作/File:OrderTableAccess.cs/Fun:GetOrderTableTable*/";
            StringBuilder sql = new StringBuilder();
            sql.Append(sqlDescription);
            sql.Append(PageSplitQuery.GetPageSplitSql2005("OrderTable", "OTId", GetShowFields(showFields), string.Empty, GetSqlString(null, whereFields), GetOrderFields(orderFields), pageSize, pageIndex));
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
        public DataTable GetOrderTableTable(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex)
        {
             return GetOrderTableTable(DataBaseType.Read,showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// 获取SQL语句
        /// </summary>
        /// <param name="fieldsList">字段值对</param>
        /// <returns>返回SQL语句</returns>
        public string GetInsertSql(List<OrderTableFieldValuePair> fieldsList)
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

            return "insert [JQEBooking].[dbo].[OrderTable] (" + fields.ToString() + ") values(" + values.ToString() + ")";
         }

        /// <summary>
        /// 获取显示字段
        /// </summary>
        /// <param name="showFieldsList">显示字段列表</param>
        /// <returns>返回显示字段</returns>
        public string GetShowFields(List<OrderTableFields> showFieldsList)
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
        public string GetOrderFields(List<OrderTableOrderFields> orderList)
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
        public static string GetSqlString(List<OrderTableFieldValuePair> updates, List<OrderTableWhereFields> where)
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
        public static void SetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, OrderTableFields field, string fieldVariable, object fieldValue)
        {
            switch ( field )
            {
                case OrderTableFields.OTId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case OrderTableFields.OTOrderSerialNo:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTOrderComfirmNo:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTOrderCreateTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case OrderTableFields.OTTravelTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case OrderTableFields.OTOrderPhone:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTOrderName:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTTicketPhone:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTTicketName:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTTicketNumber:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

                case OrderTableFields.OTOrderState:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case OrderTableFields.OTPayWay:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case OrderTableFields.OTTicketPrice:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Money));
                    break;

                case OrderTableFields.OTIdentityCard:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTBrokerage:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Money));
                    break;

                case OrderTableFields.OTTicketType:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTCreateTime:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.DateTime));
                    break;

                case OrderTableFields.OTRowValid:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.TinyInt));
                    break;

                case OrderTableFields.OTRemark:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTScenicId:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.NVarChar));
                    break;

                case OrderTableFields.OTHaveTicketNumber:
                    collection.Add(new SqlParameterWrapper("@" + fieldVariable, fieldValue, SqlDbType.Int));
                    break;

            }
        }

        /// <summary>
        /// 获取SqlParameterWrapperCollection
        /// </summary>
        /// <param name="collection">SqlParameterWrapperCollection</param>
        /// <param name="updates">更新列表</param>
        /// <param name="where">条件列表</param>
        public static  void GetSqlParameterWrapperCollection(SqlParameterWrapperCollection collection, List<OrderTableFieldValuePair> updates, List<OrderTableWhereFields> where)
        {
            if ( updates != null && updates.Count > 0 )
            {
                foreach ( OrderTableFieldValuePair values in updates )
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
      public static string IsWhereField(List<OrderTableWhereFields> where, int index)
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
        public static  bool IsExistField(List<OrderTableFieldValuePair> list, OrderTableFields field)
        {
            foreach ( OrderTableFieldValuePair f in list )
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
        public static bool IsExistField(List<OrderTableFields> list, OrderTableFields field)
        {
            foreach ( OrderTableFields f in list )
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
        /// <returns>返回OrderTable实体列表</returns>
        public static  List<OrderTableModel> GetList(List<OrderTableFields> showFields, IDataReader reader)
        {
            List< OrderTableModel> list = new List< OrderTableModel>();
            while ( reader.Read() )
            {
                 OrderTableModel ordertable= new OrderTableModel();
                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTId)) && reader["OTId"] !=DBNull.Value)
                {
                   ordertable.OTId = Convert.ToInt32(reader["OTId"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderSerialNo)) && reader["OTOrderSerialNo"] !=DBNull.Value)
                {
                   ordertable.OTOrderSerialNo = reader["OTOrderSerialNo"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderComfirmNo)) && reader["OTOrderComfirmNo"] !=DBNull.Value)
                {
                   ordertable.OTOrderComfirmNo = reader["OTOrderComfirmNo"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderCreateTime)) && reader["OTOrderCreateTime"] !=DBNull.Value)
                {
                   ordertable.OTOrderCreateTime = Convert.ToDateTime(reader["OTOrderCreateTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTravelTime)) && reader["OTTravelTime"] !=DBNull.Value)
                {
                   ordertable.OTTravelTime = Convert.ToDateTime(reader["OTTravelTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderPhone)) && reader["OTOrderPhone"] !=DBNull.Value)
                {
                   ordertable.OTOrderPhone = reader["OTOrderPhone"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderName)) && reader["OTOrderName"] !=DBNull.Value)
                {
                   ordertable.OTOrderName = reader["OTOrderName"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTicketPhone)) && reader["OTTicketPhone"] !=DBNull.Value)
                {
                   ordertable.OTTicketPhone = reader["OTTicketPhone"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTicketName)) && reader["OTTicketName"] !=DBNull.Value)
                {
                   ordertable.OTTicketName = reader["OTTicketName"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTicketNumber)) && reader["OTTicketNumber"] !=DBNull.Value)
                {
                   ordertable.OTTicketNumber = Convert.ToInt32(reader["OTTicketNumber"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTOrderState)) && reader["OTOrderState"] !=DBNull.Value)
                {
                   ordertable.OTOrderState = Convert.ToByte(reader["OTOrderState"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTPayWay)) && reader["OTPayWay"] !=DBNull.Value)
                {
                   ordertable.OTPayWay = Convert.ToByte(reader["OTPayWay"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTicketPrice)) && reader["OTTicketPrice"] !=DBNull.Value)
                {
                   ordertable.OTTicketPrice = Convert.ToDecimal(reader["OTTicketPrice"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTIdentityCard)) && reader["OTIdentityCard"] !=DBNull.Value)
                {
                   ordertable.OTIdentityCard = reader["OTIdentityCard"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTBrokerage)) && reader["OTBrokerage"] !=DBNull.Value)
                {
                   ordertable.OTBrokerage = Convert.ToDecimal(reader["OTBrokerage"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTTicketType)) && reader["OTTicketType"] !=DBNull.Value)
                {
                   ordertable.OTTicketType = reader["OTTicketType"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTCreateTime)) && reader["OTCreateTime"] !=DBNull.Value)
                {
                   ordertable.OTCreateTime = Convert.ToDateTime(reader["OTCreateTime"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTRowValid)) && reader["OTRowValid"] !=DBNull.Value)
                {
                   ordertable.OTRowValid = Convert.ToByte(reader["OTRowValid"]);
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTRemark)) && reader["OTRemark"] !=DBNull.Value)
                {
                   ordertable.OTRemark = reader["OTRemark"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTScenicId)) && reader["OTScenicId"] !=DBNull.Value)
                {
                   ordertable.OTScenicId = reader["OTScenicId"].ToString();
                }

                if ( (( showFields == null || showFields.Count == 0 ) || IsExistField(showFields, OrderTableFields.OTHaveTicketNumber)) && reader["OTHaveTicketNumber"] !=DBNull.Value)
                {
                   ordertable.OTHaveTicketNumber = Convert.ToInt32(reader["OTHaveTicketNumber"]);
                }

                  list.Add(ordertable);
            }
            reader.Close();
            return list;
        }
    }
}
