using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models; 

namespace WebAPI.Data.EFCore
{
    public class EfCoreContactRepository : EfCoreRepository<Contact, WebAPIContext>
    {
        public EfCoreContactRepository(WebAPIContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
