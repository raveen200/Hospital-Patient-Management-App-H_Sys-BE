using HospitalMangementApp.Models;
using HospitalMangementApp.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangementApp.Data
{

    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<PatientDTO> Patients { get; set; }
    }




}
