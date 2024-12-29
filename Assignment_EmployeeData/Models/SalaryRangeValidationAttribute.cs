using System.ComponentModel.DataAnnotations;

namespace Assignment_EmployeeData.Models
{
    public class SalaryRangeValidationAttribute : ValidationAttribute
    {
        public SalaryRangeValidationAttribute() : base("Salary must be between 12,000 and 60,000.")
        {
        }

        public override bool IsValid(object value)
        {
            // Allow null salary (nullable case)
            if (value == null)
                return true;

            // Check if value is a valid decimal
            if (value is decimal salary)
            {
                return salary >= 12000 && salary <= 60000;
            }

            return false;  // Invalid if not a decimal or outside the range
        }
    }
}
