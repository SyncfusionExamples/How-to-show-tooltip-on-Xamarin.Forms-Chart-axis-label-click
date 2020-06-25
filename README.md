# How-to-show-tooltip-on-Xamarin.Forms-Chart-axis-label-click
This example demonstrates how to programmatically show the tooltip when tapping on the chart axis label. Please refer KB links for more details,

[How to show tooltip on chart axis label in Xamarin.Forms](https://www.syncfusion.com/kb/11644/?utm_medium=listing&utm_source=github-examples)

You can show the tooltip programmatically with the help of axis LabelClicked event and Show method of ChartTooltipBehavior as per the following code snippet.

**[XAML]**
```
<chart:SfChart.PrimaryAxis> 
       <chart:CategoryAxis LabelClicked ="CategoryAxis_LabelClicked" /> 
</chart:SfChart.PrimaryAxis>  
 
<chart:SfChart.Series>
      <chart:ColumnSeries EnableTooltip="True" ItemsSource="{Binding ColumnData}" XBindingPath="XValue" YBindingPath="YValue" />
</chart:SfChart.Series>
                
<chart:SfChart.ChartBehaviors>
    <chart:ChartTooltipBehavior x:Name="tooltip"/>
</chart:SfChart.ChartBehaviors>
```
**C#**
```
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
```
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.