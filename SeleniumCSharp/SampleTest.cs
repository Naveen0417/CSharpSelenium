using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace SeleniumCSharp
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestMethod()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl("https://www.amazon.in");
                driver.Quit();
            }
        }
    }
}
