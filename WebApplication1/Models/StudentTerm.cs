using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class StudentTerm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        //public int StudentId { get; set; }
        public int Term { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }

        public int DegreePlanId { get; set; }

        public bool Done { get; set; }

        public DegreePlan DegreePlan { get; set; }
        public ICollection<Credit> Credits { get; set; }
        public ICollection<Slot> Slots { get; set; }

        // public Student Student { get; set; }

    }
}