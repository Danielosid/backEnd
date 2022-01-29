using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data.EFCore
{
    public class EfCoreBookRepository : EfCoreRepository<Book, WebAPIContext>
    {
        public EfCoreBookRepository(WebAPIContext context) : base(context)
        {

        }
    }
}
