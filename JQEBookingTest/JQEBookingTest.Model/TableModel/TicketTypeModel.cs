//-----------------------------------------------------------------------
// <copyright company="同程网" file="TicketTypeModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：TicketType表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// TicketType表实体类
    /// </summary>
    [Serializable]
    public class TicketTypeModel
    {

        /// <summary>
        /// 数据库字段：TTId
        /// </summary>
        private int db_tTId= 0;

        /// <summary>
        /// 获取或设置门票类型表ID
        /// </summary>
        public int TTId
        {
           get{ return db_tTId;}
           set{ db_tTId = value;}
        }

        /// <summary>
        /// 数据库字段：TTTypeId
        /// </summary>
        private string db_tTTypeId= string.Empty;

        /// <summary>
        /// 获取或设置门票类型编号
        /// </summary>
        public string TTTypeId
        {
           get{ return db_tTTypeId;}
           set{ db_tTTypeId = value;}
        }

        /// <summary>
        /// 数据库字段：TTTypeName
        /// </summary>
        private string db_tTTypeName= string.Empty;

        /// <summary>
        /// 获取或设置门票类型名
        /// </summary>
        public string TTTypeName
        {
           get{ return db_tTTypeName;}
           set{ db_tTTypeName = value;}
        }

        /// <summary>
        /// 数据库字段：TTScenicId
        /// </summary>
        private string db_tTScenicId= string.Empty;

        /// <summary>
        /// 获取或设置类型所对应的景区编号
        /// </summary>
        public string TTScenicId
        {
           get{ return db_tTScenicId;}
           set{ db_tTScenicId = value;}
        }

        /// <summary>
        /// 数据库字段：TTStartTime
        /// </summary>
        private DateTime db_tTStartTime=Convert.ToDateTime("1900-1-1");

        /// <summary>
        /// 获取或设置类型开始时间
        /// </summary>
        public DateTime TTStartTime
        {
           get{ return db_tTStartTime;}
           set{ db_tTStartTime = value;}
        }

        /// <summary>
        /// 数据库字段：TTDeadline
        /// </summary>
        private DateTime db_tTDeadline=Convert.ToDateTime("1900-1-1");

        /// <summary>
        /// 获取或设置类型结束时间
        /// </summary>
        public DateTime TTDeadline
        {
           get{ return db_tTDeadline;}
           set{ db_tTDeadline = value;}
        }

        /// <summary>
        /// 数据库字段：TTRowValid
        /// </summary>
        private byte db_tTRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效(0:无效；1：有效)
        /// </summary>
        public byte TTRowValid
        {
           get{ return db_tTRowValid;}
           set{ db_tTRowValid = value;}
        }

        /// <summary>
        /// 数据库字段：TTCreateTime
        /// </summary>
        private DateTime db_tTCreateTime= DateTime.Now;

        /// <summary>
        /// 获取或设置行创建时间
        /// </summary>
        public DateTime TTCreateTime
        {
           get{ return db_tTCreateTime;}
           set{ db_tTCreateTime = value;}
        }
    }
       
    /// <summary>
    /// TicketType表字段
    /// </summary>
    public enum TicketTypeFields
    {
       
        /// <summary>
        /// 门票类型表ID
        /// </summary>
        TTId,
       
        /// <summary>
        /// 门票类型编号
        /// </summary>
        TTTypeId,
       
        /// <summary>
        /// 门票类型名
        /// </summary>
        TTTypeName,
       
        /// <summary>
        /// 类型所对应的景区编号
        /// </summary>
        TTScenicId,
       
        /// <summary>
        /// 类型开始时间
        /// </summary>
        TTStartTime,
       
        /// <summary>
        /// 类型结束时间
        /// </summary>
        TTDeadline,
       
        /// <summary>
        /// 是否有效(0:无效；1：有效)
        /// </summary>
        TTRowValid,
       
        /// <summary>
        /// 行创建时间
        /// </summary>
        TTCreateTime,
    }
     
     
    /// <summary>
    /// TicketType排序字段
    /// </summary> 
    public class TicketTypeOrderFields
    {
        /// <summary>
        ///TicketType字段
        /// </summary>
        private TicketTypeFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///TicketType排序字段
        /// </summary>
        /// <param name="field">TicketType字段</param>
        public TicketTypeOrderFields(TicketTypeFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///TicketType排序字段
        /// </summary>
        /// <param name="field">TicketType字段</param>
        /// <param name="order">排序类型</param>
        public TicketTypeOrderFields(TicketTypeFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///TicketType字段
        /// </summary>
        public TicketTypeFields Field
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
    /// TicketType字段值
    /// </summary> 
    public class TicketTypeFieldValuePair
    {
        /// <summary>
        ///TicketType字段
        /// </summary>
        private TicketTypeFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///TicketType字段值
        /// </summary>
        /// <param name="field">TicketType字段</param>
        /// <param name="fieldValue">字段值</param>
        public TicketTypeFieldValuePair(TicketTypeFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///TicketType字段
        /// </summary>
        public TicketTypeFields Field
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
    /// TicketType条件字段
    /// </summary> 
    public class TicketTypeWhereFields
    {
        /// <summary>
        ///TicketType字段
        /// </summary>
        private TicketTypeFields field;
     
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
        ///TicketType字段值
        /// </summary>
        /// <param name="field">TicketType字段</param>
        /// <param name="fieldValue">字段值</param>
        public TicketTypeWhereFields(TicketTypeFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///TicketType字段值
        /// </summary>
        /// <param name="field">TicketType字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public TicketTypeWhereFields(TicketTypeFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///TicketType字段值
        /// </summary>
        /// <param name="field">TicketType字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public TicketTypeWhereFields(TicketTypeFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///TicketType字段
        /// </summary>
        public TicketTypeFields Field
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
