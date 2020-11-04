using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMe.Data
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [ForeignKey(nameof(Gig))]
        public int GigId { get; set; }
        public virtual Gig Gig { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        //seperate user Id for who bought and sold? Can we use User in a virtual key?
    }
}
