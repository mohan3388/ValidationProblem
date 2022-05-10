using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    public class Validation
    {
        public const string Name_Pattern = "^[A-Z]{1}[A-Za-z]$";
      
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


    }
}