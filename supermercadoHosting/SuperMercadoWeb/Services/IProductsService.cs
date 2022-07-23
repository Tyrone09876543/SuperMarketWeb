using SuperMercadoWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMercadoWeb.Services
{
    public interface IProductsService
    {
        Task<bool> DeleteProduct(int id);
        Task<IEnumerable<Producto>> GetAllProducts();
        Task<Producto> GetProduct(int id);
        Task<bool> InsertProduct(Producto producto);
        Task<bool> SaveProduct(Producto producto);
        Task<bool> UpdateProduct(Producto producto);
    }
}