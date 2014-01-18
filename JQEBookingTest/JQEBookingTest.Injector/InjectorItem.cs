//-----------------------------------------------------------------------
// <copyright company="同程网" file="InjectorItem.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：配置文件中接口信息
//-----------------------------------------------------------------------
using System;
using System.Text;

namespace JQEBookingTest.Injector
{
    /// <summary>
    /// 配置文件中接口信息
    /// </summary>
    internal class InjectorItem
    {
        /// <summary>
        /// 接口
        /// </summary>
        public string InterFace { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// 实例类
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// 是否全局方式创建实例
        /// </summary>
        public bool IsGlobal { get; set; }
    }
}
