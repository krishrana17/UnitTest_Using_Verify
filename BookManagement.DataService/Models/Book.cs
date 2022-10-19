using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DataService.Models
{
    public class Book
    {
        public Guid Id { get; init; }

        public string BookName { get; init; }

        public string Author { get; init; }

        public string ISBN { get; init; }

        public string Publisher { get; init; }

        public decimal Price { get; init; }
    }
}
