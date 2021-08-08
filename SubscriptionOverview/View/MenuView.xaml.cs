using SubscriptionOverview.Control.Model;
using SubscriptionOverview.Global;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SubscriptionOverview.View
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public event EventHandler WindowStateChanged;
        public event EventHandler PageChangeRequested;

        private int currentPageIndex;
        private readonly int lastPageIndex;

        public MenuView()
        {
            InitializeComponent();
            lastPageIndex = SubMenuContainer.Children.Count - 1;
        }

        private void OnClickWindowStateButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Tag is WindowStateTag tag)
                {
                    WindowStateChanged?.Invoke(this, new WindowStateChangedEventArgs(tag));
                }
            }
        }

        private void OnSelectMenuButton(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton selectedButton)
            {
                currentPageIndex = SubMenuContainer.Children.IndexOf(selectedButton);

                if (selectedButton.Tag is PageType type)
                {
                    PageChangeRequested?.Invoke(this, new PageChangeRequestedEventArgs(type));
                }
            }
        }

        private void OnReceiveNavigationTag(object sender, EventArgs e)
        {
            if (e is NavigationButtonClickedEventArgs args)
            {
                switch (args.Direction)
                {
                    case NavigationDirection.Left:
                        if (currentPageIndex > 0)
                        {
                            ChangePage(--currentPageIndex);
                        }
                        break;
                    
                    case NavigationDirection.Rgiht:
                        if (currentPageIndex < lastPageIndex)
                        {
                            ChangePage(++currentPageIndex);
                        }
                        break;
                 
                    default:
                        break;
                }
            }
        }

        private void ChangePage(int pageIndexToBeChanged)
        {
            UIElementCollection menuButtonCollection = SubMenuContainer.Children;

            for (int i = 0; i <= lastPageIndex; i++)
            {
                if (menuButtonCollection[i] is RadioButton btn)
                {
                    if (i == pageIndexToBeChanged)
                    {
                        btn.IsChecked = true;
                        break;
                    }
                }
            }
        }
    }
}
