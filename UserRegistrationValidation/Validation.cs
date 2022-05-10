using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]$";
        public const string Email_Pattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string Mobile_Pattern = "^[6-9]{1}[0-9]{9}$";
        public bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, Name_Pattern)) ;
            {
                Console.WriteLine("Valid name " + name);
                return true;
            }
        }
        public bool ValidateLastname(string lastname)
        {
            if (Regex.IsMatch(lastname, Name_Pattern)) ;
            {
                Console.WriteLine("Valid last name " + lastname);
                return true;
            }
        }

        public bool ValidateEmail(string Email)
        {
            if (Regex.IsMatch(Email, Email_Pattern)) ;
            {
                Console.WriteLine("Valid Email " + Email);
                return true;
            }
        }
        public bool ValidateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, Mobile_Pattern)) ;
            {
                Console.WriteLine("valid mobile " + mobile);
                return true;
            }
        }
    }
}