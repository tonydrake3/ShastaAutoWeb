using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace eSUBTests
{
    [Binding]
    public class ProjectNavigationSteps : BaseSteps
    {
        [Given(@"a user has a selected project")]
        public void GivenAUserHasASelectedProject()
        {
            NavigateTo("/#/project");
        }
        
        [Given(@"a user has selected a project")]
        public void GivenAUserHasSelectedAProject()
        {
            NavigateTo("/#/project");

        }

        [When(@"the Left Sidebar is displayed")]
        public void WhenTheLeftSidebarIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user clicks the Change Project menu item")]
        public void WhenTheUserClicksTheChangeProjectMenuItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Left Sidebar shall contain a Change Project menu item")]
        public void ThenTheLeftSidebarShallContainAChangeProjectMenuItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Change Project menu title shall change to Select Project")]
        public void ThenTheChangeProjectMenuTitleShallChangeToSelectProject()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Select Project page shall be displayed")]
        public void ThenTheSelectProjectPageShallBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
