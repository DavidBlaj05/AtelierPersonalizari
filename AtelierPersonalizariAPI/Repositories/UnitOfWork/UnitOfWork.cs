using System;
using System.Threading.Tasks;
using AtelierPersonalizariAPI.Data;
using AtelierPersonalizariAPI.Models;
using AtelierPersonalizariAPI.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace AtelierPersonalizariAPI.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private AtelierPersonalizariContext _context;
        private GenericRepository<ProductTypeProvider> productTypeProviderRepository;
        private GenericRepository<ProductType> productTypeRepository;
        private GenericRepository<Product> productRepository;

        public UnitOfWork(AtelierPersonalizariContext context)
        {
            _context = context;
        }


        public GenericRepository<ProductTypeProvider> ProductTypeProviderRepository
        {
            get
            {
                if (this.productTypeProviderRepository == null)
                {
                    this.productTypeProviderRepository = new GenericRepository<ProductTypeProvider>(_context);
                }
                return productTypeProviderRepository;
            }
        }

        public GenericRepository<ProductType> ProductTypeRepository
        {
            get
            {
                if (this.productTypeRepository == null)
                {
                    this.productTypeRepository = new GenericRepository<ProductType>(_context);
                }
                return productTypeRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(_context);
                }
                return productRepository;
            }
        }


        // Save
        public bool Save()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
