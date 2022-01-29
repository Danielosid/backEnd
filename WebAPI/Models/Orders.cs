using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Orders : IEntity
    {
        public int Id { get; set; }

        public Book Book { get; set; }

        public Client Client { get; set; }
    }
}
