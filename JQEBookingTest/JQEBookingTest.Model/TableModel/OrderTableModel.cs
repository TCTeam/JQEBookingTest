//-----------------------------------------------------------------------
// <copyright company="同程网" file="OrderTableModel.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：OrderTable表实体
//-----------------------------------------------------------------------
using System;
using System.Text;
using JQEBookingTest.Model.Enum;

namespace JQEBookingTest.Model.TableModel
{
    /// <summary>
    /// OrderTable表实体类
    /// </summary>
    [Serializable]
    public class OrderTableModel
    {

        /// <summary>
        /// 数据库字段：OTId
        /// </summary>
        private int db_oTId= 0;

        /// <summary>
        /// 获取或设置订单表id
        /// </summary>
        public int OTId
        {
           get{ return db_oTId;}
           set{ db_oTId = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderSerialNo
        /// </summary>
        private string db_oTOrderSerialNo="0".ToString();

        /// <summary>
        /// 获取或设置订单流水号
        /// </summary>
        public string OTOrderSerialNo
        {
           get{ return db_oTOrderSerialNo;}
           set{ db_oTOrderSerialNo = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderComfirmNo
        /// </summary>
        private string db_oTOrderComfirmNo="0".ToString();

        /// <summary>
        /// 获取或设置订单确认号
        /// </summary>
        public string OTOrderComfirmNo
        {
           get{ return db_oTOrderComfirmNo;}
           set{ db_oTOrderComfirmNo = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderCreateTime
        /// </summary>
        private DateTime db_oTOrderCreateTime=Convert.ToDateTime("1900-1-1");

        /// <summary>
        /// 获取或设置订单创建时间
        /// </summary>
        public DateTime OTOrderCreateTime
        {
           get{ return db_oTOrderCreateTime;}
           set{ db_oTOrderCreateTime = value;}
        }

        /// <summary>
        /// 数据库字段：OTTravelTime
        /// </summary>
        private DateTime db_oTTravelTime=Convert.ToDateTime("1900-1-1");

        /// <summary>
        /// 获取或设置入园时间
        /// </summary>
        public DateTime OTTravelTime
        {
           get{ return db_oTTravelTime;}
           set{ db_oTTravelTime = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderPhone
        /// </summary>
        private string db_oTOrderPhone= string.Empty;

        /// <summary>
        /// 获取或设置下单人手机号
        /// </summary>
        public string OTOrderPhone
        {
           get{ return db_oTOrderPhone;}
           set{ db_oTOrderPhone = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderName
        /// </summary>
        private string db_oTOrderName= string.Empty;

        /// <summary>
        /// 获取或设置下单人姓名
        /// </summary>
        public string OTOrderName
        {
           get{ return db_oTOrderName;}
           set{ db_oTOrderName = value;}
        }

        /// <summary>
        /// 数据库字段：OTTicketPhone
        /// </summary>
        private string db_oTTicketPhone= string.Empty;

        /// <summary>
        /// 获取或设置取票人手机号
        /// </summary>
        public string OTTicketPhone
        {
           get{ return db_oTTicketPhone;}
           set{ db_oTTicketPhone = value;}
        }

        /// <summary>
        /// 数据库字段：OTTicketName
        /// </summary>
        private string db_oTTicketName= string.Empty;

        /// <summary>
        /// 获取或设置取票人姓名
        /// </summary>
        public string OTTicketName
        {
           get{ return db_oTTicketName;}
           set{ db_oTTicketName = value;}
        }

        /// <summary>
        /// 数据库字段：OTTicketNumber
        /// </summary>
        private int db_oTTicketNumber= 0;

        /// <summary>
        /// 获取或设置票数
        /// </summary>
        public int OTTicketNumber
        {
           get{ return db_oTTicketNumber;}
           set{ db_oTTicketNumber = value;}
        }

        /// <summary>
        /// 数据库字段：OTOrderState
        /// </summary>
        private byte db_oTOrderState=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置订单状态(0:noshow;1:新订单；2：已核单；3：景区确认)
        /// </summary>
        public byte OTOrderState
        {
           get{ return db_oTOrderState;}
           set{ db_oTOrderState = value;}
        }

        /// <summary>
        /// 数据库字段：OTPayWay
        /// </summary>
        private byte db_oTPayWay=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置支付方式(0：景区到付；1：在线支付)
        /// </summary>
        public byte OTPayWay
        {
           get{ return db_oTPayWay;}
           set{ db_oTPayWay = value;}
        }

        /// <summary>
        /// 数据库字段：OTTicketPrice
        /// </summary>
        private decimal db_oTTicketPrice=Convert.ToDecimal("0");

        /// <summary>
        /// 获取或设置门票单价
        /// </summary>
        public decimal OTTicketPrice
        {
           get{ return db_oTTicketPrice;}
           set{ db_oTTicketPrice = value;}
        }

        /// <summary>
        /// 数据库字段：OTIdentityCard
        /// </summary>
        private string db_oTIdentityCard= string.Empty;

        /// <summary>
        /// 获取或设置取票人身份证号
        /// </summary>
        public string OTIdentityCard
        {
           get{ return db_oTIdentityCard;}
           set{ db_oTIdentityCard = value;}
        }

        /// <summary>
        /// 数据库字段：OTBrokerage
        /// </summary>
        private decimal db_oTBrokerage=Convert.ToDecimal("0");

        /// <summary>
        /// 获取或设置佣金
        /// </summary>
        public decimal OTBrokerage
        {
           get{ return db_oTBrokerage;}
           set{ db_oTBrokerage = value;}
        }

        /// <summary>
        /// 数据库字段：OTTicketTypeId
        /// </summary>
        private string db_oTTicketTypeId= string.Empty;

        /// <summary>
        /// 获取或设置门票类型编号
        /// </summary>
        public string OTTicketTypeId
        {
           get{ return db_oTTicketTypeId;}
           set{ db_oTTicketTypeId = value;}
        }

        /// <summary>
        /// 数据库字段：OTRowValid
        /// </summary>
        private byte db_oTRowValid=Convert.ToByte("1");

        /// <summary>
        /// 获取或设置是否有效(0:无效;1:有效)
        /// </summary>
        public byte OTRowValid
        {
           get{ return db_oTRowValid;}
           set{ db_oTRowValid = value;}
        }

        /// <summary>
        /// 数据库字段：OTRemark
        /// </summary>
        private string db_oTRemark= string.Empty;

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string OTRemark
        {
           get{ return db_oTRemark;}
           set{ db_oTRemark = value;}
        }

        /// <summary>
        /// 数据库字段：OTScenicId
        /// </summary>
        private string db_oTScenicId= string.Empty;

        /// <summary>
        /// 获取或设置景区编号
        /// </summary>
        public string OTScenicId
        {
           get{ return db_oTScenicId;}
           set{ db_oTScenicId = value;}
        }

        /// <summary>
        /// 数据库字段：OTHaveTicketNumber
        /// </summary>
        private int db_oTHaveTicketNumber= 0;

        /// <summary>
        /// 获取或设置已取票数
        /// </summary>
        public int OTHaveTicketNumber
        {
           get{ return db_oTHaveTicketNumber;}
           set{ db_oTHaveTicketNumber = value;}
        }
    }
       
    /// <summary>
    /// OrderTable表字段
    /// </summary>
    public enum OrderTableFields
    {
       
        /// <summary>
        /// 订单表id[主键]
        /// </summary>
        OTId,
       
        /// <summary>
        /// 订单流水号[主键]
        /// </summary>
        OTOrderSerialNo,
       
        /// <summary>
        /// 订单确认号
        /// </summary>
        OTOrderComfirmNo,
       
        /// <summary>
        /// 订单创建时间
        /// </summary>
        OTOrderCreateTime,
       
        /// <summary>
        /// 入园时间
        /// </summary>
        OTTravelTime,
       
        /// <summary>
        /// 下单人手机号
        /// </summary>
        OTOrderPhone,
       
        /// <summary>
        /// 下单人姓名
        /// </summary>
        OTOrderName,
       
        /// <summary>
        /// 取票人手机号
        /// </summary>
        OTTicketPhone,
       
        /// <summary>
        /// 取票人姓名
        /// </summary>
        OTTicketName,
       
        /// <summary>
        /// 票数
        /// </summary>
        OTTicketNumber,
       
        /// <summary>
        /// 订单状态(0:noshow;1:新订单；2：已核单；3：景区确认)
        /// </summary>
        OTOrderState,
       
        /// <summary>
        /// 支付方式(0：景区到付；1：在线支付)
        /// </summary>
        OTPayWay,
       
        /// <summary>
        /// 门票单价
        /// </summary>
        OTTicketPrice,
       
        /// <summary>
        /// 取票人身份证号
        /// </summary>
        OTIdentityCard,
       
        /// <summary>
        /// 佣金
        /// </summary>
        OTBrokerage,
       
        /// <summary>
        /// 门票类型编号
        /// </summary>
        OTTicketTypeId,
       
        /// <summary>
        /// 是否有效(0:无效;1:有效)
        /// </summary>
        OTRowValid,
       
        /// <summary>
        /// 备注
        /// </summary>
        OTRemark,
       
        /// <summary>
        /// 景区编号
        /// </summary>
        OTScenicId,
       
        /// <summary>
        /// 已取票数
        /// </summary>
        OTHaveTicketNumber,
    }
     
     
    /// <summary>
    /// OrderTable排序字段
    /// </summary> 
    public class OrderTableOrderFields
    {
        /// <summary>
        ///OrderTable字段
        /// </summary>
        private OrderTableFields field;
     
        /// <summary>
        ///排序类型
        /// </summary>
        private OrderType order;
     
        /// <summary>
        ///OrderTable排序字段
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        public OrderTableOrderFields(OrderTableFields field)
        {
            this.field = field;
            this.order = OrderType.Asc;
        }
     
        /// <summary>
        ///OrderTable排序字段
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        /// <param name="order">排序类型</param>
        public OrderTableOrderFields(OrderTableFields field, OrderType order)
        {
            this.field = field;
            this.order = order;
        }
     
        /// <summary>
        ///OrderTable字段
        /// </summary>
        public OrderTableFields Field
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
    /// OrderTable字段值
    /// </summary> 
    public class OrderTableFieldValuePair
    {
        /// <summary>
        ///OrderTable字段
        /// </summary>
        private OrderTableFields field;
     
        /// <summary>
        ///字段值
        /// </summary>
        private object fieldValue;
     
        /// <summary>
        ///OrderTable字段值
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        /// <param name="fieldValue">字段值</param>
        public OrderTableFieldValuePair(OrderTableFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
        }
     
        /// <summary>
        ///OrderTable字段
        /// </summary>
        public OrderTableFields Field
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
    /// OrderTable条件字段
    /// </summary> 
    public class OrderTableWhereFields
    {
        /// <summary>
        ///OrderTable字段
        /// </summary>
        private OrderTableFields field;
     
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
        ///OrderTable字段值
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        /// <param name="fieldValue">字段值</param>
        public OrderTableWhereFields(OrderTableFields field,object fieldValue)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = QueryCondition.Equal;
        }
     
        /// <summary>
        ///OrderTable字段值
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryCondition">条件操作类型</param>
        public OrderTableWhereFields(OrderTableFields field,object fieldValue, QueryCondition queryCondition)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = QueryOperator.And;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///OrderTable字段值
        /// </summary>
        /// <param name="field">OrderTable字段</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="queryOperator">条件操作类型</param>
        /// <param name="queryCondition">条件关系</param>
        public OrderTableWhereFields(OrderTableFields field,object fieldValue, QueryCondition queryCondition,QueryOperator queryOperator)
        {
            this.field = field;
            this.fieldValue = fieldValue;
            this.queryOperator = queryOperator;
            this.queryCondition = queryCondition;
        }
     
        /// <summary>
        ///OrderTable字段
        /// </summary>
        public OrderTableFields Field
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
