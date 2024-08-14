using FaithfulHoopsTraining.Models;

namespace FaithfulHoopsTraining.Interfaces
{
    public interface IHoopSessionRepository
    {
        Task<IEnumerable<HoopSession>> GetAll();
        Task<HoopSession> GetByIdAsync(int id);
        Task<IEnumerable<HoopSession>> GetAllHoopSessionsByCity(string city);
        bool Add(HoopSession hoopSession);
        bool Update(HoopSession hoopSession);
        bool Delete(HoopSession hoopSession);
        bool Save();
    }
}
