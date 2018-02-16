﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                                    "d MMM yyyy", 
                                    new CultureInfo("en-US"), 
                                    DateTimeStyles.None, 
                                    out var dateTime);

            return isValid && dateTime > DateTime.Now;
        }
    }
}