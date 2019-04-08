using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Developer
    {
        
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(150)]
        public string Given{ get; set; }
        [MinLength(3)]
        [MaxLength(150)]
        public string Family{ get; set; }
        [MinLength(3)]
        [MaxLength(150)]
        public string GraduationTerm{ get; set; }
        [MinLength(3)]
        [MaxLength(150)]
        public string DesiredPosition{ get; set; }
        [MinLength(3)]
        [MaxLength(150)]
        public string Skills{ get; set; }
[Range(1,5)]
public int Rating{ get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

    }
}
