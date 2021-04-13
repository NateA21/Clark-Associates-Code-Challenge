using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        

        [TestMethod]
        public void CreateInvalidUser_ReturnFail()
        {

            UserInfoModel RealUser = new UserInfoModel {
                FirstName = "Nate",
                LastName = "Athorn",
                Email = "abc@abc.com"
            };

            UserInfoModel MockUser = new UserInfoModel {
                FirstName = "Nate",
                LastName = "Athorn",
                Email = "abc.com"
            };

           
            Assert.AreNotEqual(MockUser.IsValid(), RealUser.IsValid());
        }

        [TestMethod]
        public void CreateValidUser_ReturnTrue() {

            UserInfoModel RealUser = new UserInfoModel {
                FirstName = "Nate",
                LastName = "Athorn",
                Email = "abc@abc.com"
            };

            UserInfoModel MockUser = new UserInfoModel {
                FirstName = "Nate",
                LastName = "Athorn",
                Email = "abc@hotmail.com"
            };


            Assert.AreEqual(MockUser.IsValid(), RealUser.IsValid());
        }
    }

    internal class UserInfoModel {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$")]
        public string Email { get; set; }

        

        public bool IsValid() {
            Regex rgx = new Regex("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
            if (FirstName != "" && LastName != "" && rgx.IsMatch(Email)) {
                return true;
            } else {
                return false;
            }
        }
        
    }
}
