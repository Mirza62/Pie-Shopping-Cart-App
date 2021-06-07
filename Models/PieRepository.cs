using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _dbContext.Pies.Include(a => a.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _dbContext.Pies.Include(b => b.Category).Where(c => c.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(d => d.PieId == pieId);
        }
    }
}
