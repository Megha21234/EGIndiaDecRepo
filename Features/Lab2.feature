@Sprint3
Feature: Lab2

A short summary of the feature

Feature: XYZBank
 
A short summary of the feature
 
Background: 
	Given : User in on login page
@sanity
Scenario:Customer Login
	When Customer clicks on Customer Login button
	And selects the name
	And User Clicks on login button
	Then User is logged in and can see data


@regression
Scenario: Manager login to add a customer
	When Manager clicks on Manager Login buttons
	And Manager clicks the add customer1
	And Manager enters "<firstname>", "<lastname>", and "<postcode>" in the text fields1
	Then manager click the button1
   
    Examples:
      | firstname | lastname | postcode |
      | John      | Doe      | 572451   |
      | Jane      | Smith    | 567863   |

      
@regression
Scenario: Manager login to open account
	When Manager click on Manager login button
	And Manager clicks the open account
	And selects the customer name
	And selects the currency
	Then manager clicks the process

@sanity
Scenario:Manager login to click customers
      When Manager clicks the manager login button
	  Then Manager clicks the customer button
      