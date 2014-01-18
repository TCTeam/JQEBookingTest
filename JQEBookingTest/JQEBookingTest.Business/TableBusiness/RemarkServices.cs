//-----------------------------------------------------------------------
// <copyright company="同程网" file="IRemarkServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Remark表业务逻辑操作
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
    /// Remark表业务逻辑操作
    /// </summary>
    public partial class RemarkServices : IRemarkServices , IDisposable
    {

         /// <summary>
         /// Remark数据库操作
         /// </summary>
         private RemarkAccess dataAccess = null;

         /// <summary>
         /// Remark操作初始化
         /// </summary>
         public  RemarkServices()
         {
             this.dataAccess = new RemarkAccess();
         }

        /// <summary>
        /// Remark操作初始化
        /// </summary>
      /// <param name="dataAccess">Remark操作类</param>
        public  RemarkServices(RemarkAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///Remark 添加操作
        /// </summary>
       /// <param name="remark">Remark实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(RemarkModel remark)
        {
            return dataAccess.Add(remark);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<RemarkFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Remark实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<RemarkModel> list)
        {
            return dataAccess.AddBatch(list);
        }

        /// <summary>
        /// Remark 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
            return dataAccess.Delete();
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<RemarkFieldValuePair> updateFields, List<RemarkWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<RemarkFieldValuePair> updateFields)
        {
             List<RemarkWhereFields> whereFields= new List<RemarkWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(RemarkFieldValuePair updateField, RemarkWhereFields whereField)
        {
             List<RemarkFieldValuePair> updateFields=new List<RemarkFieldValuePair>();
             List<RemarkWhereFields> whereFields= new List<RemarkWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(RemarkFieldValuePair updateField)
        {
             List<RemarkFieldValuePair> updateFields=new List<RemarkFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<RemarkWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(RemarkWhereFields whereField)
        {
               List<RemarkWhereFields> whereFields = new List<RemarkWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable()
        {
            return dataAccess.GetRemarkTable();
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList()
        {
            return dataAccess.GetRemarkList();
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(RemarkWhereFields whereFields)
        {
            return dataAccess.GetRemarkTable(whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(RemarkWhereFields whereFields)
        {
            return dataAccess.GetRemarkList(whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetRemarkTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetRemarkList(null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(RemarkOrderFields orderField)
        {
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetRemarkTable(null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(RemarkOrderFields orderField)
        {
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetRemarkList(null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable( List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable( List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetRemarkTable(whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetRemarkList(whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable( List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetTopRemarkTable(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetTopRemarkList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopRemarkTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopRemarkList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public int GetCount(DataBaseType dbType, List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public int GetCount(List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType)
        {
            return dataAccess.GetRemarkTable(dbType);
        }

        /// <summary>
        /// Remark 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType)
        {
            return dataAccess.GetRemarkList(dbType);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields whereFields)
        {
            return dataAccess.GetRemarkTable(dbType,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields whereFields)
        {
            return dataAccess.GetRemarkList(dbType,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetRemarkTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetRemarkList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,RemarkOrderFields orderField)
        {
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetRemarkTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,RemarkOrderFields orderField)
        {
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetRemarkList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType, List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetRemarkTable(dbType,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkWhereFields> whereFields)
        {
            return dataAccess.GetRemarkList(dbType,whereFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetRemarkTable(DataBaseType dbType, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkTable(dbType,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetRemarkList(DataBaseType dbType,List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetRemarkList(dbType,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetTopRemarkTable(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(DataBaseType dbType,int topNumber,List<RemarkFields> showFields, List<RemarkWhereFields> whereFields, List<RemarkOrderFields> orderFields)
        {
            return dataAccess.GetTopRemarkList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark表格</returns>
        public DataTable GetTopRemarkTable(DataBaseType dbType,int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopRemarkTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Remark 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Remark实体列表</returns>
        public List<RemarkModel> GetTopRemarkList(DataBaseType dbType,int topNumber,RemarkWhereFields whereField,RemarkOrderFields orderField)
        {
            List<RemarkWhereFields> whereFields = new List<RemarkWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<RemarkOrderFields> orderFields = new List<RemarkOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopRemarkList(dbType,topNumber,null,whereFields,orderFields);
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
