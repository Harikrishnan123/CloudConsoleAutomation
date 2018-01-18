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
    class ApplicationPage : ApplicationKeywords
    {
        
        public static void verificationApplicationinfo()
        {
            verifyElement(OR.Application_APpInfo);
            verifyElementText(OR.Application_AppID_Label, "Application ID");
            verifyElementText(OR.Application_AppName_Label, "Application Name");
            verifyElementText(OR.Application_Description_Label, "Description");
            verifyElementText(OR.Application_AppEnable_Label, "Application enabled");
            verifyElementText(OR.Application_AceptReg_Label, "Accepting registrations");
            getAttributeValue(OR.Application_AppID, "value");
            getAttributeValue(OR.Application_AppName, "value");
            getAttributeValue(OR.Application_Description, "value");
            isElementDisplayed(OR.Application_AppEnable);
            isElementDisplayed(OR.Application_AceptReg);
            isElementDisplayed(OR.Cancel_Btn);
            isElementDisplayed(OR.Save_Btnorganization);
        }

        public static void verificationCompanyConfiguration()
        {
            clickOn(OR.Application_CConfig);
            verifyElement(OR.Application_CConfig);
            verifyElementText(OR.Application_CConfig_Company_Label, "Company");
            verifyElementText(OR.Application_CConfig_StAddress_Label, "Street Address");
            verifyElementText(OR.Application_CConfig_City_Label, "City");
            verifyElementText(OR.Application_CConfig_StateProvince_Label, "State/Province");
            verifyElementText(OR.Application_CConfig_Zipcode_Label, "ZIP/Postal Code");
            verifyElementText(OR.Application_CConfig_Email_Label, "Company Email");
            getAttributeValue(OR.Application_CConfig_Company, "value");
            getAttributeValue(OR.Application_CConfig_StAddress, "value");
            getAttributeValue(OR.Application_CConfig_City, "value");
            getAttributeValue(OR.Application_CConfig_StateProvince, "value");
            getAttributeValue(OR.Application_CConfig_Zipcode, "value");
            getAttributeValue(OR.Application_CConfig_Email, "value");
            isElementDisplayed(OR.Application_CConfig_Companyicon);
            isElementDisplayed(OR.Application_CConfig_Streeticon);
            isElementDisplayed(OR.Application_CConfig_Cityicon);
            isElementDisplayed(OR.Application_CConfig_Stateicon);
            isElementDisplayed(OR.Application_CConfig_Zipicon);
            isElementDisplayed(OR.Application_CConfig_Emailicon);
            isElementDisplayed(OR.Cancel_Btn);
            isElementDisplayed(OR.Save_Btnorganization);
        }

        public static void verificationEmailConfig()
        {
            clickOn(OR.Application_EConfig);
            verifyElement(OR.Application_EConfig);
            verifyElementText(OR.Application_EConfig_Label_SenderName, "Sender Name");
            verifyElementText(OR.Application_EConfig_Label_ReplyEmail, "Reply-To Email");
            verifyElementText(OR.Application_EConfig_Label_SupportEmail, "Support Email");
            getAttributeValue(OR.Application_EConfig_SenderName, "value");
            getAttributeValue(OR.Application_EConfig_ReplytoEmail, "value");
            getAttributeValue(OR.Application_EConfig_SupportEmail, "value");
            verifyElement(OR.Application_EConfig_Sendernameicon);
            verifyElement(OR.Application_EConfig_ReplytoEmailicon);
            verifyElement(OR.Application_EConfig_EmailSupporticon);
            isElementDisplayed(OR.Cancel_Btn);
            isElementDisplayed(OR.Save_Btnorganization);
        }

        public static void verificationOAuthConfig()
        {
            clickOn(OR.Application_OAuth);
            verifyElement(OR.Application_OAuth);
            verifyElementText(OR.Application_OAuth_Label_GoogleID, "Google Client ID");
            verifyElementText(OR.Application_OAuth_Label_GoogleSecret, "Google Secret");
            verifyElementText(OR.Application_OAuth_Label_FBID, "Facebook Client ID");
            verifyElementText(OR.Application_OAuth_Label_FBSecret, "Facebook Secret");
            getAttributeValue(OR.Application_OAuth_GoogleID, "value");
            getAttributeValue(OR.Application_OAuth_GoogleSecret, "value");
            getAttributeValue(OR.Application_OAuth_FBID, "value");
            getAttributeValue(OR.Application_OAuth_FBSecret, "value");
            verifyElement(OR.Application_EConfig_GoogleidIcon);
            verifyElement(OR.Application_EConfig_GoogleidSecreetIcon);
            verifyElement(OR.Application_EConfig_FBIDIcon);
            verifyElement(OR.Application_EConfig_FBSecreetIcon);
            isElementDisplayed(OR.Cancel_Btn);
            isElementDisplayed(OR.Save_Btnorganization);
        }

        public static void verificationBrandConfig()
        {
            clickOn(OR.Application_BCOnfig);
            verifyElement(OR.Application_BCOnfig);
            verifyElementText(OR.Application_Bconfig_WEbsite_Label, "Company Website");
            verifyElementText(OR.Application_Bconfig_LogoUrl_Label, "Logo URL");
            verifyElementText(OR.Application_Bconfig_PrimaryColor_Label, "Primary Color(Hex)");
            verifyElementText(OR.Application_Bconfig_CSS_Label, "CSS URL");
            verifyElementText(OR.Application_Bconfig_FavUrl_Label, "Favicon URL");
            getAttributeValue(OR.Application_Bconfig_WEbsite, "value");
            getAttributeValue(OR.Application_Bconfig_LogoUrl, "value");
            getAttributeValue(OR.Application_Bconfig_PrimaryColor, "value");
            getAttributeValue(OR.Application_Bconfig_CSS, "value");
            getAttributeValue(OR.Application_Bconfig_FavUrl, "value");
            verifyElement(OR.Application_Bconfig_CompaniwebIcon);
            verifyElement(OR.Application_Bconfig_LogoUrlIcon);
            verifyElement(OR.Application_Bconfig_PrimaryColorIcon);
            verifyElement(OR.Application_Bconfig_FavIcon);
            verifyElement(OR.Application_Bconfig_cssURlicon);
            isElementDisplayed(OR.Cancel_Btn);
            isElementDisplayed(OR.Save_Btnorganization);
        }
    }
}

