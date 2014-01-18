//-----------------------------------------------------------------------
// <copyright company="同程网" file="IOrderTableServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表业务逻辑操作接口
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.IBusiness.TableBusiness
{
     /// <summary>
     /// OrderTable 表业务逻辑操作接口
     /// </summary>
    public partial interface IOrderTableServices
    {
         /// <summary>
         ///OrderTable 添加操作
         /// </summary>
         /// <param name="ordertable">OrderTable实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(OrderTableModel ordertable);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<OrderTableFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<OrderTableModel> list);

        /// <summary>
        /// OrderTable 添加操作返回主键的编号
        /// </summary>
        /// <param name="ordertable">OrderTable实体类</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(OrderTableModel ordertable);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(List<OrderTableFieldValuePair> list);

        /// <summary>
        /// OrderTable 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// OrderTable 根据主键删除操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(int oTId);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">OrderTable主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool DeleteBatch(List<int> list);

        /// <summary>
        /// OrderTable修改操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
        /// <param name="updateModel">要修改OrderTable实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(int oTId,OrderTableModel updateModel);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">OrderTable实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool UpdateBatch(List<OrderTableModel> list);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<OrderTableFieldValuePair> updateFields, List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<OrderTableFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(OrderTableFieldValuePair updateField, OrderTableWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(OrderTableFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(OrderTableWhereFields whereFields);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable();

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(OrderTableWhereFields whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(OrderTableWhereFields whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetTopOrderTableTable(int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetTopOrderTableList(int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetTopOrderTableTable(int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetTopOrderTableList(int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList( List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList( List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        int GetCount(DataBaseType dbType, List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        int GetCount(List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,OrderTableWhereFields whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableWhereFields whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetTopOrderTableTable(DataBaseType dbType,int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetTopOrderTableList(DataBaseType dbType,int topNumber,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetTopOrderTableTable(DataBaseType dbType,int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetTopOrderTableList(DataBaseType dbType,int topNumber,OrderTableWhereFields whereField,OrderTableOrderFields orderField);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList( DataBaseType dbType,List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType, List<OrderTableWhereFields> whereFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable表格</returns>
        DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableOrderFields> orderFields);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="oTId">订单表id</param>
       /// <returns>返回OrderTable实体</returns>
        OrderTableModel GetOrderTableList(DataBaseType dbType,int oTId);

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
        List<OrderTableModel> GetOrderTableList(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex);

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
        DataTable GetOrderTableTable(DataBaseType dbType,List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// OrderTable 查询操作
        /// </summary>
        /// <param name="oTId">订单表id</param>
       /// <returns>返回OrderTable实体列表</returns>
        OrderTableModel GetOrderTableList(int oTId);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回OrderTable实体列表</returns>
        List<OrderTableModel> GetOrderTableList(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回表格</returns>
        DataTable GetOrderTableTable(List<OrderTableFields> showFields, List<OrderTableWhereFields> whereFields, List<OrderTableOrderFields> orderFields, int pageSize, int pageIndex);
    }
}
