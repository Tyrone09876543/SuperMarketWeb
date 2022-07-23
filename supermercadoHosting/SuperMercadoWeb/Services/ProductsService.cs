using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMercadoWeb.Data;
using SuperMercadoWeb.Models;
namespace SuperMercadoWeb.Services
{
    public class ProductsService : IProductsService
    {
        //Add-Migration InitialCreate -Context BlogContext
        private readonly DataContext _context;
        public ProductsService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Productos.FindAsync(id);

            _context.Productos.Remove(product);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Producto> GetProduct(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<IEnumerable<Producto>> GetAllProducts()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<bool> InsertProduct(Producto producto)
        {
            _context.Productos.Add(producto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateProduct(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveProduct(Producto producto)
        {
            if (producto.Id > 0)
            {
                return await UpdateProduct(producto);
            }
            else
            {
                return await InsertProduct(producto);
            }
        }
    }
}
