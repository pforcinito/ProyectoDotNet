using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Interfaces;

namespace MyServiceWeb.ModelResponse
{
    public class Response : IResponse
    {

        public int Error { get; set; }
        public string Description { get; set; }
        public object Object { get; set; }
    }
}
