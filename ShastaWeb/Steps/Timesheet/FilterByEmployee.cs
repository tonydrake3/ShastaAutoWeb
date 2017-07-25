using System;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

namespace eSUBTests.Steps.Timesheet
{
    [Binding]
    public class FilterByEmployee: BaseSteps
    {
        [Given(@"the Project Manager is logged into Shasta,")]
        public void GivenTheProjectManagerIsLoggedIntoShasta()
        {
            NavigateTo("/#/login");

            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [When(@"the Project Manager expands the Time & Expense option on the left sidebar menu by clicking on the dropdown icon,")]
        public void WhenTheProjectManagerExpandsTheTimeExpenseOptionOnTheLeftSidebarMenuByClickingOnTheDropdownIcon()
        {
            driver.FindElement(By.CssSelector("li.open > i.material-icons.icon-has-ul")).Click();
            driver.FindElement(By.Name("New Timesheet"));

            Thread.Sleep(3000);
        }

        [Then(@"selects the Employee filter in the upper right corner,")]
        public void ThenSelectsTheEmployeeFilterInTheUpperRightCorner()
        {
            driver.FindElement(By.XPath("//body[@id='body']/esub-root/div[2]/esub-app-home/esub-app-sidenav/nav/section[2]/esub-app-sidenav-menu/div/ul/li[4]/ul/li/a/span/span")).Click();

        }

        //[Then(@"the Timesheets view is displayed via the employee,")]
        //public void ThenTheTimesheetsViewIsDisplayedViaTheEmployee()
        //{
            
        //}
        
        //[Then(@"the Timesheets view shall contain Timecards with hours associated with the selected Employee")]
        //public void ThenTheTimesheetsViewShallContainTimecardsWithHoursAssociatedWithTheSelectedEmployee()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
