using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace MovieApp;

public class TagConverter : IValueConverter, IMarkupExtension
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is ObservableCollection<string> tags)
        {
            string result = "";
            for (int i = 0; i < tags.Count; i++)
            {
                result += tags[i];
                if (i < tags.Count - 1)
                    result += ", "; 
            }
            return result;
        }
        return string.Empty;
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