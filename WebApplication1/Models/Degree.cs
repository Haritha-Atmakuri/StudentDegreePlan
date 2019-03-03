using System;
using System.Collection.Generic;


namespace DegreePlan.Models
{
    public class Degree
    {
        public int ID{ get; set; }
        public string DegreeAbv { get; set;}
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
    }
}
