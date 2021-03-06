﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlapChat.Model
{

    // Please add your app secrets here and rename the file to
    // MobileServiceConfig.cs
    public class MobileServiceConfig
    {

        public static string ApplicationUri
        {
            get { return "Mobile Service URI"; }
        }

        public static string ApplicationKey
        {
            get { return "Mobile Service app key"; }
        }

        public static string LiveClientId
        {
            get { return "Live Connect Client ID"; }
        }

        public static string NotificationHubName
        {
            get { return "Notification Hub name"; }
        }

        public static Uri NotificationHubUri
        {
            get { return new Uri("http://notificationHubUri"); }
        }

        public static string NotificationHubKey
        {
            get { return "Notification Hub key"; }
        }

        public static string NotificationHubSecret
        {
            get { return "Notification Hub secret"; }
        }
    }

}
