using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Helpers
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessageFormatString = "The {0} field is required.";
        private readonly string[] _dependentProperties;

        public RequiredIfAttribute(string[] dependentProperties)
        {
            _dependentProperties = dependentProperties;
            ErrorMessage = DefaultErrorMessageFormatString;
        }

        private bool IsValueRequired(string checkValue, Object currentValue)
        {
            if (checkValue.Equals("!null", StringComparison.InvariantCultureIgnoreCase))
            {
                return currentValue != null;
            }

            return checkValue.Equals(currentValue);
        }

        protected override ValidationResult IsValid(Object value, ValidationContext context)
        {
            Object instance = context.ObjectInstance;
            Type type = instance.GetType();
            bool valueRequired = false;

            foreach (string s in _dependentProperties)
            {
                var fieldValue = s.Split(',').ToList().Select(k => k.Trim()).ToArray();

                Object propertyValue = type.GetProperty(fieldValue[0]).GetValue(instance, null);
                foreach(string val in fieldValue)
                {
                    valueRequired = valueRequired | IsValueRequired(val, propertyValue);
                }
            }

            if (valueRequired)
            {
                return value != null
                    ? ValidationResult.Success
                    : throw new AppException(context.DisplayName + " is Required");
            }
            return ValidationResult.Success;
        }
    }
}
