Feature: ForgotPassword 
	In order to receive a new password
	Clicking the Forgot Password link will generate a new password

@SmokeTest

Scenario: ForgotPassword
	Given I have entered the correct UserName
	Then I forgot my password
	When I click on the link 'Forgot Password'
	Then I will receive a message that will allow me to reset my password
	And Once I reset my password
	And I navigate back to the sign in page 
	Then I will re-enter my new password
	Then Successfully sign in to my account
