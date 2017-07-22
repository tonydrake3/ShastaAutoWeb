Feature: ProjectNavigation
	

@Project
@FunctionalTests

Scenario: ProjectNavigation

Given the user has selected a project, the side menu should display the text 'Change Project'
Then the user clicks on 'Change Project' and the text 'Select Project' should display
