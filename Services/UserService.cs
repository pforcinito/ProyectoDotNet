using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Interfaces;
using MyServiceWeb.Models;
using MyServiceWeb.ModelResponse;
using MyServiceWeb.ModelRequest;
using Microsoft.EntityFrameworkCore;

namespace MyServiceWeb.Services
{
    public class UserService : IService
    {
        private readonly MyABMContext _context;
        public UserService(MyABMContext context)
        {
            _context = context;
        }

        public Task<IResponse> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> DeleteAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse> Edit(Request ob)
        {
            IResponse response;
            User user;

            try
            {
                user = await _context.Users.FindAsync((User)ob.Object);

                user = (User)ob.Object;

                _context.SaveChanges();

                response = GetResponse.Builder(0, "todo ok");

            }
            catch(Exception ex)
            {
                response = GetResponse.Builder(1, "todo mal", ex);
            }

            return response;
        }

        public async Task<IResponse> Get(long id)
        {
            IResponse response;

            try
            {
                var res = await _context.Users.FindAsync(id);
                response = GetResponse.Builder(0, "todo OK", res);
            }
            catch (Exception ex)
            {
                response = GetResponse.Builder(1, "Se rompio todo", ex);
            }

            return response;
        }

        public async Task<IResponse> GetAll(long id)
        {
            IResponse response;
            
            var res = new List<User>();

            try
            {
                res = await _context.Users.ToListAsync();
                response = GetResponse.Builder(0, "Todo ok", res);
                
            }catch(Exception ex)
            {
                response = GetResponse.Builder(1, "Ocurrio un problema en el getAll Users", ex);
            }

            return response;
        }
    }
}
