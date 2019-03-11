using System;
using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; set; }
        public int Term { get; set;} 
        public string TermAbbr {get; set;}
        public string TermName {get; set;}
        public int NoOfCoursesTaken {get; set;}

        public int StudentID { get; set; }
        //[ForeignKey("StudentID")]

        public int DegreePlanID { get; set; }
        //[ForeignKey("DegreePlanID")]

    }
}