using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace MiniBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.facebook.com/";
            string email = "jacob.ssfd@outlook.com";
            string pass = "Clave1234";
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Applications/Firefox.app/Contents/MacOS", "geckodriver");

            FirefoxDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);

            var emailEl = driver.FindElementById("email");
            emailEl.SendKeys(email);

            var passEl = driver.FindElementById("pass");
            passEl.SendKeys(pass);

            var loginEl = driver.FindElementByName("login");
            loginEl.Click();

            Thread.Sleep(3000);

            url = "https://m.facebook.com/freddyvega/posts/477465347083513";

            driver.Navigate().GoToUrl(url);
            var comentario = driver.FindElementByXPath("//*[@id='composerInput']");
            comentario.SendKeys("hola");
            var comentar = driver.FindElementByName("submit");
            Thread.Sleep(3000);

            comentar.Click();
            Thread.Sleep(2000);

            driver.Close();

        }
    }
}
