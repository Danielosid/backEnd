using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        
        public string BookName { get; set; }

        public Genre Genre { get; set; }
    }
}
