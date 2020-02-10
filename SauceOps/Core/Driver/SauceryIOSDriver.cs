using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Util;

namespace SauceOps.Core.Driver {
    public class SauceryIOSDriver : IOSDriver<IWebElement> {
        public SauceryIOSDriver(DriverOptions options)
            : base(new Uri(SauceOpsConstants.SAUCELABS_HUB), options, TimeSpan.FromSeconds(400)) {
        }

        public SauceryIOSDriver(Uri remoteAddress, DriverOptions options)
            : base(remoteAddress, options, TimeSpan.FromSeconds(400)) {
        }

        public string GetSessionId() {
            return SessionId.ToString();
        }

        //public override IOSElement ScrollTo(string text) {
        //    throw new NotImplementedException();
        //}

        //public override IOSElement ScrollToExact(string text) {
        //    throw new NotImplementedException();
        //}
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */