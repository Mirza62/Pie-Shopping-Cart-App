using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _dbcontext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _dbcontext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _dbcontext.Categories;
    }
}
