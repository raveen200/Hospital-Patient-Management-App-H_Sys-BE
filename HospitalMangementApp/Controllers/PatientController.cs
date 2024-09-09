using HospitalMangementApp.Data;
using HospitalMangementApp.Models;
using HospitalMangementApp.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly AppDbContext _db;

        public PatientController(AppDbContext db)
        {
            _db = db;
        }



       [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientResponse>>> GetAllPaitents()
        {
            var PatientsData = await _db.Patients.Select(x => new PatientResponse
            {
                P_ID = x.P_ID,
                NIC = x.NIC,
                Name = x.Name,


            }
            ).ToListAsync();

            return Ok(PatientsData);

        }

        [HttpPost]
        public async Task<ActionResult<PatientRequest>> PostPatient(PatientRequest patient)
        {
            var newPatient = new Patient
            {
                NIC = patient.NIC,
                Name = patient.Name,
                Gender = patient.Gender,
                Address = patient.Address,
            };

            _db.Patients.Add(newPatient);
            await _db.SaveChangesAsync();

            return Ok(newPatient);
        }

        




    }
}
