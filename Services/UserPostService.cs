using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Interfaces;
using MyServiceWeb.ModelRequest;
using MyServiceWeb.ModelResponse;
using MyServiceWeb.Models;

namespace MyServiceWeb.Services
{
    public class UserPostService : IService
    {

        private readonly MyABMContext _context;

        public UserPostService(MyABMContext context) => _context = context;

        public Task<IResponse> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> Edit(Request ob)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> GetAll(long id)
        {
            throw new NotImplementedException();
        }
    }
}
