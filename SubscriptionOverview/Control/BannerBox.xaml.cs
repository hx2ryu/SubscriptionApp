using SubscriptionOverview.Control.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Model.BannerBox> ContentCollection
        {
            get { return (ObservableCollection<Model.BannerBox>)GetValue(ContentCollectionProperty); }
            set 
            {
                SetValue(ContentCollectionProperty, value);
                if (value.Count > 0)
                {
                    Content = value[0];
                }
            }
        }

        public static readonly DependencyProperty ContentCollectionProperty =
            DependencyProperty.Register("ContentCollection",
                typeof(ObservableCollection<Model.BannerBox>),
                typeof(BannerBox),
                new PropertyMetadata());

        //private List<BannerBoxModel> contentCollection;

        //public List<BannerBoxModel> ContentCollection
        //{
        //    get { return contentCollection; }
        //    set 
        //    {
        //        contentCollection = value; 
        //    }
        //}

        public new Model.BannerBox Content
        {
            get { return (Model.BannerBox)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static new readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content",
                typeof(Model.BannerBox),
                typeof(BannerBox),
                new PropertyMetadata());
    }
}
