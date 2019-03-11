using System;
using System.Collections.Generic;



namespace WebApplication1.Models
{
    public class DegreeCredit
    {
        public int DegreeCreditID{ get; set; }
        public string DegreeID { get; set;}
      //  [ForeignKey("CreditID")]
        public int CreditID { get; set;}
       
         
    }
}
