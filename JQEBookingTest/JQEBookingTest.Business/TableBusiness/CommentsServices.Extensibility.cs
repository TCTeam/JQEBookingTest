//-----------------------------------------------------------------------
// <copyright company="同程网" file="CommentsServices.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表数据库业务层自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.IBusiness.TableBusiness;

namespace JQEBookingTest.Business.TableBusiness
{
    /// <summary>
    /// Comments表数据库业务层自定义扩展开发
    /// </summary>
    public partial class CommentsServices:ICommentsServices,IDisposable
    {
        /// <summary>
        /// 获取所有评论列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCommentsExtend()
        {
           return this.dataAccess.GetCommentsExtend();
        }
    }
}
