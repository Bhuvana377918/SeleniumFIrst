using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFIrst
{
    class Program
    {
        //IWebPropertiesCollection.driver PropertiesCollection.driver = new ChromePropertiesCollection.driver();
        static void Main(string[] args)
        {
            
            
        }
        [SetUp]
        public void Initialize()
        {
            //PropertiesCollection.driver.Navigate().GoToUrl("http://www.google.co.in");
            //Console.WriteLine("Opened the browser");
            PropertiesCollection.driver.Navigate().GoToUrl("https://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }
        [Test]
        public void ExecuteTest()
        {

            //IWebElement element = PropertiesCollection.driver.FindElement(By.Name("q"));
            //element.SendKeys("Selenium");
            //Console.WriteLine("Executed Test");
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id);
            //Initial
            SeleniumSetMethods.EnterText("Initial", "Bhuvana", PropertyType.Name);
            Console.WriteLine("The value from my title is:" + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my initial is:" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
        [TearDown]
        public void CleanUp()
        {
            //PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
