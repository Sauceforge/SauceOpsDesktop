﻿using NUnit.Framework;
using Shouldly;
using System;
using UnitTests.RestAPI.FlowControl;
using UnitTests.RestAPI.RecommendedAppiumVersion;

namespace UnitTests
{
    [TestFixture]
    public class RestTests {
        static RestTests() {
            //Console.WriteLine(@"In RestTests static");
            Environment.SetEnvironmentVariable(SauceOpsConstants.SAUCE_USER_NAME, SauceOpsConstants.MY_USERNAME_LOWER);
            Environment.SetEnvironmentVariable(SauceOpsConstants.SAUCE_API_KEY, "");
        }

        [Test]
        [Ignore("Need OpenSauce")]
        public void FlowControlTest() {
            var flowController = new SauceLabsFlowController();
            //Console.WriteLine(@"RESTTests: About to call ControlFlow()");
            flowController.ControlFlow();
        }

        [Test]
        //[Ignore("Account has no minutes")]
        public void AppiumRecommendTest() {
            var statusNotifier = new SauceLabsAppiumRecommender();
            var version = statusNotifier.RecommendAppium();
            var components = version.Split('.');
            components.Length.ShouldBe(3);
            components[0].ShouldBeGreaterThanOrEqualTo("1");
            components[1].ShouldBeGreaterThanOrEqualTo("15");
            components[2].ShouldBeGreaterThanOrEqualTo("0");
        }
    }
}