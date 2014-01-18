//-----------------------------------------------------------------------
// <copyright company="同程网" file="CacheInjector.cs">
//    Copyright (c)  V1.0
//    作者：TCSmartFrameWork 工具自动生成
//    功能：缓存处理类
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace JQEBookingTest.Injector
{
    /// <summary>
    /// 缓存处理类
    /// </summary>
    internal class CacheInjector
    {
        /// <summary>
        /// 将对象加入到缓存中
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <param name="cacheObject">缓存对象</param>
        public static void SaveToCache(string cacheKey, object cacheObject)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject);
        }

        /// <summary>
        /// 从缓存中取得对象，不存在则返回null
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <returns>获取的缓存对象</returns>
        public static object GetFromCache(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            return cache[cacheKey];
        }

        /// <summary>
        /// 移除缓冲对象
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        public static void RemoveCatche(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Remove(cacheKey);
        }
    }
}
