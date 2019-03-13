using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class DegreePlan{
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanID { get; set; }
        public int StudentID{get;set;}
        public string DegreePlanAbv {get; set;}
        public string DegreePlanName { get; set;}
        public int DegreeId { get; set;}

       public Student Student { get; set; }
        public Degree Degree { get; set; }

      

    }
}