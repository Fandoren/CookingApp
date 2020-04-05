using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;
using System.Windows.Data;
using System.Globalization;

namespace CookingApp.ValueConverters
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()

    {
        private static T mConverter = null;
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());
        }
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

    }
}
