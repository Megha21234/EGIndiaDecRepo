Feature: Test OrangeHRM Login functionality

A short summary of the feature

@tag1
Scenario: Verify login with valid credentials
	Given User is on the login page
	When User enters the Username and Password
	And User clicks on login butn
	Then User is navigated to home pg
