﻿using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class Char8PasswordUC5
    {
        public static string validPassword = "^[A-Z]{8,}$";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password, validPassword);
        }
    }
}
