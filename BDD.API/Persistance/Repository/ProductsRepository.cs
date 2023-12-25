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
    }
}
