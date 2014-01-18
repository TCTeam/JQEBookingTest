//-----------------------------------------------------------------------
// <copyright company="同程网" file="IAdminServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Admin表业务逻辑操作接口
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
     /// Admin 表业务逻辑操作接口
     /// </summary>
    public partial interface IAdminServices
    {
         /// <summary>
         ///Admin 添加操作
         /// </summary>
         /// <param name="admin">Admin实体类</param>
         /// <returns>执行成功返回true,否则为false</returns>
         bool Add(AdminModel admin);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Add(List<AdminFieldValuePair> list);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
         bool AddBatch(List<AdminModel> list);

        /// <summary>
        /// Admin 添加操作返回主键的编号
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(AdminModel admin);

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回主键值</returns>
        int AddByIdentity(List<AdminFieldValuePair> list);

        /// <summary>
        /// Admin 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
         bool Delete();

        /// <summary>
        /// Admin 根据主键删除操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(int aId);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">Admin主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool DeleteBatch(List<int> list);

        /// <summary>
        /// Admin修改操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <param name="updateModel">要修改Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(int aId,AdminModel updateModel);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool UpdateBatch(List<AdminModel> list);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<AdminFieldValuePair> updateFields, List<AdminWhereFields> whereFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(List<AdminFieldValuePair> updateFields);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(AdminFieldValuePair updateField, AdminWhereFields whereField);

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Update(AdminFieldValuePair updateField);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(List<AdminWhereFields> whereFields);

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        bool Delete(AdminWhereFields whereFields);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable();

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(AdminWhereFields whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(AdminWhereFields whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetTopAdminTable(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetTopAdminList(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetTopAdminTable(int topNumber,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetTopAdminList(int topNumber,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList( List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(List<AdminWhereFields> whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList( List<AdminWhereFields> whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList();

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        int GetCount(DataBaseType dbType, List<AdminWhereFields> whereFields);

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        int GetCount(List<AdminWhereFields> whereFields);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetTopAdminTable(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetTopAdminList(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetTopAdminTable(DataBaseType dbType,int topNumber,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetTopAdminList(DataBaseType dbType,int topNumber,AdminWhereFields whereField,AdminOrderFields orderField);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList( DataBaseType dbType,List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,List<AdminWhereFields> whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType, List<AdminWhereFields> whereFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        DataTable GetAdminTable(DataBaseType dbType,List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminOrderFields> orderFields);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(DataBaseType dbType);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="aId">景区用户Id</param>
       /// <returns>返回Admin实体</returns>
        AdminModel GetAdminList(DataBaseType dbType,int aId);

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
        List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex);

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
        DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
       /// <returns>返回Admin实体列表</returns>
        AdminModel GetAdminList(int aId);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回Admin实体列表</returns>
        List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回表格</returns>
        DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex);
    }
}
