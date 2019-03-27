using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviesDbMVC.Models
{
    public class MoviesDbMVCDBContext : DbContext
    {
        public MoviesDbMVCDBContext (DbContextOptions<MoviesDbMVCDBContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesDbMVC.Models.Movie> MovieModel { get; set; }
    }
}
