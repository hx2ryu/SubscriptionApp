using SubscriptionOverview.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SubscriptionOverview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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
    }
}
