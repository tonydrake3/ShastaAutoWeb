Feature: ProjectNavigation
	

@Project
@FunctionalTests

Scenario: ProjectNavigation
Given a user has a selected project
When the Left Sidebar is displayed
Then the Left Sidebar shall contain a Change Project menu item
Given a user has selected a project
When the user clicks the Change Project menu item
Then the Change Project menu title shall change to Select Project
And the Select Project page shall be displayed
