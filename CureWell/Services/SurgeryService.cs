using CureWell.Database;
using CureWell.Models;

namespace CureWell.Services
{
    public class SurgeryService : ISurgeryService
    {
        private readonly CureWellContext _context;

        public SurgeryService(CureWellContext context)
        {
            _context = context;
        }

        public List<Surgery> GetAllSurgeryTypeForToday()
        {
            DateTime today = DateTime.Today;

            var surgeriesForToday = _context.Surgeries
                                            .Where(s => s.SurgeryDate.Date == today)
                                            .ToList();

            if (surgeriesForToday.Count == 0)
            {
                throw new Exception("No surgeries found for today.");
            }

            return surgeriesForToday;
        }

        public bool UpdateSurgery(Surgery surgery)
        {
            _context.Surgeries.Update(surgery);
            _context.SaveChanges();
            return true;
        }
    }
}