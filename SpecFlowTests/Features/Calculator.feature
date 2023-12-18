Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 25
	
@mytag
Scenario: Add two numbers
	Given the first number is 5
	And the second number is 5
	When the two numbers are added
	Then the result should be 10
		
@mytag
Scenario: Subtract two numbers
	Given the first number is 9
	And the second number is 5
	When the two numbers are subtracted
	Then the result should be 4
	
@mytag
Scenario: divide two numbers
	Given the first number is 6
	And the second number is 3
	When the two numbers are divided
	Then the result should be 2