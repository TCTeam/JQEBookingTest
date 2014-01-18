//-----------------------------------------------------------------------
// <copyright company="同程网" file="DependencyInjector.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：接口的控制类
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web.Caching;

namespace JQEBookingTest.Injector
{
    /// <summary>
    ///  接口的控制类
    /// </summary>
    public class DependencyInjector
    {
        /// <summary>
        /// 获取接口实例
        /// </summary>
        /// <typeparam name="T">业务接口</typeparam>
        /// <returns>返回配置中中实现类的实例</returns>
        public static T GetInstance<T>()
        {
            string interfacetype = typeof(T).ToString();
            InjectorItem item = InjectorConfigManager.GetInjectorItem(interfacetype);
            if (item != null)
            {
                object obj = CacheInjector.GetFromCache(interfacetype);
                if (obj == null)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\TCBusiness\\" + item.File;
                    obj = (item.IsGlobal ? Assembly.LoadFrom(path).CreateInstance(item.Instance) : Assembly.LoadFrom(path).GetType(item.Instance));
                    CacheInjector.SaveToCache(interfacetype, obj);
                }

                return (item.IsGlobal ? (T)obj : (T)Activator.CreateInstance((Type)obj));
            }

            return default(T);
        }

        /// <summary>
        /// 获取接口实例
        /// </summary>
        /// <typeparam name="T">业务接口</typeparam>
        /// <param name="args">参数集合</param>
        /// <returns>返回配置中中实现类的实例</returns>
        public static T GetInstance<T>(object[] args)
        {
            string interfacetype = typeof(T).ToString();
            InjectorItem item = InjectorConfigManager.GetInjectorItem(interfacetype);
            if (item != null)
            {
                object obj = CacheInjector.GetFromCache(interfacetype);
                if (obj == null)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\TCBusiness\\" + item.File;
                    obj = (item.IsGlobal ? Assembly.LoadFrom(path).CreateInstance(item.Instance, true, BindingFlags.CreateInstance, null, args, null, null) : Assembly.LoadFrom(path).GetType(item.Instance));
                    CacheInjector.SaveToCache(interfacetype, obj);
                }

                return (item.IsGlobal ? (T)obj : (T)Activator.CreateInstance((Type)obj, args));
            }

            return default(T);
        }
    }
}
