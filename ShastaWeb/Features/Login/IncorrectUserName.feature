Feature: IncorrectUserName
	To receive an error when entering an incorrect Username

@SmokeTest

@Browser:Chrome

Scenario: Incorrect UserName
	Given when I am on the eSUB sign in page
	When I enter an incorrect username:
	| Username      |
	| Test@esub.com |
	And I enter a correct Password:
	| Password |
	| Test1234 |
	Then I click on Sign In
	Then I should receive an error message
