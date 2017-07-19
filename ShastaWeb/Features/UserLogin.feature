Feature: Log into eSub website

Background: 

Scenario: Encrypting Password Entry

	Given I am on the eSUB Login Page
	When I login with the following company Username
		| Username    |
		| Manager@esub.com |
    Then I enter any password
		| Password |
		| Test1234 |
	Then I should see Encrypting characters immediately striking each key when I enter my password

Scenario: Login with incorrect credentials
	Given I am on the eSUB Login Page
	When I Enter with the following company Username
		| Username    |
		| qa@test.com |
	Then I enter the incorrect Password
		| Password |
		| Test1276 |
	And I Click on the Submit Button
	Then I should see an error message

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
