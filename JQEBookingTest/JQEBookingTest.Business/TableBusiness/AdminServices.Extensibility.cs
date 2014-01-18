//-----------------------------------------------------------------------
// <copyright company="同程网" file="AdminServices.Extensibility.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Admin表数据库业务层自定义扩展开发
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.DataAccess.Tables;
using JQEBookingTest.IBusiness;
using JQEBookingTest.Injector;
using JQEBookingTest.Model.Enum;
using JQEBookingTest.IBusiness.TableBusiness;

namespace JQEBookingTest.Business.TableBusiness
{
    /// <summary>
    /// Admin表数据库业务层自定义扩展开发
    /// 密码验证
    /// </summary>
    public partial class AdminServices
    {
        /// <summary>
        /// 验证用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <returns>景区ID</returns>
        public string CheckLogin(string userName, string userPwd)
        {
            List<AdminFields> show = new List<AdminFields>();
            show.Add(AdminFields.AId);
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            whereFileds.Add(new AdminWhereFields(AdminFields.APassword, userPwd));
            DataTable dt = DependencyInjector.GetInstance<IAdminServices>().GetAdminTable(show, whereFileds, null);
            string result = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                result = Convert.ToString(dt.Rows[0]["AId"]);
            }
            return result; ;
        }

        /// <summary>
        /// 通过用户名检查景区ID
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string GetUserID(string userName)
        {
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            DataTable dt = DependencyInjector.GetInstance<IAdminServices>().GetAdminTable(whereFileds);
            string result = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                result = Convert.ToString(dt.Rows[0]["AId"]);
            }
            return result;
        }
        

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string GetUserMode(string userName)
        {
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            DataTable dt = DependencyInjector.GetInstance<IAdminServices>().GetAdminTable(whereFileds);
            string result = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                result = Convert.ToString(dt.Rows[0]["AUserLimit"]);
            }
            return result;
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="phoNum">用户密码</param>
        /// <returns></returns>
        public bool CheckReset(string userName, string phoNum)
        {
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            whereFileds.Add(new AdminWhereFields(AdminFields.ATelephone, phoNum));
            DataTable dt = DependencyInjector.GetInstance<IAdminServices>().GetAdminTable(whereFileds);
            bool checkB;
            if (dt != null && dt.Rows.Count > 0)
            {
                checkB = true;
            }
            else
            {
                checkB = false;
            }
            return checkB;
        }

        public bool ChangePwd(string userName, string userPwd)
        {
            List<AdminFieldValuePair> updatePwd = new List<AdminFieldValuePair>();
            updatePwd.Add(new AdminFieldValuePair(AdminFields.APassword, userPwd));
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            bool right = DependencyInjector.GetInstance<IAdminServices>().Update(updatePwd, whereFileds);
            return right;
        }

        public bool ResetPwd(string userName)
        {
            List<AdminFieldValuePair> updatePwd = new List<AdminFieldValuePair>();
            updatePwd.Add(new AdminFieldValuePair(AdminFields.APassword, "11111111"));
            List<AdminWhereFields> whereFileds = new List<AdminWhereFields>();
            whereFileds.Add(new AdminWhereFields(AdminFields.AName, userName));
            bool right = DependencyInjector.GetInstance<IAdminServices>().Update(updatePwd, whereFileds);
            return right;
        }
    }

}
