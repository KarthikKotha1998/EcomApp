using System;
using System.Linq.Expressions;
using EcomApp.DataAccess;
using EcomApp.DataAccess.Data;
using EcomApp.DataAccess.Repository.IRepository;
using EcomApp.Models;

namespace EcomApp.DataAccess.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db; 
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

