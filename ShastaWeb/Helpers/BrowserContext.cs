using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSUBTests.Helpers
{
    public static class BrowserContext
    {
        public static IWebDriver Current { get; private set; }
        static BrowserContext()
        {
            Current = new FirefoxDriver();
        }
    }
}
