using System;
using SauceOps.Core.Options.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;
using OpenQA.Selenium.Appium;

namespace SauceOps.Core.Options.ConcreteProducts {
    internal class AppiumIOSOptions : BaseOptions {
        public AppiumIOSOptions(SaucePlatform platform, string testName) : base(testName) {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.IOS_ON_APPIUM);
            AddSauceLabsOptions(Enviro.SauceNativeApp);

            DebugMessages.PrintiOSOptionValues(platform);

            Console.WriteLine("Creating iOS Options");
            Opts = new AppiumOptions();
            //Opts.AddAdditionalCapability(SauceryConstants.SAUCE_APPIUM_VERSION_CAPABILITY, Enviro.RecommendedAppiumVersion);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.Device);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.BrowserVersion);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.IOS_PLATFORM);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.SAFARI_BROWSER);

            //Opts.AddAdditionalCapability(SauceryConstants.SAUCE_DEVICE_CAPABILITY, platform.Device);
            //Opts.AddAdditionalCapability(SauceryConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceryConstants.IPHONE_DEVICE : SauceryConstants.IPAD_DEVICE);
            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_SIMULATOR : SauceOpsConstants.IPAD_SIMULATOR);

            Opts.AddAdditionalCapability(SauceOpsConstants.SAUCE_OPTIONS_CAPABILITY, SauceOptions);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */