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
    /// Interaction logic for InvoiceCard.xaml
    /// </summary>
    public partial class HorizontalBarCard : UserControl
    {
        public HorizontalBarCard()
        {
            InitializeComponent();
        }

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",
                typeof(string),
                typeof(HorizontalBarCard),
                new PropertyMetadata());

        public string Content1
        {
            get { return (string)GetValue(Content1Property); }
            set { SetValue(Content1Property, value); }
        }

        public static readonly DependencyProperty Content1Property =
            DependencyProperty.Register("Content1",
                typeof(string),
                typeof(HorizontalBarCard),
                new PropertyMetadata());

        public string Content2
        {
            get { return (string)GetValue(Content2Property); }
            set { SetValue(Content2Property, value); }
        }

        public static readonly DependencyProperty Content2Property =
            DependencyProperty.Register("Content2",
                typeof(string), 
                typeof(HorizontalBarCard),
                new PropertyMetadata());

        public string Title2
        {
            get { return (string)GetValue(Title2Property); }
            set { SetValue(Title2Property, value); }
        }

        public static readonly DependencyProperty Title2Property =
            DependencyProperty.Register("Title2",
                typeof(string),
                typeof(HorizontalBarCard),
                new PropertyMetadata());
    }
}
