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
        public void Valid_One_Uppercase_Password2()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateUpperCasePassword("Mohan@12");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_One_Numeric_Password2()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateOneNumericPassword("Mohan@12");
            Assert.IsTrue(value);
        }

        [Test]
        public void Valid_One_Special_Password2()
        {
            Validation problem = new Validation();
            bool value = problem.ValidateOneSpecialPassword("Mohan@12");
            Assert.IsTrue(value);
        }
        [Test]
        public void Valid_All_Sample_Email()
        {
            Validation problem = new Validation();
            bool value1 = problem.ClearAllSampleEmail("xyz@1.com");
            bool value2 = problem.ClearAllSampleEmail("xyz.100@xyz.com.au");
            bool value3 = problem.ClearAllSampleEmail("xyz123@rer.com.");
            bool value4 = problem.ClearAllSampleEmail("aec205a-bc.net");
            bool value5 = problem.ClearAllSampleEmail("cdz222@abc.com");
            bool value6 = problem.ClearAllSampleEmail("xyz.300@yahoo.com");
            bool value7 = problem.ClearAllSampleEmail("rads+triggur@gmail.com.in");
            bool value8 = problem.ClearAllSampleEmail("abc+220@gmail.com");
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsTrue(value4);
            Assert.IsTrue(value5);
            Assert.IsTrue(value6);
            Assert.IsTrue(value7);
            Assert.IsTrue(value8);
        }
    }
}