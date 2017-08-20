using Ninject;
using Ninject.Extensions.ChildKernel;
using S3LabTestWebApi.BL;
using S3LabTestWebApi.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace S3LabTestWebApi.Infrastructure
{
    public class NinjectResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectResolver()
            : this(new StandardKernel())
        {

        }

        public NinjectResolver(IKernel ninjectKernel, bool scope = false)
        {
            kernel = ninjectKernel;
            if (!scope)
            {
                AddBindings(kernel);
            }
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectResolver(AddRequestBindings(new ChildKernel(kernel)), true);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public void Dispose()
        {

        }

        private void AddBindings(IKernel kernel)
        {
            // singleton and transient bindings go here
        }

        private IKernel AddRequestBindings(IKernel kernel)
        {
            kernel.Bind<ITrade>().To<TradeManager>().InSingletonScope();
            kernel.Bind<ILevel>().To<LevelManager>().InSingletonScope();
            kernel.Bind<ILanguage>().To<LanguageManager>().InSingletonScope();
            return kernel;
        }
    }
}