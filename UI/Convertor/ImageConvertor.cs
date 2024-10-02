using kpz_2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace UI.Convertor
{
    public class ImageConvertor : IValueConverter
    {
        Dictionary<OrderStatus, BitmapImage> cache = new Dictionary<OrderStatus, BitmapImage>();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (OrderStatus)value;
            if (!cache.ContainsKey(status))
            {
                var uri = new Uri(string.Format(@"E:\vs\kpz_2\UI\Icon\{1}\{0}.png", status, parameter));
                cache.Add(status, new BitmapImage(uri));
            }
            return cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
