using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm", 
                new CultureInfo("en-US"), 
                DateTimeStyles.None, 
                out var dateTime);

            return isValid;
        }
    }
}