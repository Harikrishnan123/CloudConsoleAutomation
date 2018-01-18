
using NUnit.Framework;


namespace CloudConsole
{
    [TestFixture]
    class HomePage : ApplicationKeywords
    {
        public static void HomePageVerification()
        {
            verifyElement(OR.Home_User);
            verifyElement(OR.Home_Logout);
            verifyElement(OR.Home_User_icon);
            verifyElement(OR.Home_Logout);
            verifyElement(OR.Home_Menu_Application);
            //verifyElement(OR.Home_Menu_organization);
            //verifyElement(OR.Home_Menu_organizationType);
            verifyElement(OR.Home_Menu_dashboard);
            verifyElement(OR.Home_Menu_communications);
            verifyElement(OR.Home_Menu_securitylog);
            verifyElement(OR.Home_Menu_urlshortener);
            getText(OR.Login_Footer);
        }

        public static void HomePageVerificationText()
        {
            verifyElementText(OR.Home_User,getText(OR.Home_User));
            verifyElement(OR.Home_Logout);
            verifyElement(OR.Home_Menu_Application);
            verifyElement(OR.Home_Menu_users);
            verifyElement(OR.Home_Menu_organization);
            verifyElement(OR.Home_Menu_organizationType);
            verifyElement(OR.Home_Menu_dashboard);
            verifyElement(OR.Home_Menu_communications);
            verifyElement(OR.Home_Menu_securitylog);
            verifyElement(OR.Home_Menu_urlshortener);
            getText(OR.Login_Footer);
        }

    }
}

