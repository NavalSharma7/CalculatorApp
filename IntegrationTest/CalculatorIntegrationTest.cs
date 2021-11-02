using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IntegrationTest
{
    [TestClass]
    public class CalculatorIntegrationTest
    {
        IWebDriver _driver;

        [TestInitialize]

        public void Startup() {
            // set up selenium web driver with chrom config.
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }



        [TestMethod]
        public void TestThatAPPCanAdd()
        {

            // navigate to the page an input values 
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var addRadioButton = _driver.FindElement(By.CssSelector("input[value=Add]"));
            var form = _driver.FindElement(By.CssSelector("form"));


            // click om the add radio button and click submit. 
            addRadioButton.Click();
            number1.SendKeys("5");
            number2.SendKeys("6");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));

            // the result is matched with expected answer to test. 
            Assert.AreEqual("11", output.Text);
        }

        [TestMethod]
        public void TestThatAPPCanSubtract()
        { // navigate to the page an input values 
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var subtractRadioButton = _driver.FindElement(By.CssSelector("input[value=Subtract]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            // click om the subtract radio button and click submit. 
            subtractRadioButton.Click();
            number1.SendKeys("10");
            number2.SendKeys("6");

            form.Submit();
            // the result is matched with expected answer to test. 
            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("4", output.Text);
        }

        [TestMethod]
        public void TestThatAPPCanMultiply()
        {
            // navigate to the page an input values 
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var multiplyRadioButton = _driver.FindElement(By.CssSelector("input[value=Multiply]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            // click om the multiply radio button and click submit. 
            multiplyRadioButton.Click();
            number1.SendKeys("10");
            number2.SendKeys("6");

            form.Submit();
            // the result is matched with expected answer to test. 
            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("60", output.Text);
        }


        [TestMethod]
        public void TestThatAPPCanDivide()
        {
            // navigate to the page an input values 
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var divideRadioButton = _driver.FindElement(By.CssSelector("input[value=Divide]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            // click om the divide radio button and click submit. 
            divideRadioButton.Click();
            number1.SendKeys("12");
            number2.SendKeys("6");

            form.Submit();
            // the result is matched with expected answer to test. 
            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("2", output.Text);
        }

        [TestCleanup]
        public void ShutDown()
        {
            _driver.Quit();
        }
    }
}
