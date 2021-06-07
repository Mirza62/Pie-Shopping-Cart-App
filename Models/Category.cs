using System.Collections.Generic;

namespace BethanysPie.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Pie> Pies { get; set; }
    }
}
