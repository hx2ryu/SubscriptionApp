using SubscriptionOverview.Global;
using SubscriptionOverview.View;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace SubscriptionOverview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<IPageView> pageCollection;

        public MainWindow()
        {
            InitializeComponent();

            pageCollection = new()
            {
                new AnalyticsView() { Tag = PageType.Analytics, Visibility = Visibility.Hidden, },
                new CompanyBenefitsView() { Tag = PageType.CompanyBenefits, Visibility = Visibility.Hidden },
                new SurveysView() { Tag = PageType.Surveys, Visibility = Visibility.Hidden },
                new TimeTrackingView() { Tag = PageType.TimeTracking, Visibility = Visibility.Hidden },
                new OnboardingView() { Tag = PageType.Onboarding, Visibility = Visibility.Hidden },
                new SubscriptionView() { Tag = PageType.Subscription, Visibility = Visibility.Visible },
            };

            AddPagesIntoContainer();
        }

        private void AddPagesIntoContainer()
        {
            foreach (UIElement item in pageCollection)
            {
                PageContainer.Children.Add(item);
            }
        }

        private void OnMoveWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OnReceiveWindowStateToBeChanged(object sender, EventArgs e)
        {
            if (e is WindowStateChangedEventArgs args)
            {
                switch (args.ActionToBeRequest)
                {
                    case WindowStateTag.Minimize:
                        WindowState = WindowState.Minimized;
                        break;
                    
                    case WindowStateTag.Maximize:
                        WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                        break;
                    
                    case WindowStateTag.Close:
                        Close();
                        break;
                 
                    default:
                        break;
                }
            }
        }

        private void OnReceivePageToBeChanged(object sender, EventArgs e)
        {
            if (e is PageChangeRequestedEventArgs args)
            {
                foreach (IPageView candidateView in pageCollection)
                {
                    if (candidateView.Tag is PageType tag)
                    {
                        candidateView.Visibility = (tag == args.PageToBeChanged) ? Visibility.Visible : Visibility.Hidden;
                    }
                }
            }
        }
    }
}
