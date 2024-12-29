using System.ComponentModel.DataAnnotations;

namespace Assignment_EmployeeData.Models
{
    public class DateOfBirthRangeAttribute : ValidationAttribute
    {
        private readonly int _minYear;
        private readonly int _maxYear;

        public DateOfBirthRangeAttribute(int minYear, int maxYear)
        {
            _minYear = minYear;
            _maxYear = maxYear;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                int year = dateOfBirth.Year;
                if (year >= _minYear && year <= _maxYear)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"Year of birth must be between {_minYear} and {_maxYear}.");
                }
            }

            return new ValidationResult("Invalid Date of Birth.The DOB should be between @");
        }
    }
}

