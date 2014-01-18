//-----------------------------------------------------------------------
// <copyright company="同程网" file="RemarkModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Remark表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// Remark表实体类
    /// </summary>
    [Serializable]
    public class RemarkModel
    {

        /// <summary>
        /// 数据库字段：RId
        /// </summary>
        private int db_rId= 0;

        /// <summary>
        /// 获取或设置点评表ID
        /// </summary>
        public int RId
        {
           get{ return db_rId;}
           set{ db_rId = value;}
        }

        /// <summary>
        /// 数据库字段：ROrderSerialNo
        /// </summary>
        private string db_rOrderSerialNo= string.Empty;

        /// <summary>
        /// 获取或设置订单流水号
        /// </summary>
        public string ROrderSerialNo
        {
           get{ return db_rOrderSerialNo;}
           set{ db_rOrderSerialNo = value;}
        }

        /// <summary>
        /// 数据库字段：RRemarkType
        /// </summary>
        private byte db_rRemarkType=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置点评类型(1:好评;2:中评;3:差评)
        /// </summary>
        public byte RRemarkType
        {
           get{ return db_rRemarkType;}
           set{ db_rRemarkType = value;}
        }

        /// <summary>
        /// 数据库字段：RRemarkContent
        /// </summary>
        private string db_rRemarkContent= string.Empty;

        /// <summary>
        /// 获取或设置点评内容
        /// </summary>
        public string RRemarkContent
        {
           get{ return db_rRemarkContent;}
           set{ db_rRemarkContent = value;}
        }

        /// <summary>
        /// 数据库字段：RRemarkTime
        /// </summary>
        private DateTime db_rRemarkTime= DateTime.Now;

        /// <summary>
        /// 获取或设置点评时间
        /// </summary>
        public DateTime RRemarkTime
        {
           get{ return db_rRemarkTime;}
           set{ db_rRemarkTime = value;}
        }

        /// <summary>
        /// 数据库字段：RRemarkReply
        /// </summary>
        private string db_rRemarkReply= string.Empty;

        /// <summary>
        /// 获取或设置点评回复
        /// </summary>
        public string RRemarkReply
        {
           get{ return db_rRemarkReply;}
           set{ db_rRemarkReply = value;}
        }

        /// <summary>
        /// 数据库字段：RReplyTime
        /// </summary>
        private DateTime db_rReplyTime= DateTime.Now;

        /// <summary>
        /// 获取或设置回复时间
        /// </summary>
        public DateTime RReplyTime
        {
           get{ return db_rReplyTime;}
           set{ db_rReplyTime = value;}
        }

        /// <summary>
        /// 数据库字段：RRemarkState
        /// </summary>
        private byte db_rRemarkState=Convert.ToByte("0");

        /// <summary>
        /// 获取或设置点评状态（0：未回复；1：已回复）
        /// </summary>
        public byte RRemarkState
        {
           get{ return db_rRemarkState;}
           set{ db_rRemarkState = value;}
        }

        /// <summary>
        /// 数据库字段：RRowValid
        /// </summary>
        private byte db_rRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效（0：无效；1:有效）
        /// </summary>
        public byte RRowValid
        {
           get{ return db_rRowValid;}
           set{ db_rRowValid = value;}
        }
    }
       
    /// <summary>
    /// Remark表字段
    /// </summary>
    public enum RemarkFields
    {
       
        /// <summary>
        /// 点评表ID
        /// </summary>
        RId,
       
        /// <summary>
        /// 订单流水号
        /// </summary>
        ROrderSerialNo,
       
        /// <summary>
        /// 点评类型(1:好评;2:中评;3:差评)
        /// </summary>
        RRemarkType,
       
        /// <summary>
        /// 点评内容
        /// </summary>
        RRemarkContent,
       
        /// <summary>
        /// 点评时间
        /// </summary>
        RRemarkTime,
       
        /// <summary>
        /// 点评回复
        /// </summary>
        RRemarkReply,
       
        /// <summary>
        /// 回复时间
        /// </summary>
        RReplyTime,
       
        /// <summary>
        /// 点评状态（0：未回复；1：已回复）
        /// </summary>
        RRemarkState,
       
        /// <summary>
        /// 是否有效（0：无效；1:有效）
        /// </summary>
        RRowValid,
    }
     
     
    /// <summary>
    /// Remark排序字段
    /// </summary> 
    public class RemarkOrderFields
    {
        /// <summary>
        ///Remark字段
        /// </summary>
        private RemarkFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///Remark排序字段
        /// </summary>
        /// <param name="field">Remark字段</param>
        public RemarkOrderFields(RemarkFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///Remark排序字段
        /// </summary>
        /// <param name="field">Remark字段</param>
        /// <param name="order">排序类型</param>
        public RemarkOrderFields(RemarkFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///Remark字段
        /// </summary>
        public RemarkFields Field
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
    /// Remark字段值
    /// </summary> 
    public class RemarkFieldValuePair
    {
        /// <summary>
        ///Remark字段
        /// </summary>
        private RemarkFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///Remark字段值
        /// </summary>
        /// <param name="field">Remark字段</param>
        /// <param name="fieldValue">字段值</param>
        public RemarkFieldValuePair(RemarkFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///Remark字段
        /// </summary>
        public RemarkFields Field
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
    /// Remark条件字段
    /// </summary> 
    public class RemarkWhereFields
    {
        /// <summary>
        ///Remark字段
        /// </summary>
        private RemarkFields field;
     
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
        ///Remark字段值
        /// </summary>
        /// <param name="field">Remark字段</param>
        /// <param name="fieldValue">字段值</param>
        public RemarkWhereFields(RemarkFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///Remark字段值
        /// </summary>
        /// <param name="field">Remark字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public RemarkWhereFields(RemarkFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Remark字段值
        /// </summary>
        /// <param name="field">Remark字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public RemarkWhereFields(RemarkFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Remark字段
        /// </summary>
        public RemarkFields Field
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
