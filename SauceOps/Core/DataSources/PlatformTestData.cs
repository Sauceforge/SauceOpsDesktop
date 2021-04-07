using SauceOps.Core.OnDemand;
using System.Collections;

namespace SauceOps.Core.DataSources
{
    public class PlatformTestData {
        public static IEnumerable Platforms
        {
            get
            {
                ////Desktop Platforms
                yield return new SaucePlatform("Windows 10", "chrome", "latest", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "chrome", "88", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "chrome", "75", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "firefox", "87", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "firefox", "86", "", "", "", "", "", "");
                //yield return new SaucePlatform("macOS 10.15", "safari", "13.0", "", "", "", "", "", "");
                yield return new SaucePlatform("macOS 10.15", "safari", "13.1", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "internet explorer", "11.285", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "microsoftedge", "89.0", "", "", "", "", "", "");
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */