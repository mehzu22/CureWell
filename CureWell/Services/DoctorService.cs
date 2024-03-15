using CureWell.Database;
using CureWell.Models;
using Microsoft.EntityFrameworkCore;

namespace CureWell.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly CureWellContext _context;
        public DoctorService(CureWellContext context)
        {
            _context = context;
        }
        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }

        public bool AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return true;
        }


        public bool UpdateDoctorDetails(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            var updateDoctor = _context.Doctors.Find(doctor.DoctorId);
            if (updateDoctor == null)
                return false;
            _context.Update(updateDoctor);
            _context.SaveChanges();
            return true;

        }
        public bool DeleteDoctor(int doctorId)
        {
            var doctorToDelete = _context.Doctors.Find(doctorId);
            if (doctorToDelete != null)
            {
                _context.Doctors.Remove(doctorToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<DoctorSpecialization> GetDoctorsBySpecialization(string specializationCode)
        {
            var listOfSpecialization = _context.DoctorSpecializations
            .Where(ds => ds.SpecializationCode == specializationCode).ToList();
            if (listOfSpecialization.Count == 0)
                throw new Exception("No specialization found");
            return listOfSpecialization;

        }
    }
}