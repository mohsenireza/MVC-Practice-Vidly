using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MemberShipTypeId == 1)
            {
                return ValidationResult.Success;
            }
            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birthday is required");
            }
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Age must be equal or greater than 18");
        }
    }
}