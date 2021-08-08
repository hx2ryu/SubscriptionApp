using System;

namespace SubscriptionOverview.Control.Model
{
    public enum NavigationDirection
    {
        Left,
        Rgiht,
    }

    public class NavigationButtonClickedEventArgs : EventArgs
    {
        public NavigationButtonClickedEventArgs(NavigationDirection direction)
        {
            Direction = direction;
        }

        public NavigationDirection Direction { get; }
    }
}
