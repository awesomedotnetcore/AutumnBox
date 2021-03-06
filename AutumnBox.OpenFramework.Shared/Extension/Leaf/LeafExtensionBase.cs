﻿using System;
using System.Collections.Generic;
using AutumnBox.OpenFramework.Extension.Leaf.Attributes;
using AutumnBox.OpenFramework.Extension.Leaf.Internal;
using AutumnBox.OpenFramework.Open;
using AutumnBox.OpenFramework.Open.ProxyKit;

namespace AutumnBox.OpenFramework.Extension.Leaf
{
    /// <summary>
    /// Leaf模块
    /// </summary>
    public abstract class LeafExtensionBase : EmptyExtension, IClassExtension, ILake
    {
        private readonly LeafEntryExecutor executor;
        private readonly LeafPropertyInjector injector;
        private readonly ILake lake;
        private readonly IProxy proxy;

        /// <summary>
        /// 构造函数
        /// </summary>
        public LeafExtensionBase()
        {
            //初始化API注入器
            ApiAllocator apiAllocator = new ApiAllocator(this);

            //注入属性
            injector = new LeafPropertyInjector(this, apiAllocator);
            injector.Inject();

            //构造入口点执行器
            executor = new LeafEntryExecutor(this, apiAllocator);
            var proxy = lake.Get<IProxyBuilder>().CreateProxyOf(this);
            proxy.InjectProperty();
            proxy.Lakes.Add(this);
        }


        /// <summary>
        /// 入口函数,继承者无需关心
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [LDoNotScan]
        public object Main(Dictionary<string, object> data)
        {
            proxy.InvokeMethod("Main", data);
            executor.Execute(data);
            return null;
        }


        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用
        /// <summary>
        /// 析构一个LeafExtension
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }
        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~LeafExtensionBase()
        // {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        /// <summary>
        /// 释放一个LeafExtension
        /// </summary>
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }

        public ILake Register(string id, Func<object> factory)
        {
            throw new NotImplementedException();
        }

        public object Get(string id)
        {
            if (id == ILakeBaseOnTypeExtension.GenerateIdOf(typeof(IClassTextDictionary)))
            {
                return lake.Get<IClassTextReader>().Read(this);
            }
            return null;
        }
        #endregion
    }
}
