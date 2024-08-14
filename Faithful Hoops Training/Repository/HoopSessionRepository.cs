using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Interfaces;
using FaithfulHoopsTraining.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(hoopSession);
            return Save();
        }

        public bool Delete(HoopSession hoopSession)
        {
            _context.Remove(hoopSession);
            return Save();
        }

        public async Task<IEnumerable<HoopSession>> GetAll()
        {
            return await _context.HoopSessions.ToListAsync();
        }

        public async Task<HoopSession> GetByIdAsync(int id)
        {
            return await _context.HoopSessions.Include(i => i.Address).FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<IEnumerable<HoopSession>> GetAllHoopSessionsByCity(string city)
        {
            return await _context.HoopSessions.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false ;
        }

        public bool Update(HoopSession hoopSession)
        {
            _context.Update(hoopSession);
            return Save();
        }
    }
}
