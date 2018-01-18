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
    public class ApplicationKeywords : GenericKeywords
    {
        public static void getTextList(String objectLocator)
        {   
            try
            {
                IList<IWebElement> all = driver.FindElements(By.XPath(objectLocator));
                String[] allText = new String[all.Count];
                int i = 0;
                foreach (IWebElement element in all)
                {
                    allText[i++] = element.Text;
                    testLogPass("Menu tab are ' " + element.Text );
                }
            }
            catch (Exception e)
            {
                testLogFail(("Exception Error '" + e.ToString() + "'"));
            }
        }

        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
