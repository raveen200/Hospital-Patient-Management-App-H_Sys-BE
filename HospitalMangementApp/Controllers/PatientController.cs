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
                Status = x.Status,
                PhoneNumber = x.PhoneNumber,
                UpdatedOn = x.UpdatedOn,
                Age = x.Age


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
                PhoneNumber = patient.PhoneNumber,
                UpdatedOn = patient.UpdatedOn,
                Age = patient.Age

            };

            _db.Patients.Add(newPatient);
            await _db.SaveChangesAsync();

            return Ok(newPatient);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PatientRequest>> UpdatePatient(int id, PatientUpdateRequest patient)
        {
            var patientData = await _db.Patients.FirstOrDefaultAsync(x => x.P_ID == id);

            if (patientData == null)
            {
                return NotFound();
            }

            patientData.NIC = patient.NIC;
            patientData.Name = patient.Name;
            patientData.Gender = patient.Gender;
            patientData.Address = patient.Address;
            patientData.PhoneNumber = patient.PhoneNumber;
            patientData.UpdatedOn = patient.UpdatedOn;
            patientData.Age = patient.Age;
            patientData.Status = patient.Status;
            patientData.Email = patient.Email;
            patientData.MedicalDeatils = patient.MedicalDeatils;

            try
            {
                await _db.SaveChangesAsync();

                return Ok(patientData);

            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }



        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePatient(int id)
        {
            var patientData = await _db.Patients.FirstOrDefaultAsync(x => x.P_ID == id);

            if (patientData == null)
            {
                return NotFound();
            }

            _db.Patients.Remove(patientData);
            await _db.SaveChangesAsync();

            return Ok();
        }














    }
}
