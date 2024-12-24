using System;
using System.Security.Policy;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParallelExecutionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public ParallelExecutionStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"user is on the application page on IE browser")]
        public void GivenUserIsOnTheApplicationPageOnIEBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Console.WriteLine("user is on IE browser");
        }

        [Given(@"user is on the application page on FF browser")]
        public void GivenUserIsOnTheApplicationPageOnFFBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Console.WriteLine("user is on FF browser");
        }

        [Given(@"user is on the application page for Edge browser")]
        public void GivenUserIsOnTheApplicationPageForEdgeBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Console.WriteLine("user is on Edge browser");
        }
    }
}

