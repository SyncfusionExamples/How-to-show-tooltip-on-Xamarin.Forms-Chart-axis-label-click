# How to show tooltip on Xamarin.Forms Chart axis label click?

This example demonstrates how to programmatically show the tooltip when tapping on the chart axis label.

You can show the tooltip programmatically with the help of axis [LabelClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartAxis.html) event and [Show](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html#Syncfusion_SfChart_XForms_ChartTooltipBehavior_Show_System_Single_System_Single_System_Boolean_) method of [ChartTooltipBehavior](https://help.syncfusion.com/cr/Syncfusion.SfChart.XForms.ChartTooltipBehavior.html) as per the following code snippet.

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
> **Note:** Show method is available for Android and iOS platforms only. It will not work for UWP platform.

## Output:

![Show tooltip on Xamarin.Forms Chart axis label click](https://user-images.githubusercontent.com/53489303/200745119-249d79ff-9582-4664-84f5-45e52bedc349.gif)

KB article - [How to show tooltip on Xamarin.Forms Chart axis label click?](https://www.syncfusion.com/kb/11644/how-to-show-tooltip-on-xamarin-forms-chart-axis-label-click)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
