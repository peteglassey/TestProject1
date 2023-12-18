using FluentAssertions;
using TestProjectCalculator;

namespace SpecFlowTests.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    private double _firstNumber = 0;
    private double _secondNumber = 0;
    private double _result = 0;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _firstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _secondNumber = number;
    }


    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        _result.Should().Be(result);
    }

    [When(@"the two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        _result = new Calculator().Multiply(_firstNumber, _secondNumber);
    }

    [When(@"the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = new Calculator().Add(_firstNumber, _secondNumber);
    }

    [When(@"the two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        _result = new Calculator().Subtract(_firstNumber, _secondNumber);
    }

    [When(@"the two numbers are divided")]
    public void WhenTheTwoNumbersAreDivided()
    {
        _result = new Calculator().Divide(_firstNumber, _secondNumber);
    }
}