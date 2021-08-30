using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using OctoRE.Core;

namespace OctoRE.Converters
{
    public class PathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagePath = ResourceManager.GetDefaultIconPath();
            if (value != null)
            {
                imagePath = $"{value}";
            }

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            image.UriSource = new Uri(imagePath, UriKind.Absolute);
            image.EndInit();

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
