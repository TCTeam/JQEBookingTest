//-----------------------------------------------------------------------
// <copyright company="同程网" file="ICommentsServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表业务逻辑操作接口
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
     /// Comments 表业务逻辑操作接口
     /// </summary>
    public partial interface ICommentsServices
    {
         /// <summary>
         ///Comments 添加操作
         /// </summary>
         /// <param name="comments">Comments实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(CommentsModel comments);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<CommentsFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Comments实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<CommentsModel> list);


        /// <summary>
        /// Comments 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<CommentsFieldValuePair> updateFields, List<CommentsWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<CommentsFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(CommentsFieldValuePair updateField, CommentsWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(CommentsFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<CommentsWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(CommentsWhereFields whereFields);

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable();

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(CommentsWhereFields whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(CommentsWhereFields whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetTopCommentsTable(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetTopCommentsList(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetTopCommentsTable(int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetTopCommentsList(int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList( List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(List<CommentsWhereFields> whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList( List<CommentsWhereFields> whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 查询操作
        /// </summary>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        int GetCount(DataBaseType dbType, List<CommentsWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        int GetCount(List<CommentsWhereFields> whereFields);

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetTopCommentsTable(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetTopCommentsList(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetTopCommentsTable(DataBaseType dbType,int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetTopCommentsList(DataBaseType dbType,int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList( DataBaseType dbType,List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,List<CommentsWhereFields> whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType, List<CommentsWhereFields> whereFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        DataTable GetCommentsTable(DataBaseType dbType,List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsOrderFields> orderFields);

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Comments实体列表</returns>
        List<CommentsModel> GetCommentsList(DataBaseType dbType);
    }
}
