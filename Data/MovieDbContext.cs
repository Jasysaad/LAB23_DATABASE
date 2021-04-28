using LAB23_DATABASE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB23_DATABASE.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext>options):base(options)
        {

        }
    public DbSet<MovieModel> Movies { get; set; }

}
}
