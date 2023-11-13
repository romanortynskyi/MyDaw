using System.Globalization;

namespace MyDaw.Converters;

public class PathConcatenationConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values != null && values.Length > 0)
        {
            // Concatenate all non-null strings with a slash in between
            var concatenatedString = string.Join("\\", values.Where(v => v is string).Select(v => v.ToString()));

            return concatenatedString;
        }

        return null;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            return (value as string).Split("\\");
        }

        return new object[] {};
    }
}
