using SubscriptionOverview.Control.Model;
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

namespace SubscriptionOverview.Control
{
    /// <summary>
    /// Interaction logic for NavigatorButton.xaml
    /// </summary>
    public partial class NavigatorButton : UserControl
    {
        public event EventHandler NavigationButtonClicked;

        public NavigatorButton()
        {
            InitializeComponent();
        }

        public IconType Icon
        {
            get { return (IconType)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",
                typeof(IconType),
                typeof(NavigatorButton),
                new PropertyMetadata());

        private void OnClickToMove(object sender, RoutedEventArgs e)
        {
            if (sender is Button selectedButton)
            {
                if (selectedButton.Tag is NavigationDirection tag)
                {
                    NavigationButtonClicked?.Invoke(this, new NavigationButtonClickedEventArgs(tag));
                }
            }
        }
    }
}
