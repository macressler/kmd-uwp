﻿using kmd.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalRateReminder;

namespace kmd.Services
{
    public static class RateAndFeedbackService
    {
        public static async Task CheckShowRateReminder()
        {
            RatePopup.ResetLaunchCount();
            RatePopup.LaunchLimit = 1;
            RatePopup.ResetCountOnNewVersion = true;
            RatePopup.RateButtonText = "RatePopup_RateButtonText".GetLocalized();
            RatePopup.CancelButtonText = "RatePopup_CancelButtonText".GetLocalized();
            RatePopup.Title = "RatePopup_Title".GetLocalized();
            RatePopup.Content = "RatePopup_Content".GetLocalized();
            var result = await RatePopup.CheckRateReminderAsync();
            if(result == RateReminderResult.Dismissed)
            {
                FeedbackPopup.ContactEmail = "aram.koch@gmail.com";
                FeedbackPopup.EmailSubject = "FeedbackPopup_EmailSubject".GetLocalized();
                FeedbackPopup.Title = "FeedbackPopup_Title".GetLocalized();
                FeedbackPopup.Content = "FeedbackPopup_Content".GetLocalized();
                FeedbackPopup.SendFeedbackButtonText = "FeedbackPopup_SendFeedbackButtonText".GetLocalized();
                FeedbackPopup.CancelButtonText = "FeedbackPopup_CancelButtonText".GetLocalized();
                await FeedbackPopup.ShowFeedbackDialogAsync();
            }
        }
    }
}
