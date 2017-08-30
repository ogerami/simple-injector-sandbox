using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;
using SimpleInjectorSandbox.Ioc;

namespace SimpleInjectorSandbox
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.MapHttpAttributeRoutes();
            
            SimpleInjectorConfig.Initialize(httpConfiguration);
            app.UseWebApi(httpConfiguration);
        }
    }
}