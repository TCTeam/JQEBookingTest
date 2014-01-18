//-----------------------------------------------------------------------
// <copyright company="同程网" file="ITicketTypeServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：TicketType表业务逻辑操作
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
    /// TicketType表业务逻辑操作
    /// </summary>
    public partial class TicketTypeServices : ITicketTypeServices , IDisposable
    {

         /// <summary>
         /// TicketType数据库操作
         /// </summary>
         private TicketTypeAccess dataAccess = null;

         /// <summary>
         /// TicketType操作初始化
         /// </summary>
         public  TicketTypeServices()
         {
             this.dataAccess = new TicketTypeAccess();
         }

        /// <summary>
        /// TicketType操作初始化
        /// </summary>
      /// <param name="dataAccess">TicketType操作类</param>
        public  TicketTypeServices(TicketTypeAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///TicketType 添加操作
        /// </summary>
       /// <param name="tickettype">TicketType实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(TicketTypeModel tickettype)
        {
            return dataAccess.Add(tickettype);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<TicketTypeFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">TicketType实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<TicketTypeModel> list)
        {
            return dataAccess.AddBatch(list);
        }

        /// <summary>
        /// TicketType 删除操作
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
        public bool Update(List<TicketTypeFieldValuePair> updateFields, List<TicketTypeWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<TicketTypeFieldValuePair> updateFields)
        {
             List<TicketTypeWhereFields> whereFields= new List<TicketTypeWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(TicketTypeFieldValuePair updateField, TicketTypeWhereFields whereField)
        {
             List<TicketTypeFieldValuePair> updateFields=new List<TicketTypeFieldValuePair>();
             List<TicketTypeWhereFields> whereFields= new List<TicketTypeWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(TicketTypeFieldValuePair updateField)
        {
             List<TicketTypeFieldValuePair> updateFields=new List<TicketTypeFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<TicketTypeWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(TicketTypeWhereFields whereField)
        {
               List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable()
        {
            return dataAccess.GetTicketTypeTable();
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList()
        {
            return dataAccess.GetTicketTypeList();
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(TicketTypeWhereFields whereFields)
        {
            return dataAccess.GetTicketTypeTable(whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields whereFields)
        {
            return dataAccess.GetTicketTypeList(whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTicketTypeTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTicketTypeList(null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(TicketTypeOrderFields orderField)
        {
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetTicketTypeTable(null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(TicketTypeOrderFields orderField)
        {
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetTicketTypeList(null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable( List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable( List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetTicketTypeTable(whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetTicketTypeList(whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable( List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTopTicketTypeTable(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTopTicketTypeList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopTicketTypeTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopTicketTypeList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public int GetCount(DataBaseType dbType, List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public int GetCount(List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType)
        {
            return dataAccess.GetTicketTypeTable(dbType);
        }

        /// <summary>
        /// TicketType 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType)
        {
            return dataAccess.GetTicketTypeList(dbType);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields whereFields)
        {
            return dataAccess.GetTicketTypeTable(dbType,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields whereFields)
        {
            return dataAccess.GetTicketTypeList(dbType,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTicketTypeTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTicketTypeList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,TicketTypeOrderFields orderField)
        {
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetTicketTypeTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,TicketTypeOrderFields orderField)
        {
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetTicketTypeList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType, List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetTicketTypeTable(dbType,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeWhereFields> whereFields)
        {
            return dataAccess.GetTicketTypeList(dbType,whereFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTicketTypeTable(DataBaseType dbType, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeTable(dbType,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTicketTypeList(DataBaseType dbType,List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTicketTypeList(dbType,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTopTicketTypeTable(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(DataBaseType dbType,int topNumber,List<TicketTypeFields> showFields, List<TicketTypeWhereFields> whereFields, List<TicketTypeOrderFields> orderFields)
        {
            return dataAccess.GetTopTicketTypeList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType表格</returns>
        public DataTable GetTopTicketTypeTable(DataBaseType dbType,int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopTicketTypeTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// TicketType 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回TicketType实体列表</returns>
        public List<TicketTypeModel> GetTopTicketTypeList(DataBaseType dbType,int topNumber,TicketTypeWhereFields whereField,TicketTypeOrderFields orderField)
        {
            List<TicketTypeWhereFields> whereFields = new List<TicketTypeWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<TicketTypeOrderFields> orderFields = new List<TicketTypeOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopTicketTypeList(dbType,topNumber,null,whereFields,orderFields);
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
