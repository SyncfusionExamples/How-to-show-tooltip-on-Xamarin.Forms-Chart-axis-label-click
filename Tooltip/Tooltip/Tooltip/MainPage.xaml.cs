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
            var data = (chart.BindingContext as ChartViewModel).ColumnData[(int)e.Position] as ChartModel;
            float xPoint = (float)chart.ValueToPoint(chart.PrimaryAxis, (int)e.Position);
            float yPoint = (float)chart.ValueToPoint(chart.SecondaryAxis, data.YValue);

            tooltip.Show(xPoint, yPoint, true);
        }
    }
}
