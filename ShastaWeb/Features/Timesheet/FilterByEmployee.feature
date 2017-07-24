Feature: Filter By Project
	To filter by Time or Employee
	To begin, we'll fitler by Time

@FilterByTime
@FunctionalTests

Scenario: Filter By Time

	Given the Project Manager is logged into Shasta,
	When the Project Manager selects the Time & Expense option on the left sidebar menu by clicking on the dropdown icon,
	When a Project Manager selects the Employee filter in the upper right corner,
	Then the Timesheets view is displayed via the employee,
	And the Timesheets view shall contain Timecards with hours associated with the selected Employee.
	