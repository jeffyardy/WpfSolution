﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
namespace WpfDemoApp.Converters
{
  public class EligibilityConverter : IValueConverter
  {
    int _age;
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      _age = (int)value;
      if (_age > 17)
      {
        return "Eligible";
      }
      else {
        return "Not Eligible";
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
