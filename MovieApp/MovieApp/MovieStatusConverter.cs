using System;
using System.Globalization;

namespace MovieApp;

public class MovieStatusConverter : IValueConverter, IMarkupExtension
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isWatched = (bool)value;
        if(isWatched)
        {
            return "Watched";
        }
        return "Not watched";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value;
    }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}