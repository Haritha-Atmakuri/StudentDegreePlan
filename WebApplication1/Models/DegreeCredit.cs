using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models
{
    public class DegreeCredit
    {
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditID{ get; set; }
        public string DegreeID { get; set;}
      
        public int CreditID { get; set;}
       public Credit Credit { get; set; }
         
    }
}
