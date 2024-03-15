using CureWell.Models;

namespace CureWell.Services
{
    public interface ISurgeryService
    {
        public List<Surgery> GetAllSurgeryTypeForToday();
        public bool UpdateSurgery(Surgery surgery);
    }
}