using System;
using System.ComponentModel.DataAnnotations;

namespace information.Models
{
    public class info
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "required field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "required field")]
        public string Place { get; set; }
        [Required(ErrorMessage = "required field")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "required field")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Joining { get; set; }


        [Required(ErrorMessage = "required field")]

        public string BloodGroup { get; set; }
        public string Designation { get; set; }
        [Required(ErrorMessage = "required field")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNo")]
        public int PhoneNo { get; set; }
        public string Bankname { get; set; }
        public int AccountNo { get; set; }
        public string Type { get; set; }
        

        



    }

    
}