using System;
using EcomApp.DataAccess.Repository.IRepository;
using EcomApp.Models;

namespace EcomApp.DataAccess.Repository
{
        public interface IProductRepository : IRepository<Product>
        {
            void Update(Product obj);
        }
}

