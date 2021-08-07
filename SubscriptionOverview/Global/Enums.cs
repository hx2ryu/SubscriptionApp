using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionOverview.Global
{
    public enum IconType
    {
        #region Menu
        Search,
        Account,
        Check,
        Message,
        List,
        Setting,
        Bell,
        #endregion

        #region WindowState
        Close,
        Minimize,
        Maximize,
        #endregion

        Left,
        Right,

        ChevronLeft,
        ChevronRight,
    }

    public enum WindowStateTag
    {
        Minimize,
        Maximize,
        Close,
    }
}
