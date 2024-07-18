namespace FaithfulHoopsTraining.Models
{
    public class AppUser
    {
        public int? PlayersAge { get; set; }
        public string? PlayersName { get; set; }
        public Address? Address { get; set; }
        public ICollection<TrainSession> TrainSessions { get; set; }
        public ICollection<HoopSession> HoopSessions { get; set; }
    }
}
