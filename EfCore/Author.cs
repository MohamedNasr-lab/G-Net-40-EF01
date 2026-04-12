using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{
    internal class Author
    {
        public int Id { get; set; }              
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }

        // One author → many books
        public List<Book> Books { get; set; }
    }
}
