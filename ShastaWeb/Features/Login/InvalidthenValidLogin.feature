Feature: InvalidthenValidLogin
	

@SmokeTest

Scenario: Valid login after incorrect Login
	Given a user navigates to the Login page at esub.com 
	When the User enters an invalid User Name or Password
	And corrects the errors with a valid Email and Password
	Then the User shall be logged in
