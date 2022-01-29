using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Data.EFCore;

namespace WebAPI.Data.EFCore
{
    public class EfCoreClientRepository : EfCoreRepository<Client, WebAPIContext>
    {
        public EfCoreClientRepository(WebAPIContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
