using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Contact : IEntity
    {
        public int Id { get; set; }

        public string City { get; set; }

    }
}
