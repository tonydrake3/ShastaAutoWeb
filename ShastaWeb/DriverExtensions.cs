using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace eSUBTests
{
    public static class DriverExtensions
    {
        public static void WaitForElement(this IWebDriver self, string elementId, int maxSecondsWait = 5)
        {
            WaitForElementBy(self, elementId, By.Id, maxSecondsWait);
        }

        public static void WaitForElementByName(this IWebDriver self, string elementName, int maxSecondsWait = 5)
        {
            WaitForElementBy(self, elementName, By.Name, maxSecondsWait);
        }

        public static void WaitForElementByClassName(this IWebDriver self, string elementName, int maxSecondsWait = 5)
        {
            WaitForElementBy(self, elementName, By.ClassName, maxSecondsWait);
        }
        public static void WaitForElementBy(this IWebDriver self, string elementName, Func<string, By> by, int maxSecondsWait = 5)
        {
            var initialTime = DateTime.Now;
            for (;;)
            {
                if ((DateTime.Now - initialTime).TotalSeconds >= maxSecondsWait) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(self, by(elementName))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(100);
            };
        }

        static bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
