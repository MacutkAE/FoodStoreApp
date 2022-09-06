using FoodStoreApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreApp.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(
                DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Category> Category { get; set; }
    }
}
