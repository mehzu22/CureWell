using CureWell.Models;

namespace CureWell.Services
{
    public interface IDoctorService
    {
        public List<Doctor> GetAllDoctors();
        public bool AddDoctor(Doctor doctor);
        public bool UpdateDoctorDetails(Doctor doctor);
        public bool DeleteDoctor(int doctorId);
        public List<DoctorSpecialization> GetDoctorsBySpecialization(string specializationCode);
    }
}