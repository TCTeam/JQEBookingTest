//-----------------------------------------------------------------------
// <copyright company="同程网" file="IJQResourceServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：JQResource表业务逻辑操作
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
    /// JQResource表业务逻辑操作
    /// </summary>
    public partial class JQResourceServices : IJQResourceServices , IDisposable
    {

         /// <summary>
         /// JQResource数据库操作
         /// </summary>
         private JQResourceAccess dataAccess = null;

         /// <summary>
         /// JQResource操作初始化
         /// </summary>
         public  JQResourceServices()
         {
             this.dataAccess = new JQResourceAccess();
         }

        /// <summary>
        /// JQResource操作初始化
        /// </summary>
      /// <param name="dataAccess">JQResource操作类</param>
        public  JQResourceServices(JQResourceAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///JQResource 添加操作
        /// </summary>
       /// <param name="jqresource">JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(JQResourceModel jqresource)
        {
            return dataAccess.Add(jqresource);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<JQResourceFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<JQResourceModel> list)
        {
            return dataAccess.AddBatch(list);
        }


        /// <summary>
        /// JQResource 添加操作返回主键的编号
        /// </summary>
        /// <param name="jqresource">JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(JQResourceModel jqresource)
        {
            return dataAccess.AddByIdentity(jqresource);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回JQResource实体集合</returns>
        public int AddByIdentity(List<JQResourceFieldValuePair> list)
        {
            return dataAccess.AddByIdentity(list);
        }

        /// <summary>
        /// JQResource 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
            return dataAccess.Delete();
        }

        /// <summary>
        /// JQResource 删除操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int jQRId)
        {
            return dataAccess.Delete(jQRId);
        }

        /// <summary>
        /// JQResource修改操作
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <param name="updateModel">要修改JQResource实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int jQRId,JQResourceModel updateModel)
        {
            return dataAccess.Update(jQRId,updateModel);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">JQResource主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
            return dataAccess.DeleteBatch(list);
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">JQResource实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<JQResourceModel> list)
        {
             return dataAccess.UpdateBatch(list);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<JQResourceFieldValuePair> updateFields, List<JQResourceWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<JQResourceFieldValuePair> updateFields)
        {
             List<JQResourceWhereFields> whereFields= new List<JQResourceWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(JQResourceFieldValuePair updateField, JQResourceWhereFields whereField)
        {
             List<JQResourceFieldValuePair> updateFields=new List<JQResourceFieldValuePair>();
             List<JQResourceWhereFields> whereFields= new List<JQResourceWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(JQResourceFieldValuePair updateField)
        {
             List<JQResourceFieldValuePair> updateFields=new List<JQResourceFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<JQResourceWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(JQResourceWhereFields whereField)
        {
               List<JQResourceWhereFields> whereFields = new List<JQResourceWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable()
        {
            return dataAccess.GetJQResourceTable();
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList()
        {
            return dataAccess.GetJQResourceList();
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(JQResourceWhereFields whereFields)
        {
            return dataAccess.GetJQResourceTable(whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(JQResourceWhereFields whereFields)
        {
            return dataAccess.GetJQResourceList(whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetJQResourceTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetJQResourceList(null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(JQResourceOrderFields orderField)
        {
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetJQResourceTable(null,null,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(JQResourceOrderFields orderField)
        {
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetJQResourceList(null,null,orderFields);
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
            return dataAccess.GetJQResourceTable(showFields,whereFields,orderFields);
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
            return dataAccess.GetJQResourceList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable( List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceTable(whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceList(whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable( List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetJQResourceTable(whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetJQResourceList(whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable( List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceTable(orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceList(orderFields);
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
            return dataAccess.GetTopJQResourceTable(topNumber,showFields,whereFields,orderFields);
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
            return dataAccess.GetTopJQResourceList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetTopJQResourceTable(int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetTopJQResourceTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetTopJQResourceList(int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetTopJQResourceList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public int GetCount(DataBaseType dbType, List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public int GetCount(List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType)
        {
            return dataAccess.GetJQResourceTable(dbType);
        }

        /// <summary>
        /// JQResource 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType)
        {
            return dataAccess.GetJQResourceList(dbType);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,JQResourceWhereFields whereFields)
        {
            return dataAccess.GetJQResourceTable(dbType,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceWhereFields whereFields)
        {
            return dataAccess.GetJQResourceList(dbType,whereFields);
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
            return dataAccess.GetJQResourceTable(dbType,null,whereFields,orderFields);
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
            return dataAccess.GetJQResourceList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,JQResourceOrderFields orderField)
        {
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetJQResourceTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,JQResourceOrderFields orderField)
        {
            List<JQResourceOrderFields> orderFields = new List<JQResourceOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetJQResourceList(dbType,null,null,orderFields);
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
            return dataAccess.GetJQResourceTable(dbType,showFields,whereFields,orderFields);
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
            return dataAccess.GetJQResourceList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType, List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceWhereFields> whereFields, List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType, List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetJQResourceTable(dbType,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceWhereFields> whereFields)
        {
            return dataAccess.GetJQResourceList(dbType,whereFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType, List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceTable(dbType,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetJQResourceList(DataBaseType dbType,List<JQResourceOrderFields> orderFields)
        {
            return dataAccess.GetJQResourceList(dbType,orderFields);
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
            return dataAccess.GetTopJQResourceTable(dbType,topNumber,showFields,whereFields,orderFields);
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
            return dataAccess.GetTopJQResourceList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource表格</returns>
        public DataTable GetTopJQResourceTable(DataBaseType dbType,int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetTopJQResourceTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回JQResource实体列表</returns>
        public List<JQResourceModel> GetTopJQResourceList(DataBaseType dbType,int topNumber,JQResourceWhereFields whereField,JQResourceOrderFields orderField)
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
            return dataAccess.GetTopJQResourceList(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回JQResource实体</returns>
        public JQResourceModel GetJQResourceList(int jQRId)
        {
            return dataAccess.GetJQResourceList(jQRId);
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
       /// <param name="jQRId">景区资源表Id</param>
       /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(int jQRId)
        {
            return dataAccess.GetJQResourceTable(jQRId);
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
            return dataAccess.GetJQResourceList(showFields,whereFields,orderFields,pageSize,pageIndex);
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
            return dataAccess.GetJQResourceTable(showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="jQRId">景区资源表Id</param>
        /// <returns>返回JQResource实体</returns>
        public JQResourceModel GetJQResourceList(DataBaseType dbType,int jQRId)
        {
            return dataAccess.GetJQResourceList(dbType,jQRId);
        }

        /// <summary>
        /// JQResource 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <param name="jQRId">景区资源表Id</param>
       /// <returns>返回表格</returns>
        public DataTable GetJQResourceTable(DataBaseType dbType,int jQRId)
        {
            return dataAccess.GetJQResourceTable(dbType,jQRId);
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
            return dataAccess.GetJQResourceList(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
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
            return dataAccess.GetJQResourceTable(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
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
