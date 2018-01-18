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
    class RolePage : ApplicationKeywords
    {
        public static String RoleName = "0000Role" + RandomString(3) ;
        public static String EditRoleName = "Edited" + RandomString(3);

        public static void CreateRole(String RoleName)
         {
            waitTime(10);
            waitForElementToDisplay(OR.AddBtn, 60);
            waitForElementToDisplay(OR.PlusIcon, 60);
            clickOn(OR.PlusIcon);
            waitForElementToDisplay(OR.Roles_Roles_Label, 60);
            verifyElementText(OR.Roles_Roles_Label, "Roles");
            verifyElementText(OR.Roles_RoleName_Label, "Role Name");
            waitForElementToDisplay(OR.Roles_RoleName, 60);
            typeIn(OR.Roles_RoleName, RoleName);
            clickOn(OR.Create_Btn);
         

        }

        public static void CreateRoleCancel(String RoleName)
        {
            waitTime(10);
            waitForElementToDisplay(OR.AddBtn, 60);
            waitForElementToDisplay(OR.PlusIcon, 60);
            clickOn(OR.PlusIcon);
            waitForElementToDisplay(OR.Roles_Roles_Label, 60);
            verifyElementText(OR.Roles_Roles_Label, "Roles");
            verifyElementText(OR.Roles_RoleName_Label, "Role Name");
            waitForElementToDisplay(OR.Roles_RoleName, 60);
            typeIn(OR.Roles_RoleName, RoleName);

            clickOn(OR.Cancel_Btn);
            String one = getAttributeValue(OR.Roles_RoleName, "value");
            if (one.Equals(""))
            {
                testLogPass("Role name is cleared after clicking on cancel button");
            }
        }

        public static void verifyRole(String verify)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@style='cursor:pointer']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(verify))
                {
                    testLogPass("Role in the list - " + s.Text);
                    break;
                }
            }
        }

        public static void DeleteRole()
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@style='cursor:pointer']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(RoleName))
                {
                    if (driver.FindElement(By.XPath("(//*[@class='fa fa-trash'])[" + i + "]")).Displayed)
                    {
                        driver.FindElement(By.XPath("(//*[@class='fa fa-trash'])[" + i + "]")).Click();
                        testLogPass("Clicked on user - " + RoleName);
                        verifyElementText(OR.Delete_ValidationMSg, "Are you sure you want to delete this entry?");
                        clickOn(OR.Yes);
                        waitForElementToDisplay(OR.Roles_Delete_sucessmessage, 60);
                        verifyElementText(OR.Roles_Delete_sucessmessage, "Role deleted successfully.");
                        break;
                    }
                }

            }
        }

        public static void EditRole()
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@style='cursor:pointer']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(RoleName))
                {
                    if (driver.FindElement(By.XPath("(//*[@class='fa fa-trash'])[" + i + "]")).Displayed)
                    {
                        driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]")).Click();
                        testLogPass("Clicked on user - " + RoleName);
                        typeIn(OR.Roles_RoleName_Edit, EditRoleName);
                        clickOn(OR.UserUpdateSave_Btn);
                        waitForElementToDisplay(OR.Roles_Updated_sucessmessage, 60);
                        verifyElementText(OR.Roles_Updated_sucessmessage, "Role updated successfully");
                        verifyRole(EditRoleName);
                        break;
                    }
                }

            }
        }

        public static void rolePageverification()
        {
            verifyElementText(OR.User_Info, "Access to Aspire Cloud Console applications and their functionality available can be configured using Roles. This section of the Cloud Console provides the ability to create and manage Roles within an application.");
            verifyElementText(OR.Roles_RoleName_Label, "Role Name");
            waitTime(10);
            clickOn(OR.PlusIcon);
            verifyElementText(OR.Roles_Roles_Label, "Roles");
            verifyElementText(OR.Roles_Roles_Label, "Roles");
            verifyElement(OR.Cancel_Btn);
            verifyElement(OR.Create_Btn);
            verifyElement(OR.Roles_RoleName_Roleicon);
        }

        public static void EditAdminRole()
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@style='cursor:pointer']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@style='cursor:pointer'])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains("admin"))
                {
                    s.Click();
                    testLogPass("Role in the list - " + s.Text);
                    break;
                }
            }
        }
    }
}


