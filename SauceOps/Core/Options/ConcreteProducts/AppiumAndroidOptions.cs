using System;
using OpenQA.Selenium.Appium;
using SauceOps.Core.Options.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Options.ConcreteProducts
{
    internal class AppiumAndroidOptions : BaseOptions {
        public AppiumAndroidOptions(SaucePlatform platform, string testName)
            : base(testName)
        {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.ANDROID_ON_APPIUM);
            var sanitisedLongVersion = platform.SanitisedLongVersion();
            AddSauceLabsOptions(Enviro.SauceNativeApp);

            DebugMessages.PrintAndroidOptionValues(platform, sanitisedLongVersion);

            Console.WriteLine("Creating Android Options");
            Opts = new AppiumOptions();
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, sanitisedLongVersion);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.CHROME_BROWSER);  //Required
            //Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.ANDROID);
            
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_OPTIONS_CAPABILITY, SauceOptions);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */