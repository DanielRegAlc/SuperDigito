using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperDigito.Models
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Login User { get; set; }
        public int Number { get; set; }
        public int Result { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}