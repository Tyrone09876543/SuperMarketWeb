using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMercadoWeb.Models;
using SuperMercadoWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace SuperMercadoWeb.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly SuperMercadoContext _identitycontext;
        public UserService(DataContext context,SuperMercadoContext superMercadoContext)
        {
            _context = context;
            _identitycontext = superMercadoContext;
        }
        public async Task<bool> DeleteUser(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);

            _context.AspNetUsers.Remove(user);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<AspNetUser> GetUser(int id)
        {
            return await _context.AspNetUsers.FindAsync(id);
        }

        public async Task<IEnumerable<AspNetUser>> GetAllUser()
        {
            return await _context.AspNetUsers.ToListAsync();
        }

        public async Task<bool> UpdateUser(AspNetUser user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRoles()
        {
            return await _identitycontext.AspNetRoles.ToListAsync();
        }

    }
}

