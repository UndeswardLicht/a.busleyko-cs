Feature: TwoCarsSideBySideComparison

Scenario: Two trims don't change their properties when compared side by side
	Given an existing very first trim of car A is selected
	And the price of the very first trim of car A is remembered 
	And an existing very first trim of car B is selected
	And the price of the very first trim of car B is remembered 
	When I am on the the Main page and I go to the Research & Reviews page
	Then Research & Reviews page is displayed
	When I go click 'Compare cars' in 'Side-by-Side Comparisons' section
	Then the Side-By-Side Comparison page is displayed
	When I select car A in the first box
	And I select car B in the second box
	And I click 'Compare cars' button
	Then Your Car comparison page is displayed
	And Price of car A is the same as remembered
	And Price of car B is the same as remembered

@correct
Scenario: Used car is cheaper than a brand new one of the same trim
	Given An existing very first trim of car A is selected and remembered 
	And I am on the the Main Page 
	When I go to Cars for Sale page
	Then Cars for Sale page is displayed
	When I fill in the fields in the box by the "expected values"
	Then A car is found
	When I add Trim and Year of the car A to the searchbox
	Then A car is found
	When I compare the price of the found car with the price of the car A
	Then The found car is cheaper than the car A

@UI
@fail
Scenario: (Neg??) Used car is found
	Given An existing very first trim of car A is selected and remembered 
	And I am on the the Main Page 
	When I go to Cars for Sale page
	Then Cars for Sale page is displayed
	When I fill in the fields in the box by the "expected values"
	Then A car is found