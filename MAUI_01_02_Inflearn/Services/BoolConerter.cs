using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_01_02_Inflearn.Services
{
    //ch_20_MVVM-2 BoolConverter
    //"YES", "NO"를 true/false로 바꾸기
    public class BoolConerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() == "YES") return true;

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((bool)value) return "YES";

            return "NO";
        }
    }
}
