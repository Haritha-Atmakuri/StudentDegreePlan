using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class StudentTerm
    {
     [DatabaseGenerated(DatabaseGeneratedOption.None)]
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