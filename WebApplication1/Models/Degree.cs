using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Degree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        [StringLength(10)]
        public string DegreeAbbr { get; set; }
        [StringLength(20)]
        public string DegreeName { get; set; }
        [Range(0, 8)]
        public int NumberOfTerms { get; set; }
        public bool Done { get; set; }



    }
}