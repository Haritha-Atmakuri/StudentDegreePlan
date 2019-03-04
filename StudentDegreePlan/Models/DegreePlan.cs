using System;
using System.Collection.Generic;


namespace StudentDegreePlan.Models
{
    public class DegreePlan{
        public int DegreePlanID { get; set; }
        public string DegreePlanAbv {get; set;}
        public string DegreePlanName { get; set;}
        public int DegreeId { get; set;}

        //foreign key[("StudentID")]
        //public  StudentID Student { get; set;}

    }
}