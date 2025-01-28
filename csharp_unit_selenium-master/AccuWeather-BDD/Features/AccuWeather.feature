Feature: See the temperature in different places

Background: 
	When I go to the Main page
	And I consent data usage
	Then The data usage banner is dissmissed

Scenario: Search specific city
	When I input 'New York' in the search field
	Then The search results list is displayed
	When I click on the '1'st search result
	Then The city weather page header contains the city name 'New York'

Scenario: Search in recent locations
	When I input 'London' in the search field
	And I click on the '1'st search result
	And I go to the Main page
	Then Main page is displayed
	When I choose the first city in Recent locations
	Then The city weather page header contains the city name 'London'

Scenario: Current location label is displayed
	When I click the search field
	Then The 'Use your current location' label is displayed

Scenario: Change temperature measurement units
	When I go to the Main page
	Then The temperature is indicated in 'C' units
	When I click on the header menu
	And I click on the Settings link
	Then The settings page is displayed
	When I select 'Imperial' units
	And I go to the Main page
	Then The temperature is indicated in 'F' units