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
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }



        [TestMethod]
        public void TestThatAPICanAdd()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var addRadioButton = _driver.FindElement(By.CssSelector("input[value=Add]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            addRadioButton.Click();
            number1.SendKeys("5");
            number2.SendKeys("6");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("11", output.Text);
        }

        [TestMethod]
        public void TestThatAPICanSubtract()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var subtractRadioButton = _driver.FindElement(By.CssSelector("input[value=Subtract]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            subtractRadioButton.Click();
            number1.SendKeys("10");
            number2.SendKeys("6");

            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("4", output.Text);
        }

        [TestMethod]
        public void TestThatAPICanMultiply()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var subtractRadioButton = _driver.FindElement(By.CssSelector("input[value=Multiply]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            subtractRadioButton.Click();
            number1.SendKeys("10");
            number2.SendKeys("6");

            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual("60", output.Text);
        }


        [TestMethod]
        public void TestThatAPICanDivide()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var subtractRadioButton = _driver.FindElement(By.CssSelector("input[value=Divide]"));
            var form = _driver.FindElement(By.CssSelector("form"));

            subtractRadioButton.Click();
            number1.SendKeys("12");
            number2.SendKeys("6");

            form.Submit();

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
