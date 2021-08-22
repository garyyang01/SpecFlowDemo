Feature: Calculator
	Simple calculator for adding two numbers

@MyCalculator
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@MyCalculator
Scenario: Add two numbers Case 2
	Given the first number is 50 and second number is 70
	When the two numbers are added
	Then the result should be 120