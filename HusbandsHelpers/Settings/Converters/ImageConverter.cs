using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace HusbandsHelpers.Settings.Converters
{
	class ImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			byte[] bytes = value as byte[];
			if (bytes == null)
				return null;
			using (MemoryStream stream = new MemoryStream(bytes))
			{
				BitmapImage image = new BitmapImage();
				image.BeginInit();

				image.CacheOption = BitmapCacheOption.OnLoad;
				image.StreamSource = stream;
				image.EndInit();
				return image;
			}


		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			BitmapSource bitmapSource = value as BitmapSource;
			if (bitmapSource == null)
				return null;
			return File.ReadAllBytes(bitmapSource.ToString());
		}



	}
}
