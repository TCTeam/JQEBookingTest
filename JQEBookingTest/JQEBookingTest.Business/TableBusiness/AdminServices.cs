//-----------------------------------------------------------------------
// <copyright company="同程网" file="IAdminServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Admin表业务逻辑操作
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
    /// Admin表业务逻辑操作
    /// </summary>
    public partial class AdminServices : IAdminServices , IDisposable
    {

         /// <summary>
         /// Admin数据库操作
         /// </summary>
         private AdminAccess dataAccess = null;

         /// <summary>
         /// Admin操作初始化
         /// </summary>
         public  AdminServices()
         {
             this.dataAccess = new AdminAccess();
         }

        /// <summary>
        /// Admin操作初始化
        /// </summary>
      /// <param name="dataAccess">Admin操作类</param>
        public  AdminServices(AdminAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///Admin 添加操作
        /// </summary>
       /// <param name="admin">Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(AdminModel admin)
        {
            return dataAccess.Add(admin);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<AdminFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<AdminModel> list)
        {
            return dataAccess.AddBatch(list);
        }


        /// <summary>
        /// Admin 添加操作返回主键的编号
        /// </summary>
        /// <param name="admin">Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public int AddByIdentity(AdminModel admin)
        {
            return dataAccess.AddByIdentity(admin);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>返回Admin实体集合</returns>
        public int AddByIdentity(List<AdminFieldValuePair> list)
        {
            return dataAccess.AddByIdentity(list);
        }

        /// <summary>
        /// Admin 删除操作
        /// </summary>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete()
        {
            return dataAccess.Delete();
        }

        /// <summary>
        /// Admin 删除操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(int aId)
        {
            return dataAccess.Delete(aId);
        }

        /// <summary>
        /// Admin修改操作
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <param name="updateModel">要修改Admin实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(int aId,AdminModel updateModel)
        {
            return dataAccess.Update(aId,updateModel);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">Admin主键实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool DeleteBatch(List<int> list)
        {
            return dataAccess.DeleteBatch(list);
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list">Admin实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool UpdateBatch(List<AdminModel> list)
        {
             return dataAccess.UpdateBatch(list);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<AdminFieldValuePair> updateFields, List<AdminWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<AdminFieldValuePair> updateFields)
        {
             List<AdminWhereFields> whereFields= new List<AdminWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(AdminFieldValuePair updateField, AdminWhereFields whereField)
        {
             List<AdminFieldValuePair> updateFields=new List<AdminFieldValuePair>();
             List<AdminWhereFields> whereFields= new List<AdminWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(AdminFieldValuePair updateField)
        {
             List<AdminFieldValuePair> updateFields=new List<AdminFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<AdminWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(AdminWhereFields whereField)
        {
               List<AdminWhereFields> whereFields = new List<AdminWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable()
        {
            return dataAccess.GetAdminTable();
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList()
        {
            return dataAccess.GetAdminList();
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(AdminWhereFields whereFields)
        {
            return dataAccess.GetAdminTable(whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(AdminWhereFields whereFields)
        {
            return dataAccess.GetAdminList(whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetAdminTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetAdminList(null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(AdminOrderFields orderField)
        {
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetAdminTable(null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(AdminOrderFields orderField)
        {
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetAdminList(null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable( List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable( List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetAdminTable(whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetAdminList(whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable( List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetTopAdminTable(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetTopAdminList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(int topNumber,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopAdminTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(int topNumber,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopAdminList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public int GetCount(DataBaseType dbType, List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public int GetCount(List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType)
        {
            return dataAccess.GetAdminTable(dbType);
        }

        /// <summary>
        /// Admin 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType)
        {
            return dataAccess.GetAdminList(dbType);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields whereFields)
        {
            return dataAccess.GetAdminTable(dbType,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields whereFields)
        {
            return dataAccess.GetAdminList(dbType,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetAdminTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetAdminList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,AdminOrderFields orderField)
        {
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetAdminTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,AdminOrderFields orderField)
        {
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetAdminList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType, List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetAdminTable(dbType,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminWhereFields> whereFields)
        {
            return dataAccess.GetAdminList(dbType,whereFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminTable(dbType,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetAdminList(dbType,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetTopAdminTable(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(DataBaseType dbType,int topNumber,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields)
        {
            return dataAccess.GetTopAdminList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin表格</returns>
        public DataTable GetTopAdminTable(DataBaseType dbType,int topNumber,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopAdminTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetTopAdminList(DataBaseType dbType,int topNumber,AdminWhereFields whereField,AdminOrderFields orderField)
        {
            List<AdminWhereFields> whereFields = new List<AdminWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<AdminOrderFields> orderFields = new List<AdminOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopAdminList(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回Admin实体</returns>
        public AdminModel GetAdminList(int aId)
        {
            return dataAccess.GetAdminList(aId);
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
       /// <param name="aId">景区用户Id</param>
       /// <returns>返回表格</returns>
        public DataTable GetAdminTable(int aId)
        {
            return dataAccess.GetAdminTable(aId);
        }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
        /// <param name="pageSize">页面数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
            return dataAccess.GetAdminList(showFields,whereFields,orderFields,pageSize,pageIndex);
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
        public DataTable GetAdminTable(List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
            return dataAccess.GetAdminTable(showFields,whereFields,orderFields,pageSize,pageIndex);
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="aId">景区用户Id</param>
        /// <returns>返回Admin实体</returns>
        public AdminModel GetAdminList(DataBaseType dbType,int aId)
        {
            return dataAccess.GetAdminList(dbType,aId);
        }

        /// <summary>
        /// Admin 根据主键查询
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <param name="aId">景区用户Id</param>
       /// <returns>返回表格</returns>
        public DataTable GetAdminTable(DataBaseType dbType,int aId)
        {
            return dataAccess.GetAdminTable(dbType,aId);
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
        /// <returns>返回Admin实体列表</returns>
        public List<AdminModel> GetAdminList(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
            return dataAccess.GetAdminList(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
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
        public DataTable GetAdminTable(DataBaseType dbType,List<AdminFields> showFields, List<AdminWhereFields> whereFields, List<AdminOrderFields> orderFields, int pageSize, int pageIndex)
        {
            return dataAccess.GetAdminTable(dbType,showFields,whereFields,orderFields,pageSize,pageIndex);
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
