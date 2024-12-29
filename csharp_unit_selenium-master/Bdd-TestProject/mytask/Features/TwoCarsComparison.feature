Feature: TwoCarsSideBySideComparison

Background: 
	Given Go to Main page

Scenario: Two trims don't change their properties when compared side by 
	When I go to Research & Reviews page
	Then Research & Reviews page is displayed
	When I select "FIAT" in Make dropdown
	And I select "500" in Model dropdown
	And I select "2012" in Year dropdown
	And Click Research button
	Then Car description page is displayed
	When I select the very first trim of the car
	Then Model description page is displayed
	And The price for that model is remembered

	When I go back to Main page
	And I go to Research & Reviews page
	Then Research & Reviews page is displayed
	When I select "BMW" in Make dropdown
	And I select "128" in Model dropdown
	And I select "2013" in Year dropdown
	And Click Research button
	Then Car description page is displayed
	When I select the very first trim of the car
	Then Model description page is displayed
	And The price for that model is remembered

	When I go to Research & Reviews page
	And I click Compare Cars Side-By-Side link
	Then Compare Cars Side By Side page is displayed
	When I select "FIAT" in Make dropdown in "1" box
	And I select "500" in Model dropdown in "1" box
	And I select "2012" in Year dropdown in "1" box
	And I select "BMW" in Make dropdown in "2" box
	And I select "128" in Model dropdown in "2" box
	And I select "2013" in Year dropdown in "2" box
	And I click See the comparison button
	Then Your cars comparison page is displayed
	And The price for the carA is the same as it was remembered
	And The price for the carB is the same as it was remembered


Scenario: Used car is cheaper than a brand new one of the same trim
	When I go to Research & Reviews page
	Then Research & Reviews page is displayed
	When I select "FIAT" in Make dropdown
	And I select "500" in Model dropdown
	And I select "2012" in Year dropdown
	And Click Research button
	Then Car description page is displayed
	When I remember the very first trim of the car
	And I select the very first trim of the car
	Then Model description page is displayed
	And The price for that model is remembered

	When I go to Cars for Sale page
	Then Cars for Sale page is displayed
	When I select "Used" in Stock Type dropdown on Cars for Sale page
	And I select "FIAT" in Make dropdown on Cars for Sale page
	And I select "500" in Model dropdown on Cars for Sale page
	And I select "No max price" in Price dropdown on Cars for Sale page
	And I select "20 miles" in Radius dropdown on Cars for Sale page
	And I enter "10001" in ZIP field on Cars for Sale page
	And I click Search button
	Then Cars for Sale results page is displayed
	And At least one car is found
	When I check the checkbox with the remembered trim in the filters on the left 
	And I select "2012" in Min year dropdown on in the filters on the left 
	And I select "2012" in Max year dropdown on in the filters on the left 
	Then At least one car is found
	When I compare the price of the found car with the price of remembered car
	Then The price of the found used car is lower than the price of the remembered car