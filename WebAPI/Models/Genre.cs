using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        public string GenreName { get; set; }
    }
}
