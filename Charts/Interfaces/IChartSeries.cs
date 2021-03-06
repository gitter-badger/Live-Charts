using System.Collections;

namespace LiveCharts
{
    public interface IChartSeries
    {
        /// <summary>
        /// Values to plot
        /// </summary>
        IChartValues Values { get; set; }
        /// <summary>
        /// Collection that owns the series
        /// </summary>
        SeriesCollection Collection { get; }
        ISeriesConfiguration Configuration { get; set; }
    }
}