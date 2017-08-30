using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using SimpleInjectorSandbox.Controllers;
using SimpleInjectorSandbox.Models;
using SimpleInjectorSandbox.Repositories;
using SimpleInjectorSandbox.Repositories.Interfaces;
using SimpleInjectorSandbox.Services;

namespace SimpleInjectorSandbox.Ioc
{
    public class SimpleInjectorConfig
    {
        public static void Initialize(HttpConfiguration httpConfiguration)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            container.Register<TestRepository>(Lifestyle.Scoped);
            container.Register<AuditTestRepository>(Lifestyle.Scoped);

            var testService = Lifestyle.Scoped.CreateRegistration(
                () => new TestService(container.GetInstance<TestRepository>()), container);

            var auditTestService = Lifestyle.Scoped.CreateRegistration(
                () => new TestService(container.GetInstance<AuditTestRepository>()), container);

            container.RegisterConditional(typeof(TestService), testService, WhenInjectedInto<TestController>);
            container.RegisterConditional(typeof(TestService), auditTestService, WhenInjectedInto<AuditTestController>);

            container.Register<IAuditRepository<TestModel>, AuditRepository<TestModel>>(Lifestyle.Scoped);
            
            httpConfiguration.DependencyResolver = 
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static bool WhenInjectedInto<T>(PredicateContext c) 
            => c.Consumer.ImplementationType == typeof(T);
    }
}