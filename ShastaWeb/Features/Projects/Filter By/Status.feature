Feature: Status
	In order to filter the list of projects by Status
	I must click on the filter buttons

@SmokeTest
Scenario: Filter By Status
	Given a User has logged into Shasta
	And the User has a selected Tenant/Company
	When the Project Selection page loads
	Then the Project Selection page shall contain a set of Status Filter buttons
	And the buttons shall be displayed at the upper left corner of the page
	And a filter button shall be displayed for the Project Status of Open
	And the Open filter button shall be grey with black text to show which status is selected
	And a filter button shall be displayed for the Project Status of Complete
	And a filter button shall be displayed for the Project Status of Bid
	And a filter button shall be displayed for the Project Status of Won
	And a filter button shall be displayed for the Project Status of Lost
	And each filter button other than Open shall be white with grey text to show not selected.
