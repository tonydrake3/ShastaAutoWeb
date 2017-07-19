using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using eSUBTests.Helpers;

namespace eSUBTests
{
    public class BaseStepsQA : BaseSteps
    {
        public BaseStepsQA() {
            BaseURL = "https://esub.qa.com";
        }
    }
    public class BaseStepsDev : BaseSteps
    {
        public BaseStepsDev() {
            BaseURL = "https://esub.dev.com";
        }
    }
    public class BaseStepsGoogle : BaseSteps
    {
        public BaseStepsGoogle() {
            BaseURL = "https://www.google.com";
        }
    }
    public class BaseSteps
    {
        string defaultUrl = "http://web.develop.shasta.esubonline.com";
        protected IWebDriver driver;
        protected string BaseURL { get; set; }
        public BaseSteps() {
            BaseURL = defaultUrl;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(BaseURL + url);
        }
   
        public void EnterValue(string id, string value)
        {
            driver.FindElement(By.Id(id)).Clear();
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        [BeforeScenario]
        public void SetupTest()
        {
            //driver = driver ?? new FirefoxDriver();
            driver = BrowserContext.Current;
           //driver = driver ?? new ChromeDriver();
            
            // verificationErrors = new StringBuilder();
        }

        [AfterScenario]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
                driver.Close();
                driver = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            // Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
