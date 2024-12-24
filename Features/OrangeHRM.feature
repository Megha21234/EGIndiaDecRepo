@Sprint1
Feature: OrangeHRM
 
Test orange hrm website login functionality
 
 @Sanity
Scenario: Verify login for orange hrm website

	Given User is on the orange hrm login page

	When User enters the "<usrname>" and "<passwd>" in the text fields

	When User clicks on submit button

	Then User is navigated to home page
 
Examples: 

| usrname | passwd   |

| Admin   | admin123 |


@Regression
Scenario: Verify login for orange hrm website for invalid credentials

	Given User is on the orange hrm login page

	When User enters the "<usrname>" and "<passwd>" in the text fields

	When User clicks on submit button

	Then User is on home page and a error is dispalyed
 
Examples: 

| usrname | passwd   |

| Admin   | admin13 |

Scenario Outline:Verify login with test parameters
	When User enter the "<username>" and "<password>"
	And User clicks on login button
	Then user is navigated to home page
	Then User select city and country onformation
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |
	Examples: 
	| username | password |
	| tom      | Harry    |
	| jerry    | Mathew   |

 