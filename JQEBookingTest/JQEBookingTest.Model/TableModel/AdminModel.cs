//-----------------------------------------------------------------------
// <copyright company="同程网" file="AdminModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Admin表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// Admin表实体类
    /// </summary>
    [Serializable]
    public class AdminModel
    {

        /// <summary>
        /// 数据库字段：AId
        /// </summary>
        private int db_aId= 0;

        /// <summary>
        /// 获取或设置景区用户Id
        /// </summary>
        public int AId
        {
           get{ return db_aId;}
           set{ db_aId = value;}
        }

        /// <summary>
        /// 数据库字段：AName
        /// </summary>
        private string db_aName= string.Empty;

        /// <summary>
        /// 获取或设置景区用户名
        /// </summary>
        public string AName
        {
           get{ return db_aName;}
           set{ db_aName = value;}
        }

        /// <summary>
        /// 数据库字段：APassword
        /// </summary>
        private string db_aPassword= string.Empty;

        /// <summary>
        /// 获取或设置景区用户密码
        /// </summary>
        public string APassword
        {
           get{ return db_aPassword;}
           set{ db_aPassword = value;}
        }

        /// <summary>
        /// 数据库字段：AEmail
        /// </summary>
        private string db_aEmail= string.Empty;

        /// <summary>
        /// 获取或设置用户邮箱
        /// </summary>
        public string AEmail
        {
           get{ return db_aEmail;}
           set{ db_aEmail = value;}
        }

        /// <summary>
        /// 数据库字段：ATelephone
        /// </summary>
        private string db_aTelephone= string.Empty;

        /// <summary>
        /// 获取或设置用户电话
        /// </summary>
        public string ATelephone
        {
           get{ return db_aTelephone;}
           set{ db_aTelephone = value;}
        }

        /// <summary>
        /// 数据库字段：ARowValid
        /// </summary>
        private byte db_aRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效（0：无效；1：有效）
        /// </summary>
        public byte ARowValid
        {
           get{ return db_aRowValid;}
           set{ db_aRowValid = value;}
        }

        /// <summary>
        /// 数据库字段：ACreateTime
        /// </summary>
        private DateTime db_aCreateTime= DateTime.Now;

        /// <summary>
        /// 获取或设置创建时间
        /// </summary>
        public DateTime ACreateTime
        {
           get{ return db_aCreateTime;}
           set{ db_aCreateTime = value;}
        }

        /// <summary>
        /// 数据库字段：AScenicId
        /// </summary>
        private string db_aScenicId= string.Empty;

        /// <summary>
        /// 获取或设置景区编号
        /// </summary>
        public string AScenicId
        {
           get{ return db_aScenicId;}
           set{ db_aScenicId = value;}
        }

        /// <summary>
        /// 数据库字段：AUserId
        /// </summary>
        private string db_aUserId= string.Empty;

        /// <summary>
        /// 获取或设置用户编号
        /// </summary>
        public string AUserId
        {
           get{ return db_aUserId;}
           set{ db_aUserId = value;}
        }
    }
       
    /// <summary>
    /// Admin表字段
    /// </summary>
    public enum AdminFields
    {
       
        /// <summary>
        /// 景区用户Id[主键]
        /// </summary>
        AId,
       
        /// <summary>
        /// 景区用户名[主键]
        /// </summary>
        AName,
       
        /// <summary>
        /// 景区用户密码
        /// </summary>
        APassword,
       
        /// <summary>
        /// 用户邮箱
        /// </summary>
        AEmail,
       
        /// <summary>
        /// 用户电话
        /// </summary>
        ATelephone,
       
        /// <summary>
        /// 是否有效（0：无效；1：有效）
        /// </summary>
        ARowValid,
       
        /// <summary>
        /// 创建时间
        /// </summary>
        ACreateTime,
       
        /// <summary>
        /// 景区编号
        /// </summary>
        AScenicId,
       
        /// <summary>
        /// 用户编号[主键]
        /// </summary>
        AUserId,
    }
     
     
    /// <summary>
    /// Admin排序字段
    /// </summary> 
    public class AdminOrderFields
    {
        /// <summary>
        ///Admin字段
        /// </summary>
        private AdminFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///Admin排序字段
        /// </summary>
        /// <param name="field">Admin字段</param>
        public AdminOrderFields(AdminFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///Admin排序字段
        /// </summary>
        /// <param name="field">Admin字段</param>
        /// <param name="order">排序类型</param>
        public AdminOrderFields(AdminFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///Admin字段
        /// </summary>
        public AdminFields Field
        {
            get { return this.field; }
        }
     
        /// <summary>
        ///排序类型
        /// </summary>
        public OrderType Order
        {
            get { return this.order; }
        }
    }

     
     
    /// <summary>
    /// Admin字段值
    /// </summary> 
    public class AdminFieldValuePair
    {
        /// <summary>
        ///Admin字段
        /// </summary>
        private AdminFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///Admin字段值
        /// </summary>
        /// <param name="field">Admin字段</param>
        /// <param name="fieldValue">字段值</param>
        public AdminFieldValuePair(AdminFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///Admin字段
        /// </summary>
        public AdminFields Field
        {
            get { return this.field; }
        }
     
        /// <summary>
        ///字段值
        /// </summary>
        public object FieldValue
        {
            get { return this.fieldValue; }
        }
    }

     
     
    /// <summary>
    /// Admin条件字段
    /// </summary> 
    public class AdminWhereFields
    {
        /// <summary>
        ///Admin字段
        /// </summary>
        private AdminFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        /// 条件操作类型
        /// </summary>
        private QueryOperator queryOperator;
     
        /// <summary>
        ///条件关系
        /// </summary>
        private QueryCondition queryCondition;
     
        /// <summary>
        ///Admin字段值
        /// </summary>
        /// <param name="field">Admin字段</param>
        /// <param name="fieldValue">字段值</param>
        public AdminWhereFields(AdminFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///Admin字段值
        /// </summary>
        /// <param name="field">Admin字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public AdminWhereFields(AdminFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Admin字段值
        /// </summary>
        /// <param name="field">Admin字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public AdminWhereFields(AdminFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Admin字段
        /// </summary>
        public AdminFields Field
        {
            get { return this.field; }
        }
     
        /// <summary>
        ///字段值
        /// </summary>
        public object FieldValue
        {
            get { return this.fieldValue; }
        }
     
        /// <summary>
        ///条件操作类型
        /// </summary>
        public QueryOperator Operator
        {
            get { return this.queryOperator; }
        }
     
        /// <summary>
        ///条件关系
        /// </summary>
        public QueryCondition Condition
        {
            get { return this.queryCondition; }
        }
    }

}
