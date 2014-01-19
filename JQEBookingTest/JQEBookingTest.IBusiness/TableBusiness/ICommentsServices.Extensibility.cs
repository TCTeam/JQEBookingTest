//-----------------------------------------------------------------------
// <copyright company="同程网" file="ICommentsServices.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表数据库业务层自定义扩展开发自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;

namespace JQEBookingTest.IBusiness.TableBusiness
{
    /// <summary>
    /// Comments表数据库业务层自定义扩展开发自定义扩展开发
    /// </summary>
    public partial interface ICommentsServices
    {
        /// <summary>
        /// 获取所有评论列表
        /// </summary>
        /// <returns></returns>
        DataTable GetCommentsExtend(List<CommentsWhereFields> whereFields, string scenicId, int pageSize, int pageIndex);

        /// <summary>
        /// 获取某个景区的评论数
        /// </summary>
        /// <param name="whereFields"></param>
        /// <param name="scenicId"></param>
        /// <returns></returns>
        int GetCommentsCount(List<CommentsWhereFields> whereFields, string scenicId);
    }
}
