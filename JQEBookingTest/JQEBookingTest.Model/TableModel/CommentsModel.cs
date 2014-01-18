//-----------------------------------------------------------------------
// <copyright company="同程网" file="CommentsModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：Comments表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// Comments表实体类
    /// </summary>
    [Serializable]
    public class CommentsModel
    {

        /// <summary>
        /// 数据库字段：CId
        /// </summary>
        private int db_cId= 0;

        /// <summary>
        /// 获取或设置点评表ID
        /// </summary>
        public int CId
        {
           get{ return db_cId;}
           set{ db_cId = value;}
        }

        /// <summary>
        /// 数据库字段：COrderSerialNo
        /// </summary>
        private string db_cOrderSerialNo= string.Empty;

        /// <summary>
        /// 获取或设置订单流水号
        /// </summary>
        public string COrderSerialNo
        {
           get{ return db_cOrderSerialNo;}
           set{ db_cOrderSerialNo = value;}
        }

        /// <summary>
        /// 数据库字段：CCommentsType
        /// </summary>
        private byte db_cCommentsType=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置点评类型(1:好评;2:中评;3:差评)
        /// </summary>
        public byte CCommentsType
        {
           get{ return db_cCommentsType;}
           set{ db_cCommentsType = value;}
        }

        /// <summary>
        /// 数据库字段：CCommentsContent
        /// </summary>
        private string db_cCommentsContent= string.Empty;

        /// <summary>
        /// 获取或设置点评内容
        /// </summary>
        public string CCommentsContent
        {
           get{ return db_cCommentsContent;}
           set{ db_cCommentsContent = value;}
        }

        /// <summary>
        /// 数据库字段：CCommentsTime
        /// </summary>
        private DateTime db_cCommentsTime= DateTime.Now;

        /// <summary>
        /// 获取或设置点评时间
        /// </summary>
        public DateTime CCommentsTime
        {
           get{ return db_cCommentsTime;}
           set{ db_cCommentsTime = value;}
        }

        /// <summary>
        /// 数据库字段：CCommentsReply
        /// </summary>
        private string db_cCommentsReply= string.Empty;

        /// <summary>
        /// 获取或设置点评回复
        /// </summary>
        public string CCommentsReply
        {
           get{ return db_cCommentsReply;}
           set{ db_cCommentsReply = value;}
        }

        /// <summary>
        /// 数据库字段：CReplyTime
        /// </summary>
        private DateTime db_cReplyTime= DateTime.Now;

        /// <summary>
        /// 获取或设置回复时间
        /// </summary>
        public DateTime CReplyTime
        {
           get{ return db_cReplyTime;}
           set{ db_cReplyTime = value;}
        }

        /// <summary>
        /// 数据库字段：CCommentsState
        /// </summary>
        private byte db_cCommentsState=Convert.ToByte("0");

        /// <summary>
        /// 获取或设置点评状态（0：未回复；1：已回复）
        /// </summary>
        public byte CCommentsState
        {
           get{ return db_cCommentsState;}
           set{ db_cCommentsState = value;}
        }

        /// <summary>
        /// 数据库字段：CRowValid
        /// </summary>
        private byte db_cRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效（0：无效；1:有效）
        /// </summary>
        public byte CRowValid
        {
           get{ return db_cRowValid;}
           set{ db_cRowValid = value;}
        }
    }
       
    /// <summary>
    /// Comments表字段
    /// </summary>
    public enum CommentsFields
    {
       
        /// <summary>
        /// 点评表ID
        /// </summary>
        CId,
       
        /// <summary>
        /// 订单流水号
        /// </summary>
        COrderSerialNo,
       
        /// <summary>
        /// 点评类型(1:好评;2:中评;3:差评)
        /// </summary>
        CCommentsType,
       
        /// <summary>
        /// 点评内容
        /// </summary>
        CCommentsContent,
       
        /// <summary>
        /// 点评时间
        /// </summary>
        CCommentsTime,
       
        /// <summary>
        /// 点评回复
        /// </summary>
        CCommentsReply,
       
        /// <summary>
        /// 回复时间
        /// </summary>
        CReplyTime,
       
        /// <summary>
        /// 点评状态（0：未回复；1：已回复）
        /// </summary>
        CCommentsState,
       
        /// <summary>
        /// 是否有效（0：无效；1:有效）
        /// </summary>
        CRowValid,
    }
     
     
    /// <summary>
    /// Comments排序字段
    /// </summary> 
    public class CommentsOrderFields
    {
        /// <summary>
        ///Comments字段
        /// </summary>
        private CommentsFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///Comments排序字段
        /// </summary>
        /// <param name="field">Comments字段</param>
        public CommentsOrderFields(CommentsFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///Comments排序字段
        /// </summary>
        /// <param name="field">Comments字段</param>
        /// <param name="order">排序类型</param>
        public CommentsOrderFields(CommentsFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///Comments字段
        /// </summary>
        public CommentsFields Field
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
    /// Comments字段值
    /// </summary> 
    public class CommentsFieldValuePair
    {
        /// <summary>
        ///Comments字段
        /// </summary>
        private CommentsFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///Comments字段值
        /// </summary>
        /// <param name="field">Comments字段</param>
        /// <param name="fieldValue">字段值</param>
        public CommentsFieldValuePair(CommentsFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///Comments字段
        /// </summary>
        public CommentsFields Field
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
    /// Comments条件字段
    /// </summary> 
    public class CommentsWhereFields
    {
        /// <summary>
        ///Comments字段
        /// </summary>
        private CommentsFields field;
     
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
        ///Comments字段值
        /// </summary>
        /// <param name="field">Comments字段</param>
        /// <param name="fieldValue">字段值</param>
        public CommentsWhereFields(CommentsFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///Comments字段值
        /// </summary>
        /// <param name="field">Comments字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public CommentsWhereFields(CommentsFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Comments字段值
        /// </summary>
        /// <param name="field">Comments字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public CommentsWhereFields(CommentsFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///Comments字段
        /// </summary>
        public CommentsFields Field
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
