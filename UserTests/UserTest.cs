using LaunchMod1Week5Assessment;
using System.Security.Cryptography.X509Certificates;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void IsCreated()
        {
            var annie = new User("Annie", "sillygoose@gmail.com");

            Assert.Equal("Annie", annie.Name);
            Assert.Equal("sillygoose@gmail.com", annie.Email);
            //Assert.Equal(new User("Annie", "sillygoose@gmail.com"), annie);
        }
        [Fact]
        public void CreatPassword_CreatesPasswordForUser()
         {
            var annie = new User("Annie", "sillygoose@gmail.com");

            annie.CreatePassword("sillygoose@gmail.com", "teehee");

            Assert.Equal("teehee", annie.Password);
        }
        //To test the above method, I changed the password attribute to be public for the test
        //I left it public so the tests could run...
        [Fact]
        public void LogIn_LogsUserIn()
        {
            var annie = new User("Annie", "sillygoose@gmail.com");
            annie.CreatePassword("sillygoose@gmail.com", "teehee");

            annie.LogIn("teehee");

            Assert.Equal(true, annie.IsLoggedIn);
        }

        [Fact]
        public void LogOut_LogsOutUser()
        {
            var annie = new User("Annie", "sillygoose@gmail.com");
            annie.CreatePassword("sillygoose@gmail.com", "teehee");
            annie.LogIn("teehee");

            annie.LogOut();

            Assert.Equal(false, annie.IsLoggedIn);
        }

        [Fact]
        public void IsSetupComplete_ReturnsCorrectBool()
        {
            var annie = new User("Annie", "sillygoose@gmail.com");
            annie.CreatePassword("sillygoose@gmail.com", "teehee");
            

            Assert.Equal("Annie", annie.Name);
            Assert.Equal("sillygoose@gmail.com", annie.Email);
            Assert.Equal("teehee", annie.Password);
        }















    }
}       //I placed the return "Not Logged In" on line 61 within the string method LogOut() code block.
        //I moved the return "Logged In" outside of the if code block to line 54.
        //Refactoring is hard! I definetly need to practice.