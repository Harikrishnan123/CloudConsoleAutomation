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
    class ForgotPasswordPage : ApplicationKeywords
    {
        public static String validUserName = "Harikrishnan";
        public static String InvalidUserName = "@#$#$krishnan";

        public static void ForgotPasswordpageverification()
        {
            
            waitForElementToDisplay(OR.ForgotPassword_Label, 60);
            verifyElementText(OR.ForgotPassword_Label, "Forgot Password");
            verifyElementText(OR.ForgotPassword_EnterUserName, "Please enter your username.");
            verifyElementText(OR.Login_info, "For more information, or to request additional privileges, please");
            verifyElementText(OR.Login_info2, "contact the Aspire Core Technology team");
            verifyElementText(OR.Login_AccountInfo, "Account Information");
            verifyElementText(OR.Login_Label_Username, "Username");
            verifyElement(OR.Login_Input_username);
        }
        public static void ForgotpasswordFunction(String username)
        {
            waitForElementToDisplay(OR.ForgotPassword_Label, 60);
            waitForElementToDisplay(OR.Login_Input_username, 60);
            typeIn(OR.Login_Input_username, username);
            clickOn(OR.ForgotPassword_RecoverPassword);
            
        }

        
    }
}

