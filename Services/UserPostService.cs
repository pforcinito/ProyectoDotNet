using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Interfaces;
using MyServiceWeb.ModelRequest;
using MyServiceWeb.Factories;
using MyServiceWeb.Models;

namespace MyServiceWeb.Services
{
    public class UserPostService : IUserPostService
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

        public Task<IResponse> Edit(UserPost ob)
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse> Get(long id)
        {
            IResponse response;

            try
            {
                var post = await _context.UserPosts.FindAsync(id);
                response = GetResponse.Builder(0, "todo ok", post);
            }
            catch (Exception ex)
            {
                response = GetResponse.Builder(0, "todo mal", ex);
            }

            return response;
        }
        public Task<IResponse> GetAll(long id)
        {
            throw new NotImplementedException();
        }
    }
}
