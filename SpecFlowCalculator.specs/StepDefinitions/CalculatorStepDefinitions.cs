using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]       // o binding indica que o SpecFlow vai utilizar essa classe p mapear os pontos do Gherkin (os Given,When,Then), igual ao Act/Theory do Unit Test.
    public sealed class CalculatorStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext; 

        private readonly Calculator _calculator = new Calculator();         // lógica para fazer o teste

        private int _result;                    // variável para guardar o resultado

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add(); 
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

            _result.Should().Be(result);         // utilizo a biblioteca do FluentAssertions para fazer verificações de resultados esperados de uma forma mais entendível e fluida
        }
    }
}