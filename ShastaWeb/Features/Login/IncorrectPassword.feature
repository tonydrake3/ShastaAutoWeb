Feature: IncorrectPassword
	To receive an error when entering an incorrect Password

@SmokeTest

Scenario: Incorrect Passwword
	Given I am on the eSUB Sign In Page
	And I enter a correct UserName:
	| Username         |
	| Manager@esub.com |
	And I enter an incorrect Password:
	| Password |
	| tEst12345 |
	And I click on Sign In
	Then I should receive an error message 

