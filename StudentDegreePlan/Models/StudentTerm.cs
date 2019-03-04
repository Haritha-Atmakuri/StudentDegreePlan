using System;
using System.Collection.Generic;


namespace StudentDegreePlan.Models
{
    public class StudentTerm
    {
        public int ID { get; set; }
        public int Term { get; set;} 
        public string TermAbbr {get; set;}
        public string TermName {get; set;}
        public string NoOfCoursesTaken {get; set;}

        //public Student Student { get; set }
        //[ForeignKey("StudentID")]

        //public DegreePlan Degreeplan { get; set; }
        //[ForeignKey("DegreePlanID")]

    }
}