using System;
using EcomApp.Models;

namespace EcomApp.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category obj);
	}
}

