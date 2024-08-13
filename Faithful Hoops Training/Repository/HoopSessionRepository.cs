using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Interfaces;
using FaithfulHoopsTraining.Models;

namespace FaithfulHoopsTraining.Repository
{
    public class HoopSessionRepository : IHoopSessionRepository
    {
        private readonly ApplicationDbContext _context;

        public HoopSessionRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public bool Add(HoopSession hoopSession)
        {
            throw new NotImplementedException();
        }

        public bool Delete(HoopSession hoopSession)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HoopSession>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HoopSession> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HoopSession>> GetHoopSessionsByCity(string city)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(HoopSession hoopSession)
        {
            throw new NotImplementedException();
        }
    }
}
