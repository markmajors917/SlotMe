using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMe.Data
{
    public class Talent
    {
        public enum GenreType {Juggler=1, Music }
        [Key]
        public string TalentId { get; set; }
        
        [Required]
        public string UserId { get; set; }
       [Required]
        public string TalentTitle { get; set; }
        [Required]
        public string TalentDesciption { get; set; }
        [Required]
        public decimal TalentCost  { get; set; }
        
    }
}
