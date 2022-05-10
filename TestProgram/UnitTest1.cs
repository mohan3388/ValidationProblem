using NUnit.Framework;
using UserRegistrationValidation;

namespace TestProgram
{
    public class Tests
    {
       
        [Test]
        public void Valid_First_Name()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateName("Mohan");
            Assert.IsTrue(value);
        }

       
    }
}