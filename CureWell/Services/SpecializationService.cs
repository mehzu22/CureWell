using CureWell.Database;
using CureWell.Models;

namespace CureWell.Services
{
    public class SpecializationService : ISpecializationService
    {
        private readonly CureWellContext _context;
 
        public SpecializationService(CureWellContext context)
        {
            _context = context;
        }
        public List<Specialization> GetAllSpecializations()
        {
            return _context.Specializations.ToList();
        }
    }
}