//-----------------------------------------------------------------------
// <copyright company="同程网" file="JQResourceModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：JQResource表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// JQResource表实体类
    /// </summary>
    [Serializable]
    public class JQResourceModel
    {

        /// <summary>
        /// 数据库字段：JQRId
        /// </summary>
        private int db_jQRId= 0;

        /// <summary>
        /// 获取或设置景区资源表Id
        /// </summary>
        public int JQRId
        {
           get{ return db_jQRId;}
           set{ db_jQRId = value;}
        }

        /// <summary>
        /// 数据库字段：JQRScenicId
        /// </summary>
        private string db_jQRScenicId= string.Empty;

        /// <summary>
        /// 获取或设置景区编号
        /// </summary>
        public string JQRScenicId
        {
           get{ return db_jQRScenicId;}
           set{ db_jQRScenicId = value;}
        }

        /// <summary>
        /// 数据库字段：JQRScenicName
        /// </summary>
        private string db_jQRScenicName= string.Empty;

        /// <summary>
        /// 获取或设置景区名
        /// </summary>
        public string JQRScenicName
        {
           get{ return db_jQRScenicName;}
           set{ db_jQRScenicName = value;}
        }

        /// <summary>
        /// 数据库字段：JQRScenicDecribe
        /// </summary>
        private string db_jQRScenicDecribe= string.Empty;

        /// <summary>
        /// 获取或设置景区介绍
        /// </summary>
        public string JQRScenicDecribe
        {
           get{ return db_jQRScenicDecribe;}
           set{ db_jQRScenicDecribe = value;}
        }

        /// <summary>
        /// 数据库字段：JQRPrincipal
        /// </summary>
        private string db_jQRPrincipal= string.Empty;

        /// <summary>
        /// 获取或设置景区负责人
        /// </summary>
        public string JQRPrincipal
        {
           get{ return db_jQRPrincipal;}
           set{ db_jQRPrincipal = value;}
        }

        /// <summary>
        /// 数据库字段：JQRAddress
        /// </summary>
        private string db_jQRAddress= string.Empty;

        /// <summary>
        /// 获取或设置景区地址
        /// </summary>
        public string JQRAddress
        {
           get{ return db_jQRAddress;}
           set{ db_jQRAddress = value;}
        }

        /// <summary>
        /// 数据库字段：JQRTelephone
        /// </summary>
        private string db_jQRTelephone= string.Empty;

        /// <summary>
        /// 获取或设置景区电话
        /// </summary>
        public string JQRTelephone
        {
           get{ return db_jQRTelephone;}
           set{ db_jQRTelephone = value;}
        }

        /// <summary>
        /// 数据库字段：JQREmail
        /// </summary>
        private string db_jQREmail= string.Empty;

        /// <summary>
        /// 获取或设置景区邮箱
        /// </summary>
        public string JQREmail
        {
           get{ return db_jQREmail;}
           set{ db_jQREmail = value;}
        }

        /// <summary>
        /// 数据库字段：JQRRowValid
        /// </summary>
        private byte db_jQRRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效（0：无效；1：有效）
        /// </summary>
        public byte JQRRowValid
        {
           get{ return db_jQRRowValid;}
           set{ db_jQRRowValid = value;}
        }

        /// <summary>
        /// 数据库字段：JQRCreateTime
        /// </summary>
        private DateTime db_jQRCreateTime= DateTime.Now;

        /// <summary>
        /// 获取或设置记录创建时间
        /// </summary>
        public DateTime JQRCreateTime
        {
           get{ return db_jQRCreateTime;}
           set{ db_jQRCreateTime = value;}
        }
    }
       
    /// <summary>
    /// JQResource表字段
    /// </summary>
    public enum JQResourceFields
    {
       
        /// <summary>
        /// 景区资源表Id[主键]
        /// </summary>
        JQRId,
       
        /// <summary>
        /// 景区编号[主键]
        /// </summary>
        JQRScenicId,
       
        /// <summary>
        /// 景区名[主键]
        /// </summary>
        JQRScenicName,
       
        /// <summary>
        /// 景区介绍
        /// </summary>
        JQRScenicDecribe,
       
        /// <summary>
        /// 景区负责人
        /// </summary>
        JQRPrincipal,
       
        /// <summary>
        /// 景区地址
        /// </summary>
        JQRAddress,
       
        /// <summary>
        /// 景区电话
        /// </summary>
        JQRTelephone,
       
        /// <summary>
        /// 景区邮箱
        /// </summary>
        JQREmail,
       
        /// <summary>
        /// 是否有效（0：无效；1：有效）
        /// </summary>
        JQRRowValid,
       
        /// <summary>
        /// 记录创建时间
        /// </summary>
        JQRCreateTime,
    }
     
     
    /// <summary>
    /// JQResource排序字段
    /// </summary> 
    public class JQResourceOrderFields
    {
        /// <summary>
        ///JQResource字段
        /// </summary>
        private JQResourceFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///JQResource排序字段
        /// </summary>
        /// <param name="field">JQResource字段</param>
        public JQResourceOrderFields(JQResourceFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///JQResource排序字段
        /// </summary>
        /// <param name="field">JQResource字段</param>
        /// <param name="order">排序类型</param>
        public JQResourceOrderFields(JQResourceFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///JQResource字段
        /// </summary>
        public JQResourceFields Field
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
    /// JQResource字段值
    /// </summary> 
    public class JQResourceFieldValuePair
    {
        /// <summary>
        ///JQResource字段
        /// </summary>
        private JQResourceFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///JQResource字段值
        /// </summary>
        /// <param name="field">JQResource字段</param>
        /// <param name="fieldValue">字段值</param>
        public JQResourceFieldValuePair(JQResourceFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///JQResource字段
        /// </summary>
        public JQResourceFields Field
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
    /// JQResource条件字段
    /// </summary> 
    public class JQResourceWhereFields
    {
        /// <summary>
        ///JQResource字段
        /// </summary>
        private JQResourceFields field;
     
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
        ///JQResource字段值
        /// </summary>
        /// <param name="field">JQResource字段</param>
        /// <param name="fieldValue">字段值</param>
        public JQResourceWhereFields(JQResourceFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///JQResource字段值
        /// </summary>
        /// <param name="field">JQResource字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public JQResourceWhereFields(JQResourceFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///JQResource字段值
        /// </summary>
        /// <param name="field">JQResource字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public JQResourceWhereFields(JQResourceFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///JQResource字段
        /// </summary>
        public JQResourceFields Field
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
