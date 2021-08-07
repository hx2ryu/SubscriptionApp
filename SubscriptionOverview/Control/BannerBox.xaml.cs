using SubscriptionOverview.Control.Model;
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
    /// Interaction logic for BannerBox.xaml
    /// </summary>
    public partial class BannerBox : UserControl
    {
        public BannerBox()
        {
            InitializeComponent();
        }

        public SolidColorBrush BannerBackground { get; set; }
        public SolidColorBrush BannerBorderBrush { get; set; }
        public List<BannerBoxModel> ContentList { get; set; }
        
        public new BannerBoxModel Content
        {
            get { return (BannerBoxModel)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static new readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content",
                typeof(BannerBoxModel),
                typeof(BannerBox),
                new PropertyMetadata());

    }
}
