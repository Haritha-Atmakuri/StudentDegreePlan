using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models
{
    public class Student
    {
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int StudentID {get; set;}
    public string FamilyName {get; set;}
    public string GivenName { get; set; }
    public string Sid { get; set;}
    public int CatPawsID { get; set;} 
    }
    
}