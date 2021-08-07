﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionOverview.Global
{
    public class WindowStateChangedEventArgs : EventArgs
    {
        public WindowStateChangedEventArgs(WindowStateTag actionToBeRequest)
        {
            ActionToBeRequest = actionToBeRequest;
        }

        public WindowStateTag ActionToBeRequest { get; }
    }
}
