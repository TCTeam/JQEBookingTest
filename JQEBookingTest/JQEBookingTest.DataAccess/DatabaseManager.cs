//-----------------------------------------------------------------------
// <copyright company="同程网" file="DatabaseManager.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：数据库管理
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;
using TCSmartFramework.DataAccess;

namespace JQEBookingTest.DataAccess
{
    /// <summary>
    /// 数据库管理类
    /// </summary>
    public  class DatabaseManager
    {
         /// <summary>
         /// 数据库JQEBooking的配置
         /// </summary> 
         public const string Db_JQEBookingConfig = "JQEBooking";
         
         /// <summary>
         /// 数据库JQEBooking名称变量
         /// </summary> 
         public const string Db_JQEBookingDataBase = "JQEBooking";
         
         /// <summary>
         /// 数据库SQL说明
         /// </summary> 
         public const string SqlDescription=@"Flat:D:\工作文档\StepThree\JQEBookingTest\JQEBookingTest\JQEBookingTest\";
         

        /// <summary>
        /// 返回数据库操作
        /// </summary>
        /// <param name="databaseName">数据库名称</param>
        /// <param name="dbType">数据库类型</param>
       /// <returns>返回数据库</returns>
        internal static Database GetDataBase(string databaseName,DataBaseType dbType)
        {
             if(dbType == DataBaseType.Write)
             {
                 return  DatabaseFactory.GetWriteDatabase(databaseName);
             }
             return  DatabaseFactory.GetReadDatabase(databaseName); 
        }

    }
}
