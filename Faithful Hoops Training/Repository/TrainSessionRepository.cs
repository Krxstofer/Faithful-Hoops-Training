using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Interfaces;
using FaithfulHoopsTraining.Models;
using Microsoft.EntityFrameworkCore;

namespace FaithfulHoopsTraining.Repository
{
    public class TrainSessionRepository : ITrainSessionRepository
    {
        private readonly ApplicationDbContext _context;

        public TrainSessionRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public bool Add(TrainSession trainSession)
        {
            _context.Add(trainSession);
            return Save();
        }

        public bool Delete(TrainSession trainSession)
        {
            _context.Remove(trainSession);
            return Save();
        }

        public async Task<IEnumerable<TrainSession>> GetAll()
        {
            return await _context.TrainSessions.ToListAsync();
        }

        public async Task<IEnumerable<TrainSession>> GetAllTrainSessionsByCity(string city)
        {
            return await _context.TrainSessions.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public async Task<TrainSession> GetByIdAsync(int id)
        {
            return await _context.TrainSessions.FirstOrDefaultAsync(t => t.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(TrainSession trainSession)
        {
            throw new NotImplementedException();
        }
    }
}
