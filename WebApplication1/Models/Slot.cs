using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Slot
    {
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotID { get; set; }
        public string Status { get; set; }
        
        public int DegreePlanID { get; set; }
        //[ForeignKey("DegreePlanID")]

        public int Term { get; set; }
        //[ForeignKey("TermID")]

        public int CreditID { get; set; }
        //[ForeignKey("CreditID")]
       
    }
}