using System;
using TechTalk.SpecFlow;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        Calculator calculator = new Calculator();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(result, expectedResult);
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = calculator.Substract();
        }

    }
}
