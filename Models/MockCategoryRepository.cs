using System.Collections.Generic;

namespace BethanysPie.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {Id=1,CategoryName="Fruit Pies",Description="All Fruity Pies"},
                new Category {Id=2,CategoryName="Cheese Cakes",Description="Cheese all the way"},
                new Category {Id=3,CategoryName="Seasonal Pies",Description="Get in mood for a seasonal pie"},
            };
    }
}
