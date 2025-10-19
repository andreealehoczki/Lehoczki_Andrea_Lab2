using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lehoczki_Andrea_Lab2.Models;

namespace Lehoczki_Andrea_Lab2.Data
{
    public class Lehoczki_Andrea_Lab2Context : DbContext
    {
        public Lehoczki_Andrea_Lab2Context (DbContextOptions<Lehoczki_Andrea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lehoczki_Andrea_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Lehoczki_Andrea_Lab2.Models.Publisher> Publisher { get; set; } = default!;

    }
}
