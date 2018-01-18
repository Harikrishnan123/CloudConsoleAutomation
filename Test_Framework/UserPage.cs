using CloudConsole;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConsole
{
    [TestFixture]
    class UserPage : ApplicationKeywords
    {
        public static String UserName = "000TestA" + RandomString(8);
        public static String Email = UserName + "@Mailinator.com";
        public static String Password = "Test@1234";

        public static void UserVerficationPage()
        {
            waitTime(10);
            waitForElementToDisplay(OR.User_Info, 30);
            verifyElementText(OR.User_Info, "Here you will find a list of all users for a specified application. Selecting a user will bring up basic information about them. Outside of the UserName itself, any of those fields can be updated.");
            verifyElementText(OR.User_BasicTab, "Info");
            verifyElementText(OR.User_RoleTab, "Roles");
            verifyElementText(OR.User_Orgtab, "Organizations");
            verifyElementText(OR.User_ManageTab, "Manage");
            verifyElementText(OR.User_ActivityTab, "Activity");
            verifyElementText(OR.User_SettingTab, "Settings");
            verifyElementText(OR.PlusIcon, "+");
            clickOn(OR.AddBtn);
            verifyElementText(OR.User_Email_Label, "Email");
            verifyElementText(OR.User_userName_Label, "User Name");
            verifyElementText(OR.User_Phone_Label, "Phone");
            verifyElementText(OR.User_password_Label, "Password");
            verifyElementText(OR.User_confirmPassword_Label, "Confirm Password");
            verifyElementText(OR.User_firstName_Label, "First Name");
            verifyElementText(OR.User_lastName_Label, "Last Name");
        }

        public static void MandrilCreateUser()
        {
            openBrowser("https://www.mailinator.com");
            typeIn(OR.Mailinator_Inputbox, UserPage.UserName);
            clickOn(OR.Mailinator_Inputbox_GoBtn);
            //driver.SwitchTo().Frame("selectFrame");
            clickOn(OR.Mailinator_ActivationMail);
            IWebElement iframe = driver.FindElement(By.Id("msg_body"));
            driver.SwitchTo().Frame(iframe);
            driver.FindElement(By.XPath("//a[contains(text(),'Activate ➔')]")).Click();
            string newTabHandle = driver.WindowHandles.Last();
            var newTab = driver.SwitchTo().Window(newTabHandle);
            var expectedNewTabTitle = "Your account has been confirmed";
            Assert.AreEqual(expectedNewTabTitle, newTab.Title);
            testLogPass(newTab.Title);
            newTab.Close();
            driver.Quit();
        }

        public static void MandrilForgotPassword()
        {
            openBrowser("https://www.mailinator.com");
            typeIn(OR.Mailinator_Inputbox, UserPage.UserName);
            clickOn(OR.Mailinator_Inputbox_GoBtn);
            //driver.SwitchTo().Frame("selectFrame");
            clickOn(OR.Mailinator_ForgotPasswordMail);
            IWebElement iframe = driver.FindElement(By.Id("msg_body"));
            driver.SwitchTo().Frame(iframe);
            driver.FindElement(By.XPath("//a[contains(text(),'Reset password ➔')]")).Click();
            //string newTabHandle = driver.WindowHandles.Last();
            //var newTab = driver.SwitchTo().Window(newTabHandle);
            //var expectedNewTabTitle = "Reset password";
            //Assert.AreEqual(expectedNewTabTitle, newTab.Title);
            //testLogPass(newTab.Title);
            //typeIn(OR.User_password, "Test@12345");
            //typeIn(OR.User_confirmPassword, "Test@12345");
            //clickOn(OR.Mailinator_ForgotPassword_reset);
            //verifyElementText(OR.Mailinator_ForgotPassword_Sucess, "Your password has been reset.");
            //newTab.Close();
            //driver.Quit();
        }

        public static void user_Inforpage()
        {
            waitTime(10);
            waitForElementToDisplay(OR.AddBtn, 60);
            clickOn(OR.AddBtn);
            verifyElementText(OR.User_Email_Label, "Email");
            typeIn(OR.User_Email, Email);
            verifyElementText(OR.User_userName_Label, "User Name");
            typeIn(OR.User_userName, UserName);
            verifyElementText(OR.User_Phone_Label, "Phone");
            typeIn(OR.User_password, Password);
            typeIn(OR.User_confirmPassword, Password);
            clickOn(OR.Create_Btn);
            waitForElementToDisplay(OR.AlertSucess, 60);
            verifyElementText(OR.AlertSucess, "User created successfully");
        }

        public static void UserVerification()
        {

            verifyElement(OR.User_Info);
            verifyElementText(OR.User_Left_UserName, "User Name");
            clickOn(OR.AddBtn);
        }
        public static void UserCreate(String Email, String Username, String Password, String ConfirmPassword)
        {
            try
            {
                waitTime(10);
                waitForElementToDisplay(OR.AddBtn, 60);
                clickOn(OR.AddBtn);
                verifyElementText(OR.User_Email_Label, "Email");
                typeIn(OR.User_Email, Email);
                typeIn(OR.User_userName, Username);
                typeIn(OR.User_password, Password);
                typeIn(OR.User_confirmPassword, ConfirmPassword);
                clickOn(OR.Create_Btn);
            }
            catch (Exception e)
            {
                testLogFail("UserCreate " + e.ToString());
            }
        }

        public static void verifyUser()
        {
            try
            {
                waitTime(10);
                int One = driver.FindElements(By.XPath("(//*[@style='cursor:pointer'])")).Count;
                for (int i = 1; i <= One; i++)
                {
                    IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                    String s1 = s.Text;
                    if (s1.Contains(UserName))
                    {
                        testLogPass("Created user in the list - " + s.Text);
                        driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]")).Click();
                        getAttributeValue(OR.User_UserId, "disabled");
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                testLogFail("verifyUser " + e.ToString());
            }
        }


        public static void DeleteUser(String UserName)
        {
            try
            {
                waitTime(10);
                int One = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;
                for (int i = 1; i <= One; i++)
                {
                    IWebElement s = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[2]"));
                    String s1 = s.Text;
                    if (s1.Contains(UserName))
                    {
                        if (driver.FindElement(By.XPath("(//*[@class='fa fa-trash'])[" + i + "]")).Displayed)
                        {
                            waitTime(10);
                            driver.FindElement(By.XPath("(//*[@class='fa fa-trash'])[" + i + "]")).Click();
                            testLogPass("Clicked on user - " + UserName);
                            verifyElementText(OR.Delete_ValidationMSg, "Are you sure you want to delete this entry?");
                            clickOn(OR.Yes);
                            waitForElementToDisplay(OR.AlertSucess, 60);
                            verifyElementText(OR.AlertSucess, "User deleted successfully.");
                            break;
                        }


                    }

                }
            }
            catch (Exception e)
            {
                testLogFail("DeleteUser " + e.ToString());
            }
        }


        public static void EditUser(String UserName)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[2]"));
                String s1 = s.Text;
                if (s1.Contains(UserName))
                {
                    typeIn(OR.User_firstName, "Test");
                    waitForElementToDisplay(OR.UserUpdateSave_Btn, 60);
                    clickOn(OR.UserUpdateSave_Btn);
                    waitTime(10);
                    waitForElementToDisplay(OR.AlertSucess, 60);
                    verifyElementText(OR.AlertSucess, "User updated successfully");
                    verifyUser();
                    getAttributeValue(OR.User_firstName, "value");
                    break;
                }

            }
        }

        public static void verifyRole()
        {
            verifyElement(OR.User_RoleTab);
            clickOn(OR.User_RoleTab);
        }

        public static void verifyOrg()
        {
            verifyElement(OR.User_Orgtab);
            clickOn(OR.User_Orgtab);
        }

        public static void verifyManage()
        {
            verifyElement(OR.User_ManageTab);
            clickOn(OR.User_ManageTab);
        }

        public static void verifyActive()
        {
            verifyElement(OR.User_ActivityTab);
            clickOn(OR.User_ActivityTab);
        }

        public static void UserCreateCancel(String Email, String Username, String Password, String ConfirmPassword)
        {
            try
            {
                waitTime(10);
                waitForElementToDisplay(OR.AddBtn, 60);
                clickOn(OR.AddBtn);
                verifyElementText(OR.User_Email_Label, "Email");
                typeIn(OR.User_Email, Email);
                typeIn(OR.User_userName, Username);
                typeIn(OR.User_password, Password);
                typeIn(OR.User_confirmPassword, ConfirmPassword);
                clickOn(OR.Org_Create_Cancel);
                if (getAttributeValue(OR.User_Email, "value").Equals(Email))
                {
                    testLogFail("Typed Email is displays after cancelling'");
                }
                if (getAttributeValue(OR.User_userName, "value").Equals(Username))
                {
                    testLogFail("Typed username is displays after cancelling'");
                }
                if (getAttributeValue(OR.User_password, "value").Equals(Password))
                {
                    testLogFail("Typed Password is displays after cancelling'");
                }
                if (getAttributeValue(OR.User_confirmPassword, "value").Equals(ConfirmPassword))
                {
                    testLogFail("Typed ConfirmPassword is displays after cancelling'");
                }


            }
            catch (Exception e)
            {
                testLogFail("UserCreatecancel " + e.ToString());
            }
        }

        public static void verifyRoleSelected()
        {
            int size = driver.FindElements(By.XPath("//*[@id='role']//label/input")).Count();

            for(int i=1;i<=size;i++)
            {
                String RoleName = driver.FindElement(By.XPath("(//*[@id='role']//label)["+i+"]")).Text;
                if (RoleName.Contains("user"))
                {
                    testLogPass("Role contains User");
                    if (driver.FindElement(By.XPath("(//*[@id='role']//label/input)[" + i + "]")).Selected);
                    {
                        testLogPass("User is checkbox is checked");
                        break;
                    }
                }
            }
            for (int i = 1; i <= size; i++)
            {
                String RoleName = driver.FindElement(By.XPath("(//*[@id='role']//label)[" + i + "]")).Text;
                if (RoleName.Contains("admin"))
                {
                    if (driver.FindElement(By.XPath("(//*[@id='role']//label/input)[" + i + "]")).Selected) ;
                    {
                        testLogPass("admin is checkbox is checked");
                        break;
                    }
                }
            }
        }

        public static void verifyAvtivateUser()
        {
            if(driver.FindElement(By.XPath("(//*[@class='aspNetDisabled']//input[@type='checkbox'])[1]")).Selected)
            {
                testLogPass("checkbox of the Active User is checked");
            }
            else
            {
                testLogFail("checkbox of the Active User is unchecked");
            }
        }

        public static void verifyApprovedUser()
        {
            if (driver.FindElement(By.XPath("(//*[@class='aspNetDisabled']//input[@type='checkbox'])[2]")).Selected)
            {
                testLogPass("checkbox of the Approved User is checked");
            }
            else
            {
                testLogPass("checkbox of the Approved User is unchecked");
            }
        }


        public static void verifylockUser()
        {
            try
            {
                waitTime(10);
                int One = driver.FindElements(By.XPath("(//*[@class='fa fa-lock'])")).Count;
                for (int i = 1; i <= One; i++)
                {
                    IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                    //String s1 = s.Text;
                    if (s.Displayed)
                    {
                        testLogPass("Locked User FOund - " + s.Text);
                        driver.FindElement(By.XPath("(//*[@class='fa fa-lock'])[" + i + "]")).Click();
                        getText(OR.User_LockedUserValidation);
                        getAttributeValue(OR.User_UserId, "disabled");
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                testLogFail("verifyUser " + e.ToString());
            }
        }

    }
}

