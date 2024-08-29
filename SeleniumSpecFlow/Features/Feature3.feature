Feature: Feature3

Search for the Tests Talk

@TesterTalk
Scenario Outline: Search for multiple information
	Given Open the browser
	When Enter the URL
	Then Search for the <searchText> text
Examples:
	| searchText |
	| Selenium   |
	| Specflow   |