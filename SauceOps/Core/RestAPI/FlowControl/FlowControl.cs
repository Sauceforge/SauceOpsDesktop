﻿namespace SauceOps.Core.RestAPI.FlowControl {
    public class FlowControl {
        public Remaining remaining { get; set; }
    }

    public class Remaining {
        public int overall { get; set; }
        public int mac { get; set; }
        public int manual { get; set; }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th January 2020
 * 
 */