Feature: LoginSuccess
	In order to Login Successfully
	
	The Username and Password must be correct

@SmokeTest

Scenario: Login with correct credentials
	Given I am on the eSUB login page
	When I Enter with the following company Username
		| Username         |
		| Manager@eSub.com |
	Then I enter the correct Password
		| Password |
		| Test1234 |
	And I click on the Submit Button
	Then I should navigate to the Main Menu
