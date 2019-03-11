using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WebApplication1.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID{ get; set; }
        public string DegreeAbv { get; set;}
        [StringLength(50)]
        public string DegreeName { get; set; }
        [Range(0,5)]
        public int NumberOfTerms { get; set; }
    }
}
