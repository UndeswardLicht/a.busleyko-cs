Feature: TwoCarsSideBySideComparison

Background: 
	Given Accept the banner conditions to remove it
    When I go to Research & Reviews page
    Then Research & Reviews page is displayed

Scenario: Two trims don't change their properties when compared side by
			When I create 'carA' to store Car object there
            And I select 'FIAT' in Make dropdown as 'carA'
            And I select '500' in Model dropdown as 'carA'
            And I select '2012' in Year dropdown as 'carA'
            And Click Research button
            Then Car description page is displayed
            When I select the very first trim of the car
            Then Model description page is displayed
            And The price for that model of the 'carA' is remembered

            When I go back to Main page
            And I go to Research & Reviews page
            Then Research & Reviews page is displayed
			When I create 'carB' to store Car object there
            And I select 'BMW' in Make dropdown as 'carB'
            And I select '128' in Model dropdown as 'carB'
            And I select '2013' in Year dropdown as 'carB'
            And Click Research button
            Then Car description page is displayed
            When I select the very first trim of the car
            Then Model description page is displayed
            And The price for that model of the 'carB' is remembered

            When I go to Research & Reviews page
            And I click Compare Cars Side-By-Side link
            Then Compare Cars Side By Side page is displayed
            When I select 'FIAT' in Make dropdown in '1' box
            And I select '500' in Model dropdown in '1' box
            And I select '2012' in Year dropdown in '1' box
            When I select 'BMW' in Make dropdown in '2' box
            And I select '128' in Model dropdown in '2' box
            And I select '2013' in Year dropdown in '2' box
            And I click See the comparison button
            Then Your cars comparison page is displayed
            And The price for the '1' car is the same as it was remembered for the 'carA' 
            And The price for the '2' car is the same as it was remembered for the 'carB' 

Scenario Outline: Used car is cheaper than a brand new one of the same trim
	When I select '<maker>' in Make dropdown
	And I select '<model>' in Model dropdown 
	And I select '<year>' in Year dropdown
	And I create '<specificCar>' with values '<maker>', '<model>', '<year>' to store data of a Car
	And Click Research button
	Then Car description page is displayed
	When I remember the very first trim of the '<specificCar>'
	And I select the very first trim of the car
	Then Model description page is displayed
	And The price for that model of the '<specificCar>' is remembered

	When I go to Cars for Sale page
	Then Cars for Sale page is displayed
	When I select 'Used' in Stock Type dropdown on Cars for Sale page
	And I select '<maker>' in Make dropdown on Cars for Sale page
	And I select '<model>' in Model dropdown on Cars for Sale page
	And I select 'No max price' in Price dropdown on Cars for Sale page
	And I select '20 miles' in Radius dropdown on Cars for Sale page
	And I enter '10001' in ZIP field on Cars for Sale page
	And I click Search button
	Then Cars for Sale results page is displayed
	And At least one car is found
    When I check the checkbox with the trim of the remembered '<specificCar>' in the filters on the left 
	And I select '<min year>' in Min year dropdown in the filters on the left
	And I select '<max year>' in Max year dropdown in the filters on the left
	Then At least one car is found
	When I retrieve the price of the found car
	Then The price of the found used car is lower than the price of the remembered '<specificCar>'

	Examples:
    | maker | model | year | min year | max year | specificCar |
    | FIAT  | 500   | 2012 | Oldest   | Newest   | carA        |
    | BMW   | 128   | 2013 | Oldest   | Newest   | carB        |
