Feature: Project Management MenuDropdown
	To view the project management dropdown 
	As a User 
	I must have a company name / project
	

@ProjectTest
Scenario: Menu Dropdown
	Given a user has a selected a company/account
	When the User selects a project 
	Then Shasta shall display the Project Management menu expanded in the left sidebar
	



