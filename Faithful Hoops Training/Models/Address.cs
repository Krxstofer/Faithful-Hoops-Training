using System.ComponentModel.DataAnnotations;

namespace FaithfulHoopsTraining.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int String { get; set; }
        public int City { get; set; }
        public int State { get; set; }
    }
}
