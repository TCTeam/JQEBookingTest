using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using JQEBookingTest.Model;
using JQEBookingTest.Model.TableModel;
using JQEBookingTest.Web;

/// <summary>
/// 数据存储类，主要是条件存储，方便异步访问的条件保存
/// </summary>
public class DefaultData
{
    // 显示选项
    public static List<OrderTableFields> showFields = null;
    public static List<TicketTypeFields> showFields1 = null;

    // 显示条件
    public static List<OrderTableWhereFields> whereFields = null;

    // 结果集
    public static List<OrderTableModel> list = null;
    public static DataTable datatable = null;
    // 排序条件
    public static List<OrderTableOrderFields> order = null;

    // 条件生成选项数据条数
    public static int listCount = 0;

}