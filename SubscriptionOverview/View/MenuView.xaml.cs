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

namespace SubscriptionOverview.View
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public event EventHandler WindowStateChanged;

        public MenuView()
        {
            InitializeComponent();
        }

        private void OnClickWindowStateButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Tag is WindowStateTag tag)
                {
                    switch (tag)
                    {
                        case WindowStateTag.Minimize:
                            break;
                        
                        case WindowStateTag.Maximize:
                            break;
                        
                        case WindowStateTag.Close:
                            break;

                        default:
                            return;
                    }

                    WindowStateChanged?.Invoke(this, new WindowStateChangedEventArgs(tag));
                }
            }
        }
    }
}
