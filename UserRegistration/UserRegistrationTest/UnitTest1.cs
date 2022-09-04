using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System;
namespace UserRegistrationTest
{

    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Vallem";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Balu";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email = "vbn@gmail.com";
            string email2 = "vbn.vbn@gmail.com";
            string email3 = "vbn.vbn@gmail.co.in";
            string email4 = "vbn.vbn3434@gmail.com";
            string email5 = "vbn.reddy@gmail.com.in";
            bool result = program.EmailValidation(email);
            bool result2 = program.EmailValidation(email2);
            bool result3 = program.EmailValidation(email3);
            bool result4 = program.EmailValidation(email4);
            bool result5 = program.EmailValidation(email5);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 9492407489";
            bool result = program.MobileValidation(mobile);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "VbnReddys@123v";
            bool result = program.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
    }
}
