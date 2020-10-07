Feature: TM
	Login, Create, Edit, or Delete TM record
	
Background: 
	Given I login to the TurnUp
	And I navigate to the TM

Scenario Outline: T0 Verify multiple TM creation
	When I create entries using code: '<code>' and price: '<price>'
	Then I am able to verify with code: '<code>'
 	Examples: 
	| code           | price |
	| 20201004224101 | 10    |
	| 20201004224102 | 20    |

Scenario: T1 Verify the TM is created
	Given I click the create new button