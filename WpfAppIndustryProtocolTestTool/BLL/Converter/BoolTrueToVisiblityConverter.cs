﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfAppIndustryProtocolTestTool.BLL.Converter
{
    public class BoolTrueToVisiblityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
