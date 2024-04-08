using System.ComponentModel.DataAnnotations;

namespace AlstomInterview.Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public string ViewName { get; set; }
    }
}
