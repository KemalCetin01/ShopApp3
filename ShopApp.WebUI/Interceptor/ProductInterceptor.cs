using CodeCop.Core;
using CodeCop.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Interceptor
{
    public class ProductInterceptor : ICopIntercept
    {
        public void OnAfterExecute(InterceptionContext context)
        {
            Console.WriteLine("Before {0} ",context.InterceptedMethod.Name);
        }

        public void OnBeforeExecute(InterceptionContext context)
        {
            Console.WriteLine("After {0} ", context.InterceptedMethod.Name);
        }
    }
}
