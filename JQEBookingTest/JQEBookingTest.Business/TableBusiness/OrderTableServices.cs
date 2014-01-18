//-----------------------------------------------------------------------
// <copyright company="同程网" file="IOrderTableServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表业务逻辑操作
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.IBusiness.TableBusiness;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Business.TableBusiness
{
    /// <summary>
    /// OrderTable表业务逻辑操作
    /// </summary>
    public partial class OrderTableServices : IOrderTableServices , IDisposable
    {

         /// <summary>
         /// OrderTable数据库操作
         /// </summary>
         private OrderTableAccess dataAccess = null;

         /// <summary>
         /// OrderTable操作初始化
         /// </summary>
         public  OrderTableServices()
         {
             this.dataAccess = new OrderTableAccess();
         }

        /// <summary>
        /// OrderTable操作初始化
        /// </summary>
      /// <param name="dataAccess">OrderTable操作类</param>
        public  OrderTableServices(OrderTableAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///OrderTable 添加操作
        /// </summary>
       /// <param name="ordertable">OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(OrderTableModel ordertable)
        {
            return dataAccess.Add(ordertable);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<OrderTableFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<OrderTableModel> list)
        {
            return dataAccess.AddBatch(list);
        }


        /// <summary>
        /// OrderTable 添加操作返回主键的编号
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(OrderTableModel ordertable)
        {
            return dataAccess.AddByIdentity(ordertable);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回OrderTable实体集合</returns>
        public int AddByIdentity(List<OrderTableFieldValuePair> list)
        {
            return dataAccess.AddByIdentity(list);
        }

        /// <summary>
        /// OrderTable 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
            return dataAccess.Delete();
        }

        /// <summary>
        /// OrderTable 删除操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int oTId)
        {
            return dataAccess.Delete(oTId);
        }

        /// <summary>
        /// OrderTable修改操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <param name="updateModel">要修改OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int oTId,OrderTableModel updateModel)
        {
            return dataAccess.Update(oTId,updateModel);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">OrderTable主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
            return dataAccess.DeleteBatch(list);
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<OrderTableModel> list)
        {
             return dataAccess.UpdateBatch(list);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<OrderTableFieldValuePair> updateFields, List<OrderTableWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<OrderTableFieldValuePair> updateFields)
        {
             List<OrderTableWhereFields> whereFields= new List<OrderTableWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(OrderTableFieldValuePair updateField, OrderTableWhereFields whereField)
        {
             List<OrderTableFieldValuePair> updateFields=new List<OrderTableFieldValuePair>();
             List<OrderTableWhereFields> whereFields= new List<OrderTableWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(OrderTableFieldValuePair updateField)
        {
             List<OrderTableFieldValuePair> updateFields=new List<OrderTableFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<OrderTableWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(OrderTableWhereFields whereField)
        {
               List<OrderTableWhereFields> whereFields = new List<OrderTableWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable()
        {
            return dataAccess.GetOrderTableTable();
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList()
        {
            return dataAccess.GetOrderTableList();
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(OrderTableWhereFields whereFields)
        {
            return dataAccess.GetOrderTableTable(whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(OrderTableWhereFields whereFields)
        {
            return dataAccess.GetOrderTableList(whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetOrderTableTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetOrderTableList(null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(OrderTableOrderFields orderField)
        {
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetOrderTableTable(null,null,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(OrderTableOrderFields orderField)
        {
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetOrderTableList(null,null,orderFields);
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
            return dataAccess.GetOrderTableTable(showFields,whereFields,orderFields);
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
            return dataAccess.GetOrderTableList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable( List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableTable(whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableList(whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable( List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetOrderTableTable(whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetOrderTableList(whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable( List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableTable(orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableList(orderFields);
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
            return dataAccess.GetTopOrderTableTable(topNumber,showFields,whereFields,orderFields);
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
            return dataAccess.GetTopOrderTableList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetTopOrderTableTable(int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetTopOrderTableTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetTopOrderTableList(int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetTopOrderTableList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public int GetCount(DataBaseType dbType, List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public int GetCount(List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType)
        {
            return dataAccess.GetOrderTableTable(dbType);
        }

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType)
        {
            return dataAccess.GetOrderTableList(dbType);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,OrderTableWhereFields whereFields)
        {
            return dataAccess.GetOrderTableTable(dbType,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableWhereFields whereFields)
        {
            return dataAccess.GetOrderTableList(dbType,whereFields);
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
            return dataAccess.GetOrderTableTable(dbType,null,whereFields,orderFields);
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
            return dataAccess.GetOrderTableList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,OrderTableOrderFields orderField)
        {
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetOrderTableTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableOrderFields orderField)
        {
            List<OrderTableOrderFields> orderFields = new List<OrderTableOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetOrderTableList(dbType,null,null,orderFields);
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
            return dataAccess.GetOrderTableTable(dbType,showFields,whereFields,orderFields);
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
            return dataAccess.GetOrderTableList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType, List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetOrderTableTable(dbType,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableWhereFields> whereFields)
        {
            return dataAccess.GetOrderTableList(dbType,whereFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType, List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableTable(dbType,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableOrderFields> orderFields)
        {
            return dataAccess.GetOrderTableList(dbType,orderFields);
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
            return dataAccess.GetTopOrderTableTable(dbType,topNumber,showFields,whereFields,orderFields);
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
            return dataAccess.GetTopOrderTableList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        public DataTable GetTopOrderTableTable(DataBaseType dbType,int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetTopOrderTableTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        public List<OrderTableModel> GetTopOrderTableList(DataBaseType dbType,int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField)
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
            return dataAccess.GetTopOrderTableList(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回OrderTable实体</returns>
        public OrderTableModel GetOrderTableList(int oTId)
        {
            return dataAccess.GetOrderTableList(oTId);
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
       /// <param name="oTId">订单表id</param>
       /// <returns>返回表格</returns>
        public DataTable GetOrderTableTable(int oTId)
        {
            return dataAccess.GetOrderTableTable(oTId);
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
            return dataAccess.GetOrderTableList(showFields,whereFields,orderFields,pageSize,pageIndex);
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
            return dataAccess.GetOrderTableTable(showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="oTId">订单表id</param>
        /// <returns>返回OrderTable实体</returns>
        public OrderTableModel GetOrderTableList(DataBaseType dbType,int oTId)
        {
            return dataAccess.GetOrderTableList(dbType,oTId);
        }

        /// <summary>
        /// OrderTable 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <param name="oTId">订单表id</param>
       /// <returns>返回表格</returns>
        public DataTable GetOrderTableTable(DataBaseType dbType,int oTId)
        {
            return dataAccess.GetOrderTableTable(dbType,oTId);
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
            return dataAccess.GetOrderTableList(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
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
            return dataAccess.GetOrderTableTable(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            this.dataAccess = null;
        }
    }
}
