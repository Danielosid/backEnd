using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Client : IEntity
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public Contact Contact { get; set; }
    }
}
