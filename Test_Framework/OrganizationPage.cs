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
    class OrganizationPage : ApplicationKeywords
    {
        public static String OrgTypeName = "0000Orgtyp" + RandomString(4) ;
        public static String OrgName = "0000Org" + RandomString(4);
        public static String OrgDes = "0000Des" + RandomString(4);



        public static void VerifyOrg()
        {
            verifyElementText(OR.OrgType_Label, "Organization Types");
            verifyElementText(OR.Org_tab, "Organizations");
        }

        public static void CreateOrgType(String OrgTypeName)
         {
            waitForElementToDisplay(OR.OrgType_Label_Left, 60);
            waitTime(10);
            clickOn(OR.OrgType_AddBtn);
            verifyElementText(OR.OrgType_OrgtypeName_Label, "Name");
            verifyElementText(OR.OrgType_Enable, "Enabled");
            verifyCheckBoxIsChecked(OR.OrgType_Enable_Checkbox);
            verifyElement(OR.OrgType_NameIcon);
            verifyElement(OR.OrgType_SaveBtn);
            verifyElement(OR.OrgType_CancelBtn);
            typeIn(OR.Org_Type, OrgTypeName);
            clickOn(OR.OrgType_CreateBtn);
            verifyElementText(OR.OrgType_CreateSucess, "Organization Type created successfully");
            verifyOrg(OrgTypeName);
        }
        public static void CreateOrgType1()
        {
            waitForElementToDisplay(OR.OrgType_Label_Left, 60);
            clickOn(OR.OrgType_AddBtn);
            verifyElementText(OR.Org_Type_Label, "Organization Type");
            verifyElementText(OR.OrgType_OrgtypeName_Label, "Name");
            verifyElementText(OR.OrgType_Enable, "Enabled");
            verifyCheckBoxIsChecked(OR.OrgType_Enable_Checkbox);
            verifyElement(OR.OrgType_NameIcon);
            verifyElement(OR.OrgType_SaveBtn);
            verifyElement(OR.OrgType_CancelBtn);
            typeIn(OR.Org_Type, OrgTypeName);
            clickOn(OR.Create_Btn);
            verifyOrg(OrgTypeName);
            EditOrgtype(OrgTypeName);
            DeleteOrgType(OrgTypeName);


        }
        public static void verifyOrg(String Name)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='OrganizationsType']//*[@class='inner_table']//tr/td[2]")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@id='OrganizationsType']//*[@class='inner_table']//tr/td[2])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(Name))
                {
                    testLogPass("Created is list - " + s.Text);
                    break;
                }
            }
        }

        public static void DeleteOrgType(String Name)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='OrganizationsType']//*[@class='fa fa-trash']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='OrganizationsType']//tbody/tr[" + i + "]/td[2]"));
                //IWebElement s = driver.FindElement(By.XPath("(//*[@id='OrganizationsType']//*[@class='fa fa-trash'])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(Name))
                {
                    if (driver.FindElement(By.XPath("(//*[@id='OrganizationsType']//*[@class='fa fa-trash'])[" + i + "]")).Displayed)
                    {
                        driver.FindElement(By.XPath("(//*[@id='OrganizationsType']//*[@class='fa fa-trash'])[" + i + "]")).Click();
                        testLogPass("Selected the created one - " + Name);
                        waitForElementToDisplay(OR.Delete_ValidationMSg, 60);
                        verifyElementText(OR.Delete_ValidationMSg, "Are you sure you want to delete this entry?");
                        clickOn(OR.Yes);
                        waitForElementToDisplay(OR.OrgType_DeleteSucess, 60);
                        verifyElementText(OR.OrgType_DeleteSucess, "Organization Type deleted successfully.");
                        break;
                    }
                }

            }
        }

        public static void EditOrgtype(String OrgName)
        {
            waitTime(10);
            waitForElement(OR.OrgType_Update_SaveChanges, 60);
            verifyElementText(OR.OrgType_Label, "Organization Type");
            verifyElementText(OR.OrgType_OrgtypeName_Label, "Name");
            verifyElementText(OR.OrgType_Enable, "Enabled");
            verifyCheckBoxIsChecked(OR.OrgType_Enable_Checkbox);
            verifyElement(OR.OrgType_NameIcon);
            verifyElement(OR.OrgType_Update_SaveChanges);
            verifyElement(OR.OrgType_Update_CancelBtn);

            int One = driver.FindElements(By.XPath("//*[@id='OrganizationsType']//tbody/tr")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='OrganizationsType']//tbody/tr[" + i + "]/td[2]"));
                String s1 = s.Text;
                if (s1.Contains(OrgName))
                {
                    if (driver.FindElement(By.XPath("//*[@id='OrganizationsType']//tbody/tr[" + i + "]/td[2]")).Displayed)
                    {
                        driver.FindElement(By.XPath("//*[@id='OrganizationsType']//tbody/tr[" + i + "]/td[2]")).Click();
                        testLogPass("Selected the Org Type Name - " + OrgName);
                        typeIn(OR.OrgType_UpdateName, "Edit"+ OrgName);
                        clickOn(OR.OrgType_Update_SaveChanges);
                        waitForElementToDisplay(OR.OrgType_UpdatedSucess, 60);
                        verifyElementText(OR.OrgType_UpdatedSucess, "Organization type updated successfully");
                        break;
                    }
                }

            }
        }

        public static void verifyOrganization()
        {
            verifyElementText(OR.Org_tab, "Organizations");
            verifyElementText(OR.Org_Label, "Organizations");
            verifyElementText(OR.Org_NameLabel, "Organization Name");
            verifyElementText(OR.Org_Description_Label, "Description");
            verifyElementText(OR.Org_Enable_Label, "Organization enabled");
            verifyElementText(OR.Org_Type_Label, "Organization Type");
            verifyElement(OR.Org_Nameicon);
            verifyElement(OR.Org_Description_icon);
            verifyElement(OR.Org_Enable_icon);
            verifyElement(OR.Org_Name);
            verifyElement(OR.Org_description);
            verifyElement(OR.Org_organizationType);
            verifyElement(OR.Org_Cancel);
            verifyElement(OR.Org_SaveChanges);
        }

        public static void OrganizationCreate(String OrganizationName, String Desc)
        {
            waitForElementToDisplay(OR.Org_Name, 60);
            clickOn(OR.Org_AddBtn);
            typeIn(OR.Org_Name, OrganizationName);
            typeIn(OR.Org_description, Desc);
            selectFromDropdown(OR.Org_organizationType, 1);
            clickOn(OR.Org_Create_Save);
            verifyElementText(OR.Org_Create_Sucess, "Organization created successfully");
        }

        public static void verifyOrgganization(String Name)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tr/td[2]")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("(//*[@id='Organizations']//*[@class='inner_table']//tr/td[2])[" + i + "]"));
                String s1 = s.Text;
                if (s1.Contains(Name))
                {
                    testLogPass("Created is list - " + s.Text);
                    break;
                }
            }
        }

        public static void EditOrganization(String OrgName)
        {
            waitTime(10);


            int One = driver.FindElements(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tbody/tr")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tbody/tr[" + i + "]/td[2]"));
                String s1 = s.Text;
                if (s1.Contains(OrgName))
                {
                    if (driver.FindElement(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tbody/tr[" + i + "]/td[2]")).Displayed)
                    {
                        driver.FindElement(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tbody/tr[" + i + "]/td[2]")).Click();
                        testLogPass("Selected the Org  Name - " + OrgName);
                        typeIn(OR.Org_Name, "Edit" + OrgName);
                        clickOn(OR.Org_SaveChanges);
                        waitForElementToDisplay(OR.Org_update_Sucess, 60);
                        verifyElementText(OR.Org_update_Sucess, "Organization updated successfully");
                        break;
                    }
                }

            }
        }


        public static void DeleteOrganization(String Name)
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='Organizations']//*[@class='fa fa-trash']")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='Organizations']//*[@class='inner_table']//tbody/tr[" + i + "]/td[2]"));
                String s1 = s.Text;
                if (s1.Contains(Name))
                {
                    if (driver.FindElement(By.XPath("(//*[@id='Organizations']//*[@class='fa fa-trash'])[" + i + "]")).Displayed)
                    {
                        driver.FindElement(By.XPath("(//*[@id='Organizations']//*[@class='fa fa-trash'])[" + i + "]")).Click();
                        testLogPass("Selected the created one - " + Name);
                        waitForElementToDisplay(OR.Delete_ValidationMSg, 60);
                        verifyElementText(OR.Delete_ValidationMSg, "Are you sure you want to delete this entry?");
                        clickOn(OR.Yes);
                        waitForElementToDisplay(OR.Org_Delete_Sucess, 60);
                        verifyElementText(OR.Org_Delete_Sucess, "Organization deleted successfully.");
                        break;
                    }
                }

            }
        }
    }
}

