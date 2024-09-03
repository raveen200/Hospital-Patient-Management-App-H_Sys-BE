using HospitalMangementApp.Models.Enums;

namespace HospitalMangementApp.Models.DTO
{
    public class PatientDTO
    {
        public int P_ID { get; set; }
        public int? NIC { get; set; }
        public string? Name { get; set; }
        public GenderEnum GenderEnum { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? MedicalDeatils { get; set; }

    }
}
