using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.ModelResponse;

namespace MyServiceWeb.Factories
{
    public static class GetResponse
    {
        public static Response Builder(int error, string description, object Object)
        {
            Response response = new Response
            {
                Error = error,
                Description = description,
                Object = Object
            };

            return response;
        }

        public static Response Builder(int error, string description)
        {
            Response response = new Response
            {
                Error = error,
                Description = description,
                Object = null
            };

            return response;
        }
    }
}
