using System.ComponentModel.DataAnnotations;


namespace Assignment_EmployeeData.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name should not be empty")]
        [RegularExpression(@"[A-Za-z]+")]
        [StringLength(15,ErrorMessage ="minimum 15 characters needed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "DOB should not be empty and it should be between 2002 to 2005")]
        //[DateOfBirthRange(2002, 2005)]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        [DateOfJoiningValidation]
        [DataType(DataType.Date)]
        public DateOnly DateOfJoining { get; set; }

        [SalaryRangeValidation]
        public decimal? Salary { get; set; }

        [Required]
        [DeptValidation]
        public string Department {  get; set; }

        [Required]
        [DataType(DataType.Password)]
        //[RegularExpression(@"^[A-Za-z0-9 ]+")]
        public string Password {  get; set; }
    }
}
