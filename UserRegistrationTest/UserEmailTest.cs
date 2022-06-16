using UserRegistrationProgram;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserEmailTest
    {
         [DataTestMethod]
         [DataRow("abc@yahoo.com")]
         [DataRow("abc-100@yahoo.com")]
         [DataRow("abc.100@yahoo.com")]
         [DataRow("abc111@abc.com")]
         [DataRow("abc-100@abc.net")]
         [DataRow("abc.100@abc.com.au")]
         [DataRow("abc@1.com")]
         [DataRow("abc@gmail.com.com")]
         [DataRow("abc+100@gmail.com")]

         public void TestTheValidEmails(string email)
         {
            //Arrange
            string expected_output = "Email is Valid";
            string actual_output;
            UserRegistration userRegistration = new UserRegistration();

            //Act
            actual_output = userRegistration.validateEmailID(email);

            //Assert
            Assert.AreEqual(expected_output, actual_output);
         }

        [DataTestMethod]
        [DataRow("abc")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow("abc@%*.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow(".abc..2002@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]

        public void TestTheInValidEmails(string email)
        {
            //Arrange
            string expected_output = "Email is InValid";
            string actual_output;
            UserRegistration userRegister = new UserRegistration();

            //Act
            actual_output = userRegister.validateEmailID(email);

            //Assert
            Assert.AreEqual(expected_output, actual_output);
        }    
    }
}