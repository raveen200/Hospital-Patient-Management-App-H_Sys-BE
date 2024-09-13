using HospitalMangementApp.Models;
using HospitalMangementApp.Models.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangementApp.Data
{

    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext (options)
    {
        public DbSet<Patient> Patients { get; set; }
    }

    




}
