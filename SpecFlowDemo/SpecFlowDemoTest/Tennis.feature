Feature: Tennis
	Tennis Score Display Helper

@0:0
Scenario: playerA 0 and playerB 0 
	Given playerA 0 and playerB 0
	When Get display score
	Then the display score should be Love All
@1:0
Scenario: playerA 1 and playerB 0 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Fifteen Love

@2:0
Scenario: playerA 2 and playerB 0 
	Given playerA 2 and playerB 0
	When Get display score
	Then the display score should be Thirty Love

@3:0
Scenario: playerA 3 and playerB 0 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Forty Love

@0:1
Scenario: playerA 0 and playerB 1 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Love Fifteen

@0:2
Scenario: playerA 0 and playerB 2 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Love Thirty

@0:3
Scenario: playerA 0 and playerB 3 
	Given playerA 1 and playerB 0
	When Get display score
	Then the display score should be Love Forty

@1:1
Scenario: playerA 1 and playerB 1 
	Given playerA 1 and playerB 1
	When Get display score
	Then the display score should be Fifteen All

@2:2
Scenario: playerA 2 and playerB 2 
	Given playerA 2 and playerB 2
	When Get display score
	Then the display score should be Thirty All

@3:3
Scenario: playerA 3 and playerB 3 
	Given playerA 3 and playerB 3
	When Get display score
	Then the display score should be Deuce

@4:4
Scenario: playerA 4 and playerB 4 
	Given playerA 4 and playerB 4
	When Get display score
	Then the display score should be Deuce


@4:3
Scenario: playerA 4 and playerB 3 
	Given playerA 4 and playerB 3
	When Get display score
	Then the display score should be Player A Adv

@5:3
Scenario: playerA 5 and playerB 3 
	Given playerA 5 and playerB 3
	When Get display score
	Then the display score should be Player A Win

@3:4
Scenario: playerA 3 and playerB 4 
	Given playerA 3 and playerB 4
	When Get display score
	Then the display score should be Player B Adv

@3:5
Scenario: playerA 3 and playerB 5 
	Given playerA 3 and playerB 5
	When Get display score
	Then the display score should be Player B Win