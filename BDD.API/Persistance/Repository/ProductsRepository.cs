using BDD.API.Models;
using BDD.API.Persistance.Abstract;
using BDD.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly BddContext _context;

        public ProductsRepository(BddContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            var result = await _context.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            var result = await  _context.SaveChangesAsync();
            return result;
        }

        public async Task<int> UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            var result = await _context.SaveChangesAsync();
            return result;
        }
    }
}
