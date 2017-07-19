using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace eSUBTests.Steps.Projects.Filter_By
{
    [Binding]
    public class StatusSteps: BaseSteps
    {
        [Given(@"a User has logged into Shasta")]
        public void GivenAUserHasLoggedIntoShasta()
        {
            NavigateTo("/#/login");
        }
        
        [Given(@"the User has a selected Tenant/Company")]
        public void GivenTheUserHasASelectedTenantCompany()
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(3000);

            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(2000);
        }
        
        [When(@"the Project Selection page loads")]
        public void WhenTheProjectSelectionPageLoads()
        {
            ScenarioContext.Current.Pending();
        }

      //  [Then(@"the Project Selection page shall contain a set of Status Filter buttons")]
        public void ThenTheProjectSelectionPageShallContainASetOfStatusFilterButtons()
        {
            ScenarioContext.Current.Pending();
        }
        
       // [Then(@"the buttons shall be displayed at the upper left corner of the page")]
        public void ThenTheButtonsShallBeDisplayedAtTheUpperLeftCornerOfThePage()
        {
            ScenarioContext.Current.Pending();
        }
        
       // [Then(@"a filter button shall be displayed for the Project Status of Open")]
        public void ThenAFilterButtonShallBeDisplayedForTheProjectStatusOfOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Open filter button shall be grey with black text to show which status is selected")]
        public void ThenTheOpenFilterButtonShallBeGreyWithBlackTextToShowWhichStatusIsSelected()
        {

            driver.FindElement(By.Id("md-button-toggle-6-input")).Click();
            driver.FindElement(By.CssSelector("#md-button-toggle-6 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();

            Thread.Sleep(2000);
        }
        
        [Then(@"a filter button shall be displayed for the Project Status of Complete")]
        public void ThenAFilterButtonShallBeDisplayedForTheProjectStatusOfComplete()
        {
            driver.FindElement(By.CssSelector("#md-button-toggle-7 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();
            driver.FindElement(By.CssSelector("#md-button-toggle-7 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();

            Thread.Sleep(2000);
        }

        [Then(@"a filter button shall be displayed for the Project Status of Bid")]
        public void ThenAFilterButtonShallBeDisplayedForTheProjectStatusOfBid()
        {
            driver.FindElement(By.Id("md-button-toggle-8-input")).Click();
            driver.FindElement(By.CssSelector("#md-button-toggle-8 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();

            Thread.Sleep(2000);
        }
        
        [Then(@"a filter button shall be displayed for the Project Status of Won")]
        public void ThenAFilterButtonShallBeDisplayedForTheProjectStatusOfWon()
        {
            driver.FindElement(By.Id("md-button-toggle-9-input")).Click();
            driver.FindElement(By.CssSelector("#md-button-toggle-9 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();

            Thread.Sleep(2000);
        }

        [Then(@"a filter button shall be displayed for the Project Status of Lost")]
        public void ThenAFilterButtonShallBeDisplayedForTheProjectStatusOfLost()
        {
            driver.FindElement(By.Id("md-button-toggle-14-input")).Click();
            driver.FindElement(By.CssSelector("#md-button-toggle-14 > label.mat-button-toggle-label > div.mat-button-toggle-label-content > span")).Click();

        }
        
       // [Then(@"each filter button other than Open shall be white with grey text to show not selected")]
        public void ThenEachFilterButtonOtherThanOpenShallBeWhiteWithGreyTextToShowNotSelected()
        {
           ScenarioContext.Current.Pending();
        }
    }
}
