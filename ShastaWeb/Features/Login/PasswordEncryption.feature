Feature: PasswordEncryption
	For security testing
	When a password is entered
	It must be encrypted per keystroke

@SmokeTest
Scenario: Password Encryption
	Given I am on the eSUB Login Page
	When I login with the following company Username
		| Username    |
		| Manager@esub.com |
    Then I enter any password
		| Password |
		| Test1234 |
	Then I should see Encrypting characters immediately striking each key when I enter my password