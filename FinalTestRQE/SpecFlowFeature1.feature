Feature: SpecFlowFeature1
	In order to calculate Angles
	As a User
	I want to calculate Sinus Tangens and Cosinus of a number

@mytag
Scenario: Calculate Sin, Cos, Tan
	Given the number to transform is Math.Pi
	When the number is transformed
	Then Sin should be 0
	And Cos should be -1
	And Tan should be 0