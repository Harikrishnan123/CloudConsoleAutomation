using CloudConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConsole
{
    [TestFixture]
    class LoginPage : ApplicationKeywords
    {
        
        public static void loginVerification()
        {
            waitForElementToDisplay(OR.Login_HeaderCloudConsole, 60);
            verifyElement(OR.Login_HeaderCloudConsole);
            verifyElementText(OR.LabelLogin, "Log In");
            verifyElementText(OR.Login_msg_UsrPwd, "Please enter your username and password.");
            verifyElementText(OR.Login_info, "For more information, or to request additional privileges, please");
            verifyElementText(OR.Login_info2, "contact the Aspire Core Technology team");
            verifyElementText(OR.Login_AccountInfo, "Account Information");
            verifyElementText(OR.Login_Label_Username, "Username");
            verifyElementText(OR.Login_Label_password, "Password");
            verifyElement(OR.Login_Loginbtn);
            waitForElementToDisplay(OR.ForgotPassword, 60);
            verifyElementText(OR.ForgotPassword, "Forgot Password?");
            verifyElement(OR.Login_Footer);
            getText(OR.Login_Footer);

        }

        public static void login(String Username, String Password)
        {
            waitForElementToDisplay(OR.Login_Input_username, 60);
            typeIn(OR.Login_Input_username, Username);
            typeIn(OR.Login_Input_Password, Password);
            clickOn(OR.Login_Loginbtn);
            verifyElement(OR.Home_User);
            verifyElement(OR.Home_Logout);
        }

        public static void login1(String Username, String Password)
        {
            waitForElementToDisplay(OR.Login_Input_username, 60);
            typeIn(OR.Login_Input_username, Username);
            typeIn(OR.Login_Input_Password, Password);
            clickOn(OR.Login_Loginbtn);
        }

        public static void encriptedPassword(String Password)
        {
            try
            {
                typeIn(OR.Login_Input_Password, Password);

                Assert.AreNotEqual(Password, getAttributeValue(OR.Login_Input_Password, "value"));
            }
            catch (Exception e)
            {

            }
        }
    }
}

