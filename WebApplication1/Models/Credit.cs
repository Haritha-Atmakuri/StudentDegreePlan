using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Credit{
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditID { get; set; }
        public string CreditAbv { get; set; }
        public string CreditName { get; set; }
        public int IsSummer { get; set; }
        public int IsSpring { get; set; }
        public int IsFall { get; set ;}
    }
}