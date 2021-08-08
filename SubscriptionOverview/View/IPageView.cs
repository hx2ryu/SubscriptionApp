using SubscriptionOverview.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubscriptionOverview.View
{
    interface IPageView
    {
        public object Tag { get; set; }
        public Visibility Visibility { get; set; }
    }
}
