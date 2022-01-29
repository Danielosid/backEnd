using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public Contact Contact { get; set; }
    }
}
