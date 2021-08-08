using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SubscriptionOverview.Converter
{
    public class ImageBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imgFileName = value.ToString();
            string fullPath = Path.Combine(Environment.CurrentDirectory, "Assets", "Image", imgFileName);

            if (File.Exists(fullPath))
            {
                Uri uri = new(fullPath, UriKind.Absolute);
                if (uri != null)
                {
                    BitmapImage bmp = new(uri);
                    if (bmp != null)
                    {
                        return new ImageBrush(bmp);
                    }
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
