using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class UserRegistration
    {
        public string regex_FirstName = "^[A-Z]{1}[a-z]{2,8}$";
        public string regex_LastName = "^[A-Z]{1}[a-z]{2,8}$";
        public string regex_EmailID = "^[a-z0-9]{1,10}[.,+,-]*[a-z0-9]{1,10}[@]{1}[a-z0-9]{1,9}[.]{1}[a-z]{2,5}[.]*[a-z]{1,3}$";
        public string regex_MobileNO = "^[+]*[9]{1}[1]{1}[' ']*[0-9]{10}$";
        public string regex_Password = "^[A-Z]{1}[a-zA-Z0-9!@#$%^&]{7}$";

        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, regex_FirstName);
        }
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, regex_LastName);
        }

        public string validateEmailID(string Email)
        {
            if (Regex.IsMatch(Email, regex_EmailID))
            {
                Console.WriteLine("Email is Valid");
                return "Email is Valid";
            }
            else
            {
                Console.WriteLine("Email is InValid");
                return "Email is InValid";
            }
        }
        public bool validateMobileNumber(string mobilenum)
        {
            return Regex.IsMatch(mobilenum, regex_MobileNO);
        }
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, regex_Password);
        }
    }
}
