using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.Interfaces
{
    public interface IResponse
    {
        public int Error { get; set; }
        public string Description { get; set; }
        public object Object { get; set; }
    }
}
