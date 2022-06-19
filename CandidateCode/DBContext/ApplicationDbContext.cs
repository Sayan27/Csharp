using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateCode.Model;
using Microsoft.EntityFrameworkCore;

namespace CandidateCode.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
