using CloudConsole;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConsole
{
    [TestFixture]
    class CommunicationPage : ApplicationKeywords
    {
        public static String comminicationName = "Test_" + RandomString(6);
        public static String communicationType = "EmailHtml";
        public static String comminicationSubject = "Subject";
        public static String comminicationDescription = "Description";
        public static String comminicationBody = "Body";

        public static void CommunicationVerification()
        {
            verifyElement(OR.Communication_AddCustom_Btn);
            verifyElement(OR.Communication_AddNew_Btn);
        }
        public static void AddCommunication(String Name)
        {
            try
            {
                waitTime(10);
                waitForElementToDisplay(OR.Communication_AddNew_Btn, 60);
                clickOn(OR.Communication_AddNew_Btn);
                verifyElementText(OR.Communication_AddNewCustom_Name_Label, "Name");
                typeIn(OR.Communication_AddNewCustom_Name, Name);
                verifyElementText(OR.Communication_AddNewCustom_communicationType_Label, "Type");
                selectFromDropdown(OR.Communication_AddNewCustom_communicationType, communicationType);
                verifyElementText(OR.Communication_AddNewCustom_Subject_Label, "Subject");
                typeIn(OR.Communication_AddNewCustom_Subject, comminicationSubject);
                verifyElementText(OR.Communication_AddNewCustom_Description_Label, "Description");
                typeIn(OR.Communication_AddNewCustom_Description, comminicationDescription);
                verifyElementText(OR.Communication_AddNewCustom_Body_Label, "Body");
                typeIn(OR.Communication_AddNewCustom_Body, comminicationBody);
                waitForElementToDisplay(OR.Create_Btn, 60);
                clickOn(OR.Create_Btn);

            }
            catch (Exception e)
            {
                testLogFail("Add COmmunication - " + e.ToString());
            }
        }

        public static void HeaderValue()
        {
            waitTime(10);
            int One = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[1]/th")).Count;
            for (int i = 1; i <= One; i++)
            {
                IWebElement s = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[1]/th[" + i + "]"));
                testLogPass("Test in header are - " + s.Text);
            }
        }


        public static void VerifyValue(String VerifyName)
        {
            int sColValue = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;

            //First loop will find the 'ClOCK TWER HOTEL' in the first column
            for (int i = 2; i <= sColValue; i++)
            {
                String sValue = null;
                sValue = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[1]")).Text;
                int FindCOunt = i;
                if (sValue.Equals(comminicationName))
                {
                    int Headercount = driver.FindElements(By.XPath(".//*[@id='MainContent_RoleGrid']/tbody/tr[1]/th")).Count;
                    // If the sValue match with the description, it will initiate one more inner loop for all the columns of 'i' row 
                    for (int j = 1; j <= Headercount; j++)
                    {
                        String HeaaderRowValue = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[1]/th[" + j + "]")).Text;
                        String Value = driver.FindElement(By.XPath(".//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[" + j + "]")).Text;
                        testLogPass("Header is '" + HeaaderRowValue + "' and value is ' " + Value + " '");
                    }

                }
            }
        }

        public static void ViewValue()
        {
            try
            {
                waitTime(10);
                int sColValue = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;

                //First loop will find the 'ClOCK TWER HOTEL' in the first column
                for (int i = 2; i <= sColValue; i++)
                {
                    String sValue = null;
                    sValue = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[1]")).Text;
                    int FindCOunt = i;
                    if (sValue.Equals(comminicationName))
                    {
                        driver.FindElement(By.XPath("//*[@href='/communications/detail/" + comminicationName + "']")).Click();
                        waitTime(10);
                        String Name = getAttributeValue(OR.Communication_View_Name, "value");
                        String Type = getAttributeValue(OR.Communication_View_communicationType, "value");
                        String Desc = getAttributeValue(OR.Communication_View_Description, "value");
                        String Subject = getAttributeValue(OR.Communication_View_Subject, "value");
                        String Body = getAttributeValue(OR.Communication_View_Body, "value");
                        if (comminicationName.Equals(Name))
                        {
                            testLogPass("Name which is created '" + comminicationName + "' and viw page ' " + Name + " '");
                        }

                        if (communicationType.Equals(Type))
                        {
                            testLogPass("Type which is created '" + comminicationName + "' and viw page ' " + Type + " '");
                        }
                        if (comminicationDescription.Equals(Desc))
                        {
                            testLogPass("Description which is created '" + comminicationName + "' and viw page ' " + Name + " '");
                        }
                        if (comminicationSubject.Equals(Subject))
                        {
                            testLogPass("Subject which is created '" + comminicationName + "' and viw page ' " + Name + " '");
                        }
                        if (comminicationBody.Equals(Body))
                        {
                            testLogPass("Body which is created '" + comminicationName + "' and viw page ' " + Name + " '");
                        }
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                testLogFail(e.ToString());
            }
        }


        public static void DeleteValue(String CommunicationName)
        {
            try
            {
                waitTime(10);
                int sColValue = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;

                //First loop will find the 'ClOCK TWER HOTEL' in the first column
                for (int i = 2; i <= sColValue; i++)
                {
                    String sValue = null;
                    sValue = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[1]")).Text;
                    int FindCOunt = i;
                    if (sValue.Equals(comminicationName))
                    {
                        driver.FindElement(By.XPath("(//a[contains(text(),'Delete')])[" + i + "]")).Click();
                        waitTime(10);
                        testLogPass("validation message for Delete '" + getText(OR.Delete_ValidationMSg));
                        testLogPass("validation message for Delete '" + getText(OR.Delete_ValidationMSg_Confirm));
                        clickOn(OR.Yes);
                        waitForElement(OR.Communication_Delete_Confirm, 60);
                        verifyElementText(OR.Communication_Delete_Confirm, "Communication deleted successfully.");
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                testLogFail(e.ToString());
            }
        }

        public static void EditCommunication(String Name)
        {
            waitTime(10);
            int sColValue = driver.FindElements(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr")).Count;

            //First loop will find the 'ClOCK TWER HOTEL' in the first column
            for (int i = 1; i <= sColValue; i++)
            {
                String sValue = null;
                sValue = driver.FindElement(By.XPath("//*[@id='MainContent_RoleGrid']/tbody/tr[" + i + "]/td[1]")).Text;
                int FindCOunt = i;
                if (sValue.Equals(comminicationName))
                {
                    driver.FindElement(By.XPath("(//a[contains(text(),'Edit')])[" + i + "]")).Click();
                    waitTime(10);
                    verifyElementText(OR.Communication_AddNewCustom_Name_Label, "Name");
                    typeIn(OR.Communication_AddNewCustom_Name, "EDIT" + Name);
                    verifyElementText(OR.Communication_AddNewCustom_communicationType_Label, "Type");
                    verifyElementText(OR.Communication_AddNewCustom_Subject_Label, "Subject");
                    verifyElementText(OR.Communication_AddNewCustom_Description_Label, "Description");
                    verifyElementText(OR.Communication_AddNewCustom_Body_Label, "Body");
                    clickOn(OR.Save_Btnorganization);
                    waitForElement(OR.Communication_Edit_SucessValidation, 60);
                    verifyElementText(OR.Communication_Edit_SucessValidation, "Communication updated successfully");
                    break;
                }

            }
        }
    }
}


