﻿using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_tech_webapp_webjobs
{

    public class EmailDigestionsJobs
    {
        [Singleton]
        public static void SendOutWeeklyEmails([TimerTrigger(TimerConstants.EVERY_TWO_MINUTES, RunOnStartup = true)] TimerInfo timerinfo, ILogger logger)
        {
            logger.LogInformation($"Processing message: {DateTimeOffset.Now}");
        }
    }
}