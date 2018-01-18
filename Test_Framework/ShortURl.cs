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
    class ShortURl : ApplicationKeywords
    {
        
        public static void verificationShortUrlAddpage()
        {
            verifyElementText(OR.ShortUrltxt, "Use the fields below to create short URL");
            verifyElementText(OR.ShortUrl_Urltxt, "URL");
            verifyElementText(OR.ShortUrl_CreateBtn, "Create");
        }

        public static void verifyShorturlHomepage()
        {
            verifyElement(OR.ShortUrl_LabelLongUrl);
            verifyElement(OR.ShortUrl_Header_LabelSegment);
            verifyElement(OR.ShortUrl_Header_LabelClicks);
            verifyElement(OR.ShortUrl_Header_LabelCreatedOn);
            verifyElement(OR.ShortUrl_Header_LabelExpired);
            verifyElement(OR.ShortUrl_Header_LabelLongUrl);
        }

        public static void verifyfunctionurl()
        {
            typeIn(OR.ShortUrl_Url_input, "www.google.com");
            clickOn(OR.ShortUrl_CreateBtn);
            verifyElementText(OR.ShortUrl_label, "Short URL");
            getAttributeValue(OR.ShortUrl_get, "value");
            navigateTo(getAttributeValues);
            testLogPass("Page title : " + driver.Title);
        }


        public static void verificationDisplayColumn()
        {
            clickOn(OR.ShortUrl_DisplayColumn);
            verifyElementText(OR.ShortUrl_DisplayColumn_Segment, "Segment");
            verifyElementText(OR.ShortUrl_DisplayColumn_Clicks, "Clicks");
            verifyElementText(OR.ShortUrl_DisplayColumn_CreatedOn, "Created On");
            verifyElementText(OR.ShortUrl_DisplayColumn_Expired, " Expired");
            verifyElementText(OR.ShortUrl_DisplayColumn_LongUrl, "Long Url");
            verifyElement(OR.ShortUrl_DisplayColumn_btnSelectAll);
            verifyElement(OR.ShortUrl_DisplayColumn_btnSelectNone);

        }
        public static void verificationlabel()
        {
            clickOn(OR.ShortUrl_DisplayColumn);
            verifyElementText(OR.ShortUrl_label_Segment, "Segment");
            verifyElementText(OR.ShortUrl_label_Clicks, "Clicks");
            verifyElementText(OR.ShortUrl_Label_CreatedOn, "Created On");
            verifyElementText(OR.ShortUrl_Label_Expired, "Expired");
            verifyElementText(OR.ShortUrl_LabelLongUrl, "Long Url");
        }

        public static void PaginationFunction()
        {
            if(driver.FindElements(By.XPath("//*[@class='pagination']")).Count!=0)
            {
                String BeforePagination = getText(OR.ActivePagination);
                testLogPass("Verify pagination Before clicking on Next : '" + getText(OR.ActivePagination));
                if (BeforePagination.Contains("1"))
                {
                    clickOn(OR.ActivePaginationNext);
                    testLogPass("Verify pagination After clicking on Next : '" + getText(OR.ActivePagination)); 
                }
            }
        }

        public static void page()
        {
            driver.FindElement(By.XPath("//select")).Click();
            int size = driver.FindElements(By.XPath("//select")).Count;
            for(int i=1;i<=size;i++)
            {
                String one = driver.FindElement(By.XPath("(//select/option)["+i+"]")).Text;
                testLogPass("Page list are '" + one);

            }
        }
    }
}

