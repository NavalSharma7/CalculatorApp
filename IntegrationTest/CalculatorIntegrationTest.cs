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
            var form = _driver.FindElement(By.CssSelector("form"));


            number1.SendKeys("5");
            number2.SendKeys("6");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(11, output.Text);
        }

        [TestMethod]
        public void TestThatAPICanSubtract()
        {
            _driver.Navigate().GoToUrl("https://localhost:5001/");
            var number1 = _driver.FindElement(By.CssSelector("input[name=num1]"));
            var number2 = _driver.FindElement(By.CssSelector("input[name=num2]"));
            var form = _driver.FindElement(By.CssSelector("form"));


            number1.SendKeys("5");
            number2.SendKeys("6");

            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(-1, output.Text);
        }


        [TestCleanup]
        public void ShutDown()
        {
            _driver.Quit();
        }
    }
}
