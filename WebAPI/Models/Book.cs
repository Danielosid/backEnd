using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        public string BookName { get; set; }

        public Genre Genre { get; set; }
    }
}
