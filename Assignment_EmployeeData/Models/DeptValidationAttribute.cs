using System.ComponentModel.DataAnnotations;

namespace Assignment_EmployeeData.Models
{
    public class DeptValidationAttribute:ValidationAttribute
    {
        // Define the allowed departments
        private static readonly string[] AllowedDepartments = { "HR", "Accts", "IT" };

        public DeptValidationAttribute() : base("Department must be one of the following: HR, Accts, IT.")
        {
        }

        public override bool IsValid(object value)
        {
            // If the value is null, assume it is valid (nullable case)
            if (value == null)
                return true;

            // Ensure that the value is a string and check if it is one of the allowed departments
            if (value is string dept)
            {
                return Array.Exists(AllowedDepartments, d => d.Equals(dept, StringComparison.OrdinalIgnoreCase));
            }

            return false;  // Invalid if not a string or not one of the allowed departments
        }
    }
}
