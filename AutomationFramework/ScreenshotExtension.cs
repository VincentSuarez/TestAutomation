using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.IO;

namespace AutomationFramework
{
    public static class ScreenshotExtension
    {
        public static string TakeScreenshot(RemoteWebDriver driver, int imageCounter, string testResultDirectory)
        {
            var counter = imageCounter.ToString("000");
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var path = $"{testResultDirectory}{counter}.jpg";
            screenshot.SaveAsFile(path);
            return path;
        }

        public static string CreateTestResultsDirectory()
        {
            var dirDate = DateTime.Now.ToString("yyyy-MM-dd");
            var TestResultDirectory = Path.Combine(Directory.GetParent(@"../../../").FullName, @"TestResults\", dirDate);
            var dirTime = DateTime.Now.ToString("HH_mm_ss");
            TestResultDirectory = Path.Combine(TestResultDirectory, dirTime);
            Directory.CreateDirectory($"{TestResultDirectory}/");
            return TestResultDirectory;
        }
    }
}
