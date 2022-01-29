using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data.EFCore
{
    public class EfCoreOrderRepository : EfCoreRepository<Orders, WebAPIContext>
    {
        public EfCoreOrderRepository(WebAPIContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
