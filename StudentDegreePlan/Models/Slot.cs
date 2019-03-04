using System;
using System.Collection.Generic;


namespace StudentDegreePlan.Models
{
    public class Slot
    {
        public int ID { get; set; }
        public string Status { get; set; }

        //public DegreePlan Degreeplan { get; set; }
        //[ForeignKey("DegreePlanID")]

        //public Term Term { get; set }
        //[ForeignKey("TermID")]

        //public Credit Credit { get; set }
        //[ForeignKey("CreditID")]
    }
}