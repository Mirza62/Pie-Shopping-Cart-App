using System.Collections.Generic;

namespace BethanysPie.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
