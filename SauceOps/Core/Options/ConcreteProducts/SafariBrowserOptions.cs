using System;
using SauceOps.Core.Options.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;
using OpenQA.Selenium.Safari;

namespace SauceOps.Core.Options.ConcreteProducts {
    internal class SafariBrowserOptions : BaseOptions {
        public SafariBrowserOptions(SaucePlatform platform, string testName) : base(testName)
        {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.DESKTOP_ON_WEBDRIVER);

            DebugMessages.PrintDesktopOptionValues(platform);

            Console.WriteLine("Creating Safari Options");
            var o = new SafariOptions
            {
                PlatformName = platform.Os,
                BrowserVersion = platform.BrowserVersion
            };
            o.AddAdditionalCapability(SauceOpsConstants.SAUCE_OPTIONS_CAPABILITY, SauceOptions);
            Opts = o;
        }
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */