using System;
using TechTalk.SpecFlow;

namespace eSUBTests.Steps.Timesheet
{
    [Binding]
    public class FilterByProjectSteps
    {
        [Given(@"the Project Manager is logged into Shasta,")]
        public void GivenTheProjectManagerIsLoggedIntoShasta()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the Project Manager expands the Time & Expense option on the left sidebar menu by clicking on the dropdown icon,")]
        public void WhenTheProjectManagerExpandsTheTimeExpenseOptionOnTheLeftSidebarMenuByClickingOnTheDropdownIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"selects the Employee filter in the upper right corner,")]
        public void ThenSelectsTheEmployeeFilterInTheUpperRightCorner()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Timesheets view is displayed via the employee,")]
        public void ThenTheTimesheetsViewIsDisplayedViaTheEmployee()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Timesheets view shall contain Timecards with hours associated with the selected Employee")]
        public void ThenTheTimesheetsViewShallContainTimecardsWithHoursAssociatedWithTheSelectedEmployee()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
