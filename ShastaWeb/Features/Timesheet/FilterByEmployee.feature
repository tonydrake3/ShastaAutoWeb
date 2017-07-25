Feature: FilterByEmployee
	In order to filter by Employee to see their timecard
	The Project Manager must view timesheet and expenses 

@TimeSheet
@FunctionalTests
Scenario: Filter by Employee
	Given a Project Manager is logged into Shasta,
	When the Project Manager Selects on the Time & Expense Dropdown Icon,
	Then selects timesheets, the default filter is grouped by Employee and the timecards are displayed in full

