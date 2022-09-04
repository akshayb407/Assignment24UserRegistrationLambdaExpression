using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationTest
{
        [TestClass]
        public class UnitTest1
        {
            private readonly RegExValidation reg;
            public UnitTest1()
            {
                reg = new RegExValidation();
            }
            [TestMethod]
            public void FirstNameTest()
            {
                string name = "Vallem";
                bool result = reg.FirstNameVal(name);
                Assert.AreEqual(true, result);
            }
            [TestMethod]
            public void LastNameTest()
            {
                string name = "Balu";
                bool result = reg.LastNameVal(name);
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
                bool result = reg.EmailValidation(email);
                bool result2 = reg.EmailValidation(email2);
                bool result3 = reg.EmailValidation(email3);
                bool result4 = reg.EmailValidation(email4);
                bool result5 = reg.EmailValidation(email5);
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
                bool result = reg.MobileValidation(mobile);
                Assert.AreEqual(true, result);
            }
            [TestMethod]
            public void PasswordTest()
            {
                string password = "VbnReddys@123v";
                bool result = reg.PasswordRule(password);
                Assert.AreEqual(true, result);
            }
            [TestMethod]
            public void Happy_Test()
            {
                var Result = reg.MessageCheck("Happy");
                Assert.AreEqual(true, Result);
            }
            [TestMethod]
            public void MultipleEmailTest()
            {
                var Result = reg.CheckMultipleEmail("vbn@gmail.com", "vbn.vbn@gmail.com", "vbn234@gmail.com");
                string check = "succesfull";
                Assert.AreEqual(check, Result);
            }
            [TestMethod]
            [DataRow("Akshay")]
            public void InvalidName_TrowException(string FirstName)
            {
                try
                {
                    reg.FirstNameVal(FirstName);
                }
                catch (CustomException Exception)
                {
                    Assert.AreEqual("Invalid First Name", Exception.Message);
                }
            }
            [TestMethod]
            [DataRow("Bhagwat")]
            public void InvalidLastName_TrowException(string LastName)
            {
                try
                {
                    reg.LastNameVal(LastName);
                }
                catch (CustomException Exception)
                {
                    Assert.AreEqual("Invalid LastName", Exception.Message);
                }
            }
            [TestMethod]
            [DataRow("information@gmail.com")]
            public void InvalidEmail_ThrowException(string Email)
            {
                try
                {
                    reg.EmailValidation(Email);
                }
                catch (CustomException Exception)
                {
                    Assert.AreEqual("Invalid Email", Exception.Message);
                }
            }
            [TestMethod]
            [DataRow("91 1234567890")]
            public void InvalidMobileNo_TrowException(string MobileNo)
            {
                try
                {
                    reg.MobileValidation(MobileNo);
                }
                catch (CustomException Exception)
                {
                    Assert.AreEqual("Invalid Mobile No", Exception.Message);
                }
            }
            [TestMethod]
            [DataRow("12Q35abcd")]
            public void InvalidPassword_TrhowException(string Password)
            {
                try
                {
                    reg.PasswordRule(Password);
                }
                catch (CustomException Exception)
                {
                    Assert.AreEqual("Invalid Password", Exception.Message);
                }
            }
        }
    
}