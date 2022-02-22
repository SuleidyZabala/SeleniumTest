using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumtest
{
 class program
{
    public static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.mercadolibre.com.bo/#from=homecom");
        driver.Manage().Window.Maximize();

            //////////PRODUCTO #1//////////////////////////////////////////////////

            IWebElement input = driver.FindElement(By.Id("cb1-edit"));
            input.SendKeys("Reloj Smart");

            IWebElement btnsearch = driver.FindElement(By.Id("cb1-edit"));
            btnsearch.Submit();
            

            driver.Close();


            //////////PRODUCTO #2//////////////////////////////////////////////////
            IWebDriver driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("https://www.mercadolibre.com.bo/#from=homecom");
            driver2.Manage().Window.Maximize();


            IWebElement input2 = driver2.FindElement(By.Id("cb1-edit"));
            input2.SendKeys("Toyota Hilux");

            IWebElement btnsearch2 = driver2.FindElement(By.Id("cb1-edit"));
            btnsearch2.Submit();

            driver2.Close();


            //////////PRODUCTO #3//////////////////////////////////////////////////
            IWebDriver driver3 = new ChromeDriver();
            driver3.Navigate().GoToUrl("https://www.mercadolibre.com.bo/#from=homecom");
            driver3.Manage().Window.Maximize();


            IWebElement input3 = driver3.FindElement(By.Id("cb1-edit"));
            input3.SendKeys("Celulares Huawei");

            IWebElement btnsearch3 = driver3.FindElement(By.Id("cb1-edit"));
            btnsearch3.Submit();

            driver3.Close();



    
        }

    }
}


