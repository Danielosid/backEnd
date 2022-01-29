using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public Book Book { get; set; }

        public Client Client { get; set; }
    }
}
