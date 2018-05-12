using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFramework
{
    public static class WebElementExtension
    {
        private static IJavaScriptExecutor JSDriver { get; set; }

        public static void HighlightElement(RemoteWebDriver driver, IWebElement element)
        {
            JSDriver = driver;
            var highlightJavascript = @"arguments[0].style.cssText = ""color: red; border: 2px dotted red; border-spacing: 10px; background-color: yellow"";";
            JSDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }

        public static void UnHighlightElement(RemoteWebDriver driver, IWebElement element)
        {
            JSDriver = driver;
            var unHighlightJavascript = @"arguments[0].style.cssText = """";";
            JSDriver.ExecuteScript(unHighlightJavascript, new object[] { element });
        }
    }
}
