using AutoMapper;
using HospitalMangementApp.Models;
using HospitalMangementApp.Models.DTO;






namespace HospitalMangementApp
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PatientDTO, Patient>();
                config.CreateMap<Patient, PatientDTO>();


            });
            return mappingConfig;






        }
    }
}
