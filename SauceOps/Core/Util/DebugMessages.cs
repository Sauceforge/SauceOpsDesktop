using System;
using SauceOps.Core.DataSources;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Options;

namespace SauceOps.Core.Util {
    public class DebugMessages {
        //public static void PrintPlatformDetails(PlatformTestData platform) {
        //    if (UserChecker.ItIsMe())
        //    {
        //        Console.WriteLine("DEBUG MESSAGE START");
        //        Console.WriteLine(@"SELENIUM_OS=" + platform.Os);
        //        Console.WriteLine(@"SELENIUM_BROWSER=" + platform.BrowserName);
        //        Console.WriteLine(@"SELENIUM_VERSION=" + platform.BrowserVersion);
        //        Console.WriteLine(@"SELENIUM_LONG_VERSION=" + platform.LongVersion);
        //        Console.WriteLine(@"SELENIUM_DEVICE_TYPE=" + platform.DeviceType);
        //        Console.WriteLine(@"SELENIUM_DEVICE=" + platform.Device);
        //        Console.WriteLine("DEBUG MESSAGE END");
        //    }
        //}
		internal static void PrintHaveDesktopPlatform()
        {
            if (UserChecker.ItIsMe())
            {
                Console.WriteLine("DEBUG MESSAGE: We have a desktop platform");
                Console.Out.Flush();
            }
        }

        internal static void PrintHaveAndroidPlatform()
        {
            if (UserChecker.ItIsMe())
            {
                Console.WriteLine("DEBUG MESSAGE: We have an Android platform");
                Console.Out.Flush();
            }
        }

        internal static void PrintHaveApplePlatform()
        {
            if (UserChecker.ItIsMe())
            {
                Console.WriteLine("DEBUG MESSAGE: We have an Apple platform");
                Console.Out.Flush();
            }
        }

        public static void ExtractJsonSegment(string json, int startIndex, int endIndex) {
            if (UserChecker.ItIsMe())
            {
                Console.WriteLine("DEBUG MESSAGE: ExtractJsonSegment params {0} {1} {2}", json, startIndex, endIndex);
                Console.Out.Flush();
            }
        }

        public static void PrintDesktopOptionValues(SaucePlatform platform)
        {
            if (UserChecker.ItIsMe())
            {
                Console.WriteLine("Desktop platform.Browser: {0}", platform.Browser);
                Console.WriteLine("Desktop platform.Os: {0}", platform.Os);
                Console.WriteLine("Desktop platform.BrowserVersion: {0}", platform.BrowserVersion);
            }
        }

        public static void PrintiOSOptionValues(SaucePlatform platform)
        {
            Console.WriteLine("{0}:{1}\n{2}:{3}\n{4}:{5}\n{6}:{7}\n{8}:{9}\n{10}:{11}",
                              SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.Device,
                              SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation,
                              SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.BrowserVersion,
                              SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.IOS_PLATFORM,
                              SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.SAFARI_BROWSER,
                              //SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.Device
                              //SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_DEVICE : SauceOpsConstants.IPAD_DEVICE
                              SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_SIMULATOR : SauceOpsConstants.IPAD_SIMULATOR
                              );
        }

        public static void PrintAndroidOptionValues(SaucePlatform platform, string sanitisedLongVersion)
        {
            Console.WriteLine("{0}:{1}\n{2}:{3}\n{4}:{5}\n{6}:{7}\n{8}:{9}",
                              SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName,
                              SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation,
                              SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.CHROME_BROWSER,
                              SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, sanitisedLongVersion,
                              SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.ANDROID);
        }
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 25th January 2020
 * 
 */