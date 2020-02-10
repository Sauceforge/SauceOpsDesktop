﻿using System;

namespace SauceOps.Core.Util {
    public static class Enviro {
        internal static string SauceNativeApp
        {
            get { return GetStringVar(SauceOpsConstants.SAUCE_NATIVE_APP); }
        }

        internal static string SauceUserName
        {
            get { return GetStringVar(SauceOpsConstants.SAUCE_USER_NAME); }
        }

        internal static string SauceApiKey
        {
            get { return GetStringVar(SauceOpsConstants.SAUCE_API_KEY); }
        }

        public static string SauceOnDemandBrowsers
        {
            get { return GetStringVar(SauceOpsConstants.SAUCE_ONDEMAND_BROWSERS); }
        }

        internal static bool SauceUseChromeOnAndroid
        {
            get { return GetBoolVar(SauceOpsConstants.SAUCE_USE_CHROME_ON_ANDROID); }
        }

        internal static string BuildNumber
        {
            get
            {
                var jenkins = JenkinsBuildNumber;
                return !string.IsNullOrEmpty(jenkins) ? jenkins : BambooBuildNumber;
            }
        }

        public static string RecommendedAppiumVersion
        {
            get { return GetStringVar(SauceOpsConstants.RECOMMENDED_APPIUM_VERSION); }
        }

        public static void SetVar(string variableName, string value) {
            if (GetStringVar(variableName) == null) {
                //Set it
                Environment.SetEnvironmentVariable(variableName, value);
            }
        }

        private static string JenkinsBuildNumber
        {
            get { return GetStringVar(SauceOpsConstants.JENKINS_BUILD_NUMBER); }
        }

        private static string BambooBuildNumber
        {
            get { return GetStringVar(SauceOpsConstants.BAMBOO_BUILD_NUMBER); }
        }

        private static string GetStringVar(string envVar) {
            return envVar == null ? null : Environment.GetEnvironmentVariable(envVar);
        }

        private static bool GetBoolVar(string envVar) {
            var v = GetStringVar(envVar);
            return v != null && Convert.ToBoolean(v);
        }

        private static int GetIntVar(string envVar) {
            var v = GetStringVar(envVar);
            return v == null ? 0 : Convert.ToInt32(v);
        }

        private static double GetDoubleVar(string envVar) {
            var v = GetStringVar(envVar);
            return v == null ? 0 : Convert.ToDouble(v);
        }
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */