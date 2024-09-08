using HospitalMangementApp.Models.Enums;

namespace HospitalMangementApp.Models.DTO
{
    public class PatientDTO
    {
        public int P_ID { get; set; }
        public int? NIC { get; set; }
        public string? Name { get; set; }
        public GenderEnum Gender { get; set; }
        public string? Address { get; set; }
       

    }
}
