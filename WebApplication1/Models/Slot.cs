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
        

        public int Term { get; set; }
        

        public int CreditID { get; set; }
        
        public DegreePlan DegreePlan { get; set; }
       
   

       
    }
}