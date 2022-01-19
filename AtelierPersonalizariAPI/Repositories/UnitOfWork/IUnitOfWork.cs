using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtelierPersonalizariAPI.Models;
using AtelierPersonalizariAPI.Repositories.GenericRepository;

namespace AtelierPersonalizariAPI.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<ProductTypeProvider> ProductTypeProviderRepository { get; }
        GenericRepository<ProductType> ProductTypeRepository { get; }
        GenericRepository<Product> ProductRepository { get; }
        void Save();
        void Dispose();
    }
}
