using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace LiveCharts.Viewers
{
	internal class SerieConverter : IValueConverter
	{
		public static SerieConverter Instance { get; set; }

	    static SerieConverter()
		{
			Instance = new SerieConverter();
		}
		private SerieConverter() { }

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var series = value as IEnumerable<Series>;
			if (series != null)
				return series.Select(s => new SerieStandin
					{
						Title = s.Title,
						Stroke = s.Stroke,
						Fill = s.Fill
					});

			var serie = value as Series;
			if (serie != null)
				return new SerieStandin
					{
						Title = serie.Title,
						Stroke = serie.Stroke,
						Fill = serie.Fill
					};

			return value;
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}