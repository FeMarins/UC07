using Microsoft.EntityFrameworkCore;
using System;
using WebApp.API.Models;

namespace WebApp.API.Dbcontext
{
    public class CheckDbContext : DbContext
    {
     public CheckDbContext(DbContextOptions<CheckDbContext> options) : base(options)
        {

        }

        public DbSet<Checklist> checklists { get; set; }

    }
}
