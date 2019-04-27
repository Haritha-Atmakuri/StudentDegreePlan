using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class DegreePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }

        [DisplayName("Student")]
        public int StudentId { get; set; }

        [DisplayName("Plan")]
        public string DegreePlanAbbr { get; set; }

        [DisplayName("Plan Name")]
        [StringLength(50)]
        public string DegreePlanName { get; set; }

        public int DegreeId { get; set; }

        public bool Done { get; set; }

        public Degree Degree { get; set; }
        public Student Student { get; set; }

        public ICollection<StudentTerm> StudentTerms { get; set; }
        public ICollection<Slot>Slots { get; set; }

    }
}