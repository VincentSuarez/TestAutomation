using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace AutomationFramework
{
    public static class BasePage
    {
        public static WebDriverWait Wait { get; set; }

        public static RemoteWebDriver GetInstance(RemoteWebDriver driver, ChromeOptions options)
        {
            if (driver == null)
            {
                driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
                if (driver != null)
                {
                    Console.WriteLine("Driver has been created");
                }
            }
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return driver;
        }

        public static RemoteWebDriver CloseDriver(RemoteWebDriver driver)
        {
            driver.Close();
            driver.Dispose();
            driver = null;
            Console.WriteLine("Driver has been closed");
            return driver;
        }

        public static void GoToUrl<T>(RemoteWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine($"Navigate to {url}");
        }

    }
}
