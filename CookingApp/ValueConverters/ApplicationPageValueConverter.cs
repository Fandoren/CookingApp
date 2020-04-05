using System;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.Text;
using CookingApp.DataModels;
using CookingApp.View.MainPages;

namespace CookingApp.ValueConverters
{
    class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                case ApplicationPage.SignUp:
                    return new SignUpPage();

                default:
                    Debugger.Break();
                    return null;
                    
            }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
