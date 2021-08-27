using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using MColor = System.Windows.Media.Color;
using DColor = System.Drawing.Color;


namespace OctoRE.Converters
{
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case null:
                    return null;

                case DColor newColor:
                    MColor convertedColor = ToMediaColor(newColor);
                    return new SolidColorBrush(convertedColor);

                case MColor newColor:
                    return new SolidColorBrush(newColor);

                default:
                    Type type = value.GetType();
                    throw new InvalidOperationException($"Unsupported type [{type.Name}]");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static MColor ToMediaColor(DColor color)
        {
            return MColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
