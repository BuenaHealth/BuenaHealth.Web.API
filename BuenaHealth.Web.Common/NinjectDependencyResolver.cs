using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;

namespace BuenaHealth.Web.Common
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _container;

        /// <summary>
        /// Default Constructor 
        /// </summary>
        /// <param name="container">Ninject Container</param>
        public NinjectDependencyResolver(IKernel container)
        {
            _container = container;
        }

        public IKernel Container
        {
            get { return _container; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_container != null)
                {
                    _container.Dispose();
                }
            }
        }

        public object GetService(Type serviceType)
        {
            return _container.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }
}
