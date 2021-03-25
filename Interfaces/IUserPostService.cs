using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Models;

namespace MyServiceWeb.Interfaces
{
    public interface IUserPostService
    {
        public Task<IResponse> Get(long id);
        public Task<IResponse> GetAll(long id);
        public Task<IResponse> Delete(long id);
        public Task<IResponse> Edit(UserPost ob);
    }
}
