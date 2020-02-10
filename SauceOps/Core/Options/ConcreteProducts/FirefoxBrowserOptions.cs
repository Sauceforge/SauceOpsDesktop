using System;
using SauceOps.Core.Options.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;
using OpenQA.Selenium.Firefox;

namespace SauceOps.Core.Options.ConcreteProducts {
    internal class FirefoxBrowserOptions : BaseOptions {
        public FirefoxBrowserOptions(SaucePlatform platform, string testName) : base(testName)
        {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.DESKTOP_ON_WEBDRIVER);

            DebugMessages.PrintDesktopOptionValues(platform);
            
            Console.WriteLine("Creating Firefox Options");
            var o = new FirefoxOptions
            {
                PlatformName = platform.Os,
                BrowserVersion = platform.BrowserVersion
            };
            o.AddAdditionalCapability(SauceOpsConstants.SAUCE_OPTIONS_CAPABILITY, SauceOptions, true);
            Opts = o;
        }
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */