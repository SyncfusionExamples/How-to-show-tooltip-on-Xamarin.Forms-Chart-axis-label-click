using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tooltip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CategoryAxis_LabelClicked(object sender, LabelClickedEventArgs e)
        {
            var datapoints = series.GetDataPoints(e.Position, e.Position, chart.SeriesBounds.Top, chart.SeriesBounds.Bottom);

            if (datapoints.Count > 0)
            {
                ChartModel data = datapoints[0] as ChartModel;
                float xPoint = (float)chart.ValueToPoint(chart.PrimaryAxis, e.Position);
                float yPoint = (float)chart.ValueToPoint(chart.SecondaryAxis, data.YValue);

                tooltip.Show(xPoint, yPoint, true);
            }
        }
    }
}
