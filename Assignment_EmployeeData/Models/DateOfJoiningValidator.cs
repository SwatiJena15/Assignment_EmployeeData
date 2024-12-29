using System.ComponentModel.DataAnnotations;

namespace Assignment_EmployeeData.Models
{
    public class DateOfJoiningValidationAttribute : ValidationAttribute
    {
        public DateOfJoiningValidationAttribute() : base("Date of Joining must be less than or equal to the current date.")
        {
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            DateTime doj;
            if (DateTime.TryParse(value.ToString(), out doj))
            {
                return doj <= DateTime.Now.Date;  // Validate if DOJ is less than or equal to today
            }

            return false;
        }
    }

}

