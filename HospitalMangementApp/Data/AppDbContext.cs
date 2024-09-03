using HospitalMangementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }

    }
}
