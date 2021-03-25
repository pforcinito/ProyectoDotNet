using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyServiceWeb.Interfaces;
using MyServiceWeb.Models;
using MyServiceWeb.Factories;
using MyServiceWeb.ModelRequest;
using Microsoft.EntityFrameworkCore;
using MyServiceWeb.Mapper;

namespace MyServiceWeb.Services
{
    public class UserService : IUserService
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

        public async Task<IResponse> Edit(User user)
        {
            IResponse response;

            try
            {
                var Myuser = await _context.Users.FindAsync(user.IdUser);
                UserMapper.Map(Myuser, user);
               
                _context.Entry(Myuser).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                response = GetResponse.Builder(0, "The user was modified successfully");
            }
            catch(Exception ex)
            {
                response = GetResponse.Builder(1, "The user was modified unsuccessfully", ex);
            }

            return response;
        }

        public async Task<IResponse> Get(long id)
        {
            IResponse response;
            id = 5;
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

            try
            {
                var res = await _context.Users.ToListAsync();
                response = GetResponse.Builder(0, "Todo ok", res);
                
            }catch(Exception ex)
            {
                response = GetResponse.Builder(1, "Ocurrio un problema en el getAll Users", ex);
            }

            return response;
        }
    }
}
