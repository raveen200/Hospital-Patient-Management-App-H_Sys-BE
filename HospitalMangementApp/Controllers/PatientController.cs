using AutoMapper;
using HospitalMangementApp.Data;
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
        private IMapper _mapper;

        public PatientController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetAllPaitents()
        {
            var PatientsData = await _db.Patients.Select(x => new PatientDTO
            {
                P_ID = x.P_ID,
                NIC = x.NIC,
                Name = x.Name,
                Gender = x.Gender,
                Address = x.Address,

            }
            ).ToListAsync();

            return Ok(PatientsData);

        }






    }
}
