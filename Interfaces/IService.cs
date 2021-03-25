using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Models;
using MyServiceWeb.ModelResponse;
using MyServiceWeb.ModelRequest;

namespace MyServiceWeb.Interfaces
{
    public interface IService
    {
        public Task<IResponse> Get(long id);
        public Task<IResponse> GetAll(long id);
        public Task<IResponse> DeleteAll();
        public Task<IResponse> Delete(long id);
        public Task<IResponse> Edit(Request ob);

    }
}
