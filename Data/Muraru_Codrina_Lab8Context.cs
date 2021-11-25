using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muraru_Codrina_Lab8.Models;

namespace Muraru_Codrina_Lab8.Data
{
    public class Muraru_Codrina_Lab8Context : DbContext
    {
        public Muraru_Codrina_Lab8Context (DbContextOptions<Muraru_Codrina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Muraru_Codrina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Muraru_Codrina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Muraru_Codrina_Lab8.Models.Category> Category { get; set; }
    }
}
