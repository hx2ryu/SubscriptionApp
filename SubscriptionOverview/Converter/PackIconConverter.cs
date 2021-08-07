using MaterialDesignThemes.Wpf;
using SubscriptionOverview.Global;
using System;
using System.Globalization;
using System.Windows.Data;

namespace SubscriptionOverview.Converter
{
    public class PackIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is IconType type)
            {
                switch (type)
                {
                    case IconType.Search:
                        return PackIconKind.Magnify;

                    case IconType.Account:
                        return PackIconKind.AccountBoxOutline;

                    case IconType.Check:
                        return PackIconKind.CheckboxMarkedOutline;

                    case IconType.Message:
                        return PackIconKind.MessageOutline;

                    case IconType.List:
                        return PackIconKind.ClipboardListOutline;

                    case IconType.Setting:
                        return PackIconKind.CogOutline;

                    case IconType.Bell:
                        return PackIconKind.BellOutline;

                    case IconType.Close:
                        return PackIconKind.WindowClose;

                    case IconType.Minimize:
                        return PackIconKind.WindowMinimize;

                    case IconType.Maximize:
                        return PackIconKind.ArrowExpand;

                    case IconType.Left:
                        return PackIconKind.ArrowLeft;

                    case IconType.Right:
                        return PackIconKind.ArrowRight;
                    
                    case IconType.ChevronLeft:
                        return PackIconKind.ChevronLeft;
                    
                    case IconType.ChevronRight:
                        return PackIconKind.ChevronRight;

                    default:
                        break;
                }
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
