Feature: Company
	Login, Create, Edit, or Delete Company record
	
Background: 
	Given I login to the TurnUp for Company
	And I navigate to the Company

@company
#limit Azure only execute this feature.
Scenario: T1 Verify the Company is created
	Given I click the create new button for Company