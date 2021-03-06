﻿using RestSharp;
using SauceOps.Core.RestAPI.TestStatus.Base;
using SauceOps.Core.Util;

namespace SauceOps.Core.RestAPI.TestStatus {
    public class SauceLabsStatusNotifier : StatusNotifier {
        public override void NotifyStatus(string jobId, bool isPassed) {
            var request = BuildRequest(string.Format(SauceOpsConstants.JOB_REQUEST, UserName, jobId), Method.PUT);
            request.AddParameter("Application/Json", "{\"passed\":" + "\"" + (isPassed ? "true" : "false") + "\"}", ParameterType.RequestBody);
            EnsureExecution(request);
            //Client.Execute(request);


        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th January 2020
 * 
 */