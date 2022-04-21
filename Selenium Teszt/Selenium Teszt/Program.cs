﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Teszt
{
    class Program
    {
        static void Main(string[] args) {

            IWebDriver driver = new FirefoxDriver();
                
            driver.Url = "https://citromail.hu";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.FindElement(By.Name("user")).SendKeys("seleniumuser");
            //driver.FindElement(By.Name("passwd")).SendKeys("Selenium_12"+Keys.Enter);
            driver.FindElement(By.Name("passwd")).SendKeys("Selenium_12");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div/div/form/button")).Click();

            


            Console.ReadKey();
        }
    }
}
