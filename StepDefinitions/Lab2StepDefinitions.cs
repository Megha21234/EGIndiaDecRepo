using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{

    [Binding]
        public class Lab2StepDefinitions

        {

            private ScenarioContext _scenarioContext;

            private IWebDriver _driver;

            public Lab2StepDefinitions(ScenarioContext scenarioContext)

            {

                _scenarioContext = scenarioContext;

                _driver = _scenarioContext["WebDriver"] as IWebDriver;

            }

            [Given(@": User in on login page")]

            public void GivenUserInOnLoginPage()

            {

                _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");

                _driver.Manage().Window.Maximize();

                Thread.Sleep(2000);

            }

            [When(@"Customer clicks on Customer Login button")]

            public void WhenCustomerClicksOnButton()

            {

                IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));

                CustLogin.Click();
                 Thread.Sleep(1000);

            }

            [When(@"selects the name")]

            public void WhenSelectsTheName()

            {

                IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));

                NamesDropDown.Click();

                var select = new SelectElement(NamesDropDown);

                Thread.Sleep(2000);

                //select by value

                select.SelectByText("Harry Potter");

                Thread.Sleep(2000);

            }

            [When(@"User Clicks on login button")]

            public void WhenUserClicksOnLoginButton()

            {

                IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));

                NamesDropDown.Click();
            Thread.Sleep(2000);

            }

            [Then(@"User is logged in and can see data")]

            public void ThenUserIsLoggedInAndCanSeeData()

            {

                Console.WriteLine("Customer Logged In");

            }
        [When(@"Manager clicks on Manager Login buttons")]
        public void WhenManagerClicksOnManagerLoginButton()
        {
            IWebElement Managerlogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));

            Managerlogin.Click();
            Thread.Sleep(1000);
        }

        [When(@"Manager clicks the add customer1")]
        public void WhenManagerClicksTheAddCustomer()
        {
            IWebElement addcustomer = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));

            addcustomer.Click();
            Thread.Sleep(1000);
        }

        [When(@"Manager enters ""([^""]*)"", ""([^""]*)"", and ""([^""]*)"" in the text fields1")]
        public void WhenManagerEntersAndInTheTextFields(string firstname, string lastname, string postcode)
        {
            _driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(firstname);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(lastname);
            Thread.Sleep(1000);
            _driver.FindElement(By.XPath("//input[@placeholder='Post Code']")).SendKeys(postcode);
            Thread.Sleep(1000);
        }

        [Then(@"manager click the button1")]
        public void ThenCustomerClickTheButton()
        {
            IWebElement submit = _driver.FindElement(By.XPath("//button[@type='submit']"));

            submit.Click();
            Thread.Sleep(1000);
        }
           

        [When(@"Manager click on Manager login button")]
        public void WhenManagerClicksOnManagerLoginButton1()
        {
            IWebElement Managerlogin1 = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));

            Managerlogin1.Click();
            Thread.Sleep(1000);
        }

        [When(@"Manager clicks the open account")]
        public void WhenManagerClicksTheOpenAccount()
        {
            IWebElement openaccount = _driver.FindElement(By.XPath("//button[normalize-space()='Open Account']"));

            openaccount.Click();
            Thread.Sleep(1000);
        }

        [When(@"selects the customer name")]
        public void WhenSelectsTheCustomerName()
        {
            IWebElement CustomernamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));

            CustomernamesDropDown.Click();

            var selects = new SelectElement(CustomernamesDropDown);

            Thread.Sleep(2000);

            //select by value

            selects.SelectByText("Harry Potter");

            Thread.Sleep(2000);
        }

        [When(@"selects the currency")]
        public void WhenSelectsTheCurrency()
        {
            IWebElement CurrencyDropDown = _driver.FindElement(By.XPath("//select[@id='currency']"));

            CurrencyDropDown.Click();

            var selected = new SelectElement(CurrencyDropDown);

            Thread.Sleep(2000);

            //select by value

            selected.SelectByText("Dollar");

            Thread.Sleep(2000);
            //select[@id='currency']
        }

        [Then(@"manager clicks the process")]
        public void ThenManagerClicksTheProcess()
        {
            IWebElement process = _driver.FindElement(By.XPath("//button[normalize-space()='Process']"));

            process.Click();
            Thread.Sleep(1000);
        }
        [When(@"Manager clicks the manager login button")]
        public void WhenManagerClicksTheManagerLoginButton()
        {
            IWebElement Managerlogin2 = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));

            Managerlogin2.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Manager clicks the customer button")]
        public void ThenManagerClicksTheCustomerButton()
        {
            IWebElement customerlogin1 = _driver.FindElement(By.XPath("//button[normalize-space()='Customers']"));

            customerlogin1.Click();
            Thread.Sleep(1000);
        }


    }

}




//            [When(@"User clicks the Transaction button")]
//        public void WhenUserClicksTheTransactionButton()
//        {
//            var TransactionButton = _driver.FindElement(By.XPath("//button[normalize-space()='Transactions']"));
//            TransactionButton.Click();
//            Thread.Sleep(1000);
//        }

//        [When(@"User clicks the Deposite button")]
//        public void WhenUserClicksTheDepositeButton()
//        {
//            var DepositeButton = _driver.FindElement(By.XPath("//button[normalize-space()='Deposit']"));
//            DepositeButton.Click();
//            Thread.Sleep(1000);
//        }

//        [When(@"User clicks the Withdrwal button")]
//        public void WhenUserClicksTheWithdrwalButton()
//        {
//            var WithdrwalButton = _driver.FindElement(By.XPath("//button[normalize-space()='Withdrawl']"));
//            WithdrwalButton.Click();
//            Thread.Sleep(1000);
//        }
//    }
//}
