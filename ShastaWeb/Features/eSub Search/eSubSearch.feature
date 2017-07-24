Feature: eSubSearch
	to search for eSub via google

@SmokeTest


Scenario: eSUB Search
	Given I have navigated to google.com
	
	When I enter the keyword
	| keyword |
	| eSub    |
	Then i should see the following keyword
	| keyword |
	| eSub    |
