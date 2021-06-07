using BethanysPie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie.ViewModels
{
    public class PiesListViewModels
    {
        public IEnumerable<Pie> Pies { get; set; }

        public string CurrentCategory { get; set; }

    }
}
