using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="name must greater 3 or less then 15 charaters") ]
        public string name { get; set; }
        [Required]
        [EmailAddress] 
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [Range(10,45,ErrorMessage ="Age must greater then 10 orr less then 45")]
        public int?age { get; set; }
        [Required]
        public string des {  get; set; }
        [Required]
        [RegularExpression("^[0-9]*$")]
        public int?salary { get; set; }
        [Required]
        public string Married { get; set; }
        [Required]
        public string Description { get; set; }
    }
    public enum Gender
    {
        male,
        female

    }
}
