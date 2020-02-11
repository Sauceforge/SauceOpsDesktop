using OpenQA.Selenium;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Options.ConcreteCreators;

namespace SauceOps.Core.Options
{
    internal class OptionFactory {
        public static DriverOptions CreateOptions(SaucePlatform platform, string testName) {
            if (platform.IsADesktopPlatform()) {
                return GetDesktopOptions(platform, testName);
            }
            //Mobile Platform
            return platform.IsAnAppleDevice()
                    ? new AppiumIOSCreator().Create(platform, testName).GetOpts()
                    : new AppiumAndroidCreator().Create(platform, testName).GetOpts();
            //return platform.CanUseAppium()
            //    //Mobile Platform
            //    ? platform.IsAnAppleDevice()
            //        ? new AppiumIOSCreator().Create(platform, testName).GetOpts()
            //        : new AppiumAndroidCreator().Create(platform, testName).GetOpts()
            //    //Devolve to WebDriver    
            //    : platform.IsAnAppleDevice()
            //        ? new WebDriverIOSCreator().Create(platform, testName).GetCaps()
            //        : new WebDriverAndroidCreator().Create(platform, testName).GetCaps();
        }

        private static DriverOptions GetDesktopOptions(SaucePlatform platform, string testName)
        {
            return (platform.Browser.ToLower()) switch
            {
                "firefox" => new FirefoxCreator().Create(platform, testName).GetOpts(),
                "internet explorer" => new IECreator().Create(platform, testName).GetOpts(),
                "microsoftedge" => new EdgeCreator().Create(platform, testName).GetOpts(),
                "chrome" => new ChromeCreator().Create(platform, testName).GetOpts(),
                "safari" => new SafariCreator().Create(platform, testName).GetOpts(),
                _ => new ChromeCreator().Create(platform, testName).GetOpts(),
            };
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */