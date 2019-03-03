using System;
using System.Collection.Generic;


namespace StudentDegreePlan.Models
{
    public class Credit{
        public int ID { get; set; }
        public string CreditAbv { get; set; }
        public string CreditName { get; set; }
        public int ISSummer { get; set; }
        public int ISSpring { get; set; }
        public int ISFall { get; set ;}
    }
}