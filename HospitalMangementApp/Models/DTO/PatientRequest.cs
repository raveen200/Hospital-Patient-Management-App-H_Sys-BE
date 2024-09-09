﻿using HospitalMangementApp.Models.Enums;

namespace HospitalMangementApp.Models.DTO
{
    public class PatientRequest
    {
        
        public string? NIC { get; set; }
        public string? Name { get; set; }
        public GenderEnum Gender { get; set; } 
        public string? Address { get; set; }
    }
}