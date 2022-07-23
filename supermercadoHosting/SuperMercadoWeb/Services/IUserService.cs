using Microsoft.AspNetCore.Identity;
using SuperMercadoWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMercadoWeb.Services
{
    public interface IUserService
    {
        Task<bool> DeleteUser(string id);
        Task<IEnumerable<AspNetUser>> GetAllUser();
        Task<IEnumerable<IdentityRole>> GetAllRoles();
        Task<AspNetUser> GetUser(int id);
        Task<bool> UpdateUser(AspNetUser user);
    }
}