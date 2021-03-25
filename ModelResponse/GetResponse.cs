using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.ModelResponse
{
    public static class GetResponse
    {
        public static Response Builder(int error, string description, object Object)
        {
            Response response = new Response();
            response.Error = error;
            response.Description = description;
            response.Object = Object;

            return response;
        }

        public static Response Builder(int error, string description)
        {
            Response response = new Response();
            response.Error = error;
            response.Description = description;
            response.Object = null;

            return response;
        }
    }
}
