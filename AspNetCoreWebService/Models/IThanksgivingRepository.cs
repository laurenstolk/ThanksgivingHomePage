using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Models
{
    public interface IThanksgivingRepository
    {
        IQueryable<foods> foods { get; }

    }
}
