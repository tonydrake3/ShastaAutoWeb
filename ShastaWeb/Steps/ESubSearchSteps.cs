using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace eSUBTests
{
    [Binding]
    public class ESubSearchSteps : BaseStepsGoogle
    {
        [Given(@"I have navigated to google\.com")]
        public void GivenIHaveNavigatedToGoogle_Com()
        {
            NavigateTo("/");
        }        
        
        [When(@"I enter the keyword")]
        public void WhenIEnterTheKeyword(Table table)
        {
            EnterValue("lst-ib", "esub");
            driver.FindElement(By.Id("_fZl")).Click();
            driver.WaitForElement("resultStats");
        }
        
        [Then(@"i should see the following keyword")]
        public void ThenIShouldSeeTheFollowingKeyword(Table table)
        {
            Assert.IsNotNull(driver.FindElement(By.LinkText("eSUB Construction Software")));
        }
    }
}
