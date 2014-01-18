//-----------------------------------------------------------------------
// <copyright company="同程网" file="ITicketTypeServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：TicketType表业务逻辑操作接口
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
     /// TicketType 表业务逻辑操作接口
     /// </summary>
    public partial interface ITicketTypeServices
    {
         /// <summary>
         ///TicketType 添加操作
         /// </summary>
         /// <param name="tickettype">TicketType实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(TicketTypeModel tickettype);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<TicketTypeFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">TicketType实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<TicketTypeModel> list);


        /// <summary>
        /// TicketType 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<TicketTypeFieldValuePair> updateFields, List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<TicketTypeFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(TicketTypeFieldValuePair updateField, TicketTypeWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(TicketTypeFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(TicketTypeWhereFields whereFields);

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable();

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(TicketTypeWhereFields whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTopTicketTypeTable(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTopTicketTypeList(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTopTicketTypeTable(int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTopTicketTypeList(int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList( List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList( List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        int GetCount(DataBaseType dbType, List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        int GetCount(List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTopTicketTypeTable(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTopTicketTypeList(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTopTicketTypeTable(DataBaseType dbType,int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTopTicketTypeList(DataBaseType dbType,int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList( DataBaseType dbType,List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType, List<TicketTypeWhereFields> whereFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeOrderFields> orderFields);

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回TicketType实体列表</returns>
        List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType);
    }
}
