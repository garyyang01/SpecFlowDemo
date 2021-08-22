Feature: Tennis
	Tennis Score Display Helper

@mytag
Scenario: playerA 0 and playerB 0 
	Given playerA 0 and playerB 0
	When Get display score
	Then the display score should be Love All

Scenario: playerA 1 and playerB 0 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Fifteen Love