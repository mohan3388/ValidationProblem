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
        
       
        
    }
}