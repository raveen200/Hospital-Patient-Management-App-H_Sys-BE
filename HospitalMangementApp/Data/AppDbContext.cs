using HospitalMangementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangementApp.Data
{

    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<PatientDTO> Patients { get; set; }
    }




}
