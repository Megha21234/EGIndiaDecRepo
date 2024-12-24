using System;
using System.Xml.Linq;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Lab22StepDefinitions
    {
        private ScenarioContext _scenarioContext;

        private IWebDriver _driver;

        public Lab22StepDefinitions(ScenarioContext scenarioContext)

        {

            _scenarioContext = scenarioContext;

            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@": User in on login page1")]

        public void GivenUserInOnLoginPage()

        {

            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");

            _driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

        }
        [When(@"Manager clicks on Manager Login button")]
        public void WhenManagerClicksOnManagerLoginButton()
        {
            IWebElement Managerlogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));

            Managerlogin.Click();
            Thread.Sleep(1000);
        }

        [When(@"Manager clicks the add customer")]
        public void WhenManagerClicksTheAddCustomer()
        {
            IWebElement addcustomer = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));

            addcustomer.Click();
            Thread.Sleep(1000);
        }

        [When(@"Manager enters ""([^""]*)"", ""([^""]*)"", and ""([^""]*)"" in the text fields")]
        public void WhenManagerEntersAndInTheTextFields(string firstname, string lastname, string postcode)
        {
            _driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(firstname);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(lastname);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@placeholder='Post Code']")).SendKeys(postcode);
            Thread.Sleep(1000);
        }

        [Then(@"customer click the button")]
        public void ThenCustomerClickTheButton()
        {
            IWebElement submit = _driver.FindElement(By.XPath("//button[@type='submit']"));

            submit.Click();
            Thread.Sleep(1000);
        }
    }
}
