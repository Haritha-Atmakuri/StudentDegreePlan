using System;
using System.Collection.Generic;



namespace StudentDegreePlan.Models
{
    public class DegreeCredit
    {
        public int DegreeCreditID{ get; set; }
        public string DegreeID { get; set;}
        //[ForeignKey("CreditID")]
        //public CreditID CreditID { get; set}
       
        
    }
}
