using FaithfulHoopsTraining.Models;

namespace FaithfulHoopsTraining.Interfaces
{
    public interface ITrainSessionRepository
    {
        Task<IEnumerable<TrainSession>> GetAll();
        Task<TrainSession> GetByIdAsync(int id);
        Task<IEnumerable<TrainSession>> GetAllTrainSessionsByCity(string city);
        bool Add(TrainSession trainSession);
        bool Update(TrainSession trainSession);
        bool Delete(TrainSession trainSession);
        bool Save();
    }
}
