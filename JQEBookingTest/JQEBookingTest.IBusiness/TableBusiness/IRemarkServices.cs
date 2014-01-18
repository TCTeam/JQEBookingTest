//-----------------------------------------------------------------------
// <copyright company="同程网" file="IRemarkServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Remark表业务逻辑操作接口
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
     /// Remark 表业务逻辑操作接口
     /// </summary>
    public partial interface IRemarkServices
    {
         /// <summary>
         ///Remark 添加操作
         /// </summary>
         /// <param name="remark">Remark实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(RemarkModel remark);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<RemarkFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Remark实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<RemarkModel> list);


        /// <summary>
        /// Remark 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<RemarkFieldValuePair> updateFields, List<RemarkWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<RemarkFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(RemarkFieldValuePair updateField, RemarkWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(RemarkFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<RemarkWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(RemarkWhereFields whereFields);

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable();

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(RemarkWhereFields whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(RemarkWhereFields whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetTopRemarkTable(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetTopRemarkList(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetTopRemarkTable(int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetTopRemarkList(int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList( List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(List<RemarkWhereFields> whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList( List<RemarkWhereFields> whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 查询操作
        /// </summary>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        int GetCount(DataBaseType dbType, List<RemarkWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        int GetCount(List<RemarkWhereFields> whereFields);

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetTopRemarkTable(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetTopRemarkList(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetTopRemarkTable(DataBaseType dbType,int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetTopRemarkList(DataBaseType dbType,int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList( DataBaseType dbType,List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,List<RemarkWhereFields> whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType, List<RemarkWhereFields> whereFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        DataTable GetRemarkTable(DataBaseType dbType,List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkOrderFields> orderFields);

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Remark实体列表</returns>
        List<RemarkModel> GetRemarkList(DataBaseType dbType);
    }
}
