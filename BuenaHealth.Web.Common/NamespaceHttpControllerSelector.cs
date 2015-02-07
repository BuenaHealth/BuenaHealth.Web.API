using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace BuenaHealth.Web.Common
{
    public class NamespaceHttpControllerSelector : IHttpControllerSelector
    {
        public HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, HttpControllerDescriptor> GetControllerMapping()
        {
            throw new NotImplementedException();
        }
    }
}
