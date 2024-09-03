using AutoMapper;
using HospitalMangementApp.Data;
using HospitalMangementApp.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMangementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;

        public PatientController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientDTO patientDTO)
        {
            var exisitingPatient = _db.Patients.FirstOrDefault(m => m.NIC == patientDTO.NIC);
            if (exisitingPatient == null)
            {
                return BadRequest();
            }
        }




    }
}
