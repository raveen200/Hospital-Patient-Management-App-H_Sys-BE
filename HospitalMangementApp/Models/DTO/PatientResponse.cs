using HospitalMangementApp.Models.Enums;

namespace HospitalMangementApp.Models.DTO
{
    public class PatientResponse
    {
        public int P_ID { get; set; }
        public string? NIC { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string? PhoneNumber { get; set; }


    }
}
