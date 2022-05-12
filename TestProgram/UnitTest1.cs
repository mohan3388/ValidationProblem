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
        [Test]
        public void Valid_Last_Name()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateLastname("Sahu");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Email()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateEmail("Mohan@123gmail.com");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Mobile()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateMobile("7898625487");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Password()
        {
            Validation problem = new Validation();
            bool value = problem.ValidatePassword("Mohan@12");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_Password2()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateUpperCasePassword("Mohan@12");
            Assert.IsTrue(value);
        }
    }
}