using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Models
{
    public class EFThanksgivingRepository : IThanksgivingRepository
    {
        private ThanksgivingDBContext _context { get; set; }
        public EFThanksgivingRepository(ThanksgivingDBContext temp)
        {
            _context = temp;
        }
        public IQueryable<foods> foods => _context.foods;
    }
}
