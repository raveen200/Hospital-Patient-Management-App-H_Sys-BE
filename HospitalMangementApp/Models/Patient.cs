using HospitalMangementApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace HospitalMangementApp.Models
{
    public class Patient
    {
        [Key]
        public int P_ID { get; set; }
        public string? NIC { get; set; }
        public string? Name { get; set; }
        [Required]
        public StatusEnum Status { get; set; } = StatusEnum.Active;
        [Required]
        public GenderEnum Gender { get; set; }
        [Required]
        public DateOnly UpdatedOn { get; set; }
        [Required]
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? MedicalDeatils { get; set; }

    }
}
