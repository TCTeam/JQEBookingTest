//-----------------------------------------------------------------------
// <copyright company="同程网" file="IJQResourceServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：JQResource表业务逻辑操作接口
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
     /// JQResource 表业务逻辑操作接口
     /// </summary>
    public partial interface IJQResourceServices
    {
         /// <summary>
         ///JQResource 添加操作
         /// </summary>
         /// <param name="jqresource">JQResource实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(JQResourceModel jqresource);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<JQResourceFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<JQResourceModel> list);

        /// <summary>
        /// JQResource 添加操作返回主键的编号
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(JQResourceModel jqresource);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(List<JQResourceFieldValuePair> list);

        /// <summary>
        /// JQResource 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// JQResource 根据主键删除操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(int jQRId);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">JQResource主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool DeleteBatch(List<int> list);

        /// <summary>
        /// JQResource修改操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <param name="updateModel">要修改JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(int jQRId,JQResourceModel updateModel);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool UpdateBatch(List<JQResourceModel> list);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<JQResourceFieldValuePair> updateFields, List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<JQResourceFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(JQResourceFieldValuePair updateField, JQResourceWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(JQResourceFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(JQResourceWhereFields whereFields);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable();

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(JQResourceWhereFields whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(JQResourceWhereFields whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetTopJQResourceTable(int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetTopJQResourceList(int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetTopJQResourceTable(int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetTopJQResourceList(int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList( List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList( List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        int GetCount(DataBaseType dbType, List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        int GetCount(List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,JQResourceWhereFields whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceWhereFields whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetTopJQResourceTable(DataBaseType dbType,int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetTopJQResourceList(DataBaseType dbType,int topNumber,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetTopJQResourceTable(DataBaseType dbType,int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetTopJQResourceList(DataBaseType dbType,int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList( DataBaseType dbType,List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType, List<JQResourceWhereFields> whereFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceOrderFields> orderFields);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="jQRId">景区资源表Id</param>
       /// <returns>返回JQResource实体</returns>
        JQResourceModel GetJQResourceList(DataBaseType dbType,int jQRId);

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
        List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex);

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
        DataTable GetJQResourceTable(DataBaseType dbType,List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
       /// <returns>返回JQResource实体列表</returns>
        JQResourceModel GetJQResourceList(int jQRId);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回JQResource实体列表</returns>
        List<JQResourceModel> GetJQResourceList(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回表格</returns>
        DataTable GetJQResourceTable(List<JQResourceFields> showFields, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields, int pageSize, int pageIndex);
    }
}
