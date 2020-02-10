using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SauceOps.Core.Util;

namespace SauceOps.Core.Driver {
    public class SauceryAndroidDriver : AndroidDriver<IWebElement> {
        public SauceryAndroidDriver(DriverOptions options)
            : base(new Uri(SauceOpsConstants.SAUCELABS_HUB), options) {
        }

        public SauceryAndroidDriver(Uri remoteAddress, DriverOptions options)
            : base(remoteAddress, options, TimeSpan.FromSeconds(400)) {
        }

        public string GetSessionId() {
            return SessionId.ToString();
        }

        //public override AppiumWebElement ScrollTo(string text) {
        //    throw new NotImplementedException();
        //}

        //public override AppiumWebElement ScrollToExact(string text) {
        //    throw new NotImplementedException();
        //}
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */