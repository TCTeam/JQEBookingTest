//-----------------------------------------------------------------------
// <copyright company="同程网" file="ICommentsServices.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表业务逻辑操作
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
    /// Comments表业务逻辑操作
    /// </summary>
    public partial class CommentsServices : ICommentsServices , IDisposable
    {

         /// <summary>
         /// Comments数据库操作
         /// </summary>
         private CommentsAccess dataAccess = null;

         /// <summary>
         /// Comments操作初始化
         /// </summary>
         public  CommentsServices()
         {
             this.dataAccess = new CommentsAccess();
         }

        /// <summary>
        /// Comments操作初始化
        /// </summary>
      /// <param name="dataAccess">Comments操作类</param>
        public  CommentsServices(CommentsAccess dataAccess)
        {
             this.dataAccess = dataAccess;
        }

        /// <summary>
        ///Comments 添加操作
        /// </summary>
       /// <param name="comments">Comments实体类</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(CommentsModel comments)
        {
            return dataAccess.Add(comments);
        }

        /// <summary>
        /// 自定义添加操作
        /// </summary>
        /// <param name="list">字段值对</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Add(List<CommentsFieldValuePair> list)
        {
            return dataAccess.Add(list);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">Comments实体列表</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool AddBatch(List<CommentsModel> list)
        {
            return dataAccess.AddBatch(list);
        }

        /// <summary>
        /// Comments 删除操作
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
        public bool Update(List<CommentsFieldValuePair> updateFields, List<CommentsWhereFields> whereFields)
        {
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateFields">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(List<CommentsFieldValuePair> updateFields)
        {
             List<CommentsWhereFields> whereFields= new List<CommentsWhereFields>();
              return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <param name="whereField">条件字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(CommentsFieldValuePair updateField, CommentsWhereFields whereField)
        {
             List<CommentsFieldValuePair> updateFields=new List<CommentsFieldValuePair>();
             List<CommentsWhereFields> whereFields= new List<CommentsWhereFields>();
             updateFields.Add(updateField);
             whereFields.Add(whereField);
             return dataAccess.Update(updateFields,whereFields);
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        /// <param name="updateField">更新字段</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Update(CommentsFieldValuePair updateField)
        {
             List<CommentsFieldValuePair> updateFields=new List<CommentsFieldValuePair>();
             updateFields.Add(updateField);
             return dataAccess.Update(updateField,null);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereFields">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(List<CommentsWhereFields> whereFields)
        {
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// 自定义删除
        /// </summary>
        /// <param name="whereField">删除条件</param>
        /// <returns>执行成功返回true,否则为false</returns>
        public bool Delete(CommentsWhereFields whereField)
        {
               List<CommentsWhereFields> whereFields = new List<CommentsWhereFields> ();
               whereFields.Add(whereField);
              return dataAccess.Delete(whereFields);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable()
        {
            return dataAccess.GetCommentsTable();
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList()
        {
            return dataAccess.GetCommentsList();
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(CommentsWhereFields whereFields)
        {
            return dataAccess.GetCommentsTable(whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(CommentsWhereFields whereFields)
        {
            return dataAccess.GetCommentsList(whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetCommentsTable(null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetCommentsList(null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(CommentsOrderFields orderField)
        {
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetCommentsTable(null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(CommentsOrderFields orderField)
        {
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetCommentsList(null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable( List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable( List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCommentsTable(whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCommentsList(whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable( List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetTopCommentsTable(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetTopCommentsList(topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopCommentsTable(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopCommentsList(topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public int GetCount(DataBaseType dbType, List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCount(dbType,whereFields);
        }

        /// <summary>
        /// 查询数量
        /// </summary>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public int GetCount(List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCount(whereFields);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType)
        {
            return dataAccess.GetCommentsTable(dbType);
        }

        /// <summary>
        /// Comments 查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType)
        {
            return dataAccess.GetCommentsList(dbType);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields whereFields)
        {
            return dataAccess.GetCommentsTable(dbType,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields whereFields)
        {
            return dataAccess.GetCommentsList(dbType,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetCommentsTable(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetCommentsList(dbType,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,CommentsOrderFields orderField)
        {
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetCommentsTable(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,CommentsOrderFields orderField)
        {
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            orderFields.Add(orderField);
            return dataAccess.GetCommentsList(dbType,null,null,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(dbType,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(dbType,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType, List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCommentsTable(dbType,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="whereFields">条件字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsWhereFields> whereFields)
        {
            return dataAccess.GetCommentsList(dbType,whereFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetCommentsTable(DataBaseType dbType, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsTable(dbType,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetCommentsList(DataBaseType dbType,List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetCommentsList(dbType,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetTopCommentsTable(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="whereFields">条件字段</param>
        /// <param name="orderFields">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(DataBaseType dbType,int topNumber,List<CommentsFields> showFields, List<CommentsWhereFields> whereFields, List<CommentsOrderFields> orderFields)
        {
            return dataAccess.GetTopCommentsList(dbType,topNumber,showFields,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments表格</returns>
        public DataTable GetTopCommentsTable(DataBaseType dbType,int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopCommentsTable(dbType,topNumber,null,whereFields,orderFields);
        }

        /// <summary>
        /// Comments 自定义查询操作
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="topNumber">Top数量</param>
        /// <param name="whereField">条件字段</param>
        /// <param name="orderField">排序字段</param>
       /// <returns>返回Comments实体列表</returns>
        public List<CommentsModel> GetTopCommentsList(DataBaseType dbType,int topNumber,CommentsWhereFields whereField,CommentsOrderFields orderField)
        {
            List<CommentsWhereFields> whereFields = new List<CommentsWhereFields>();
            if(whereField !=null)
            {
                 whereFields.Add(whereField);
            }
            List<CommentsOrderFields> orderFields = new List<CommentsOrderFields>();
            if(orderField !=null)
            {
                 orderFields.Add(orderField);
            }
            return dataAccess.GetTopCommentsList(dbType,topNumber,null,whereFields,orderFields);
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
