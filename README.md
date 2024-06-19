# How to smartly handle the axis labels in an SfCartesianChart 
[Cartesian charts](https://help.syncfusion.com/maui/cartesian-charts/getting-started) provide customization options for [axis labels](https://help.syncfusion.com/maui/cartesian-charts/axis/axislabels), sometimes axis labels can overlap due to chart dimensions and label size. This article demonstrates how to intelligently arrange overlapping axis labels using the [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) property in [.NET MAUI SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts).

**Step 1:**
Begin by initializing the **SfCartesianChart** following the guidelines in the [documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started).

**Step 2:**
The [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) property of the axis is utilized to prevent overlapping of axis labels. The available values are as follows:

**None:**
 If [LabelsIntersectAction]() is set to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html#Syncfusion_Maui_Charts_AxisLabelsIntersectAction_None), axis labels are arranged by default, potentially overlapping each other.

[XAML] 
 ```html
<chart:SfCartesianChart>
  <chart:SfCartesianChart.XAxes>
     <chart:DateTimeAxis LabelsIntersectAction="None"/>
 </chart:SfCartesianChart.XAxes>
....
 </chart:SfCartesianChart> 
 ```

[C#]
 ```csharp
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis()
 {
     LabelsIntersectAction = AxisLabelsIntersectAction.None,
 };
 chart.XAxes.Add(primaryAxis);
... 
 ```
  ![Visualize axis labels overlapped.](https://support.syncfusion.com/kb/agent/attachment/article/16155/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0MjA1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.QEr3OoXlM0JRD5mkv-nI4vI2AJEr58XitPEOBu4cp0s)

**Hide:**
 When [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) is set to [Hide](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html#Syncfusion_Maui_Charts_AxisLabelsIntersectAction_Hide), which axis labels don't have space that are hidden.

[XAML]
 ```html
<chart:SfCartesianChart >
 <chart:SfCartesianChart.XAxes>
  <chart:DateTimeAxis LabelsIntersectAction="Hide"/>
 </chart:SfCartesianChart.XAxes>
....
 </chart:SfCartesianChart> 
 ```

[C#]
 ```cpp
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis()
{
     LabelsIntersectAction = AxisLabelsIntersectAction.Hide,
};
 chart.XAxes.Add(primaryAxis);
... 
 ```
 
 ![Hide.png](https://support.syncfusion.com/kb/agent/attachment/article/16155/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0MDM2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.4wE53Own4RSb_l-UbO50DiAjyGmvw_GRBri7DQfZNW4)

**MultipleRows:**
When [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction) is set to [MultipleRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html#Syncfusion_Maui_Charts_AxisLabelsIntersectAction_MultipleRows), axis labels are arranged into multiple rows when there is insufficient space.

[XAML] 
 ```html
<chart:SfCartesianChart >
 <chart:SfCartesianChart.XAxes>
     <chart:DateTimeAxis LabelsIntersectAction="MultipleRows"/>
 </chart:SfCartesianChart.XAxes>
....
 </chart:SfCartesianChart> 
 ```

[C#]
 ```csharp
SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis()
{
     LabelsIntersectAction = AxisLabelsIntersectAction.MultipleRows,
};
chart.XAxes.Add(primaryAxis);
... 
 ```
 
 ![Multiplerow.png](https://support.syncfusion.com/kb/agent/attachment/article/16155/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0MDM3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.PLJXnmDSHl0AQNfEVKMrgWj0TI5YfZdSay_p8UH0OyY)

**Wrap:**
When setting the [Wrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html#Syncfusion_Maui_Charts_AxisLabelsIntersectAction_Wrap) option for [LabelsIntersectAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction), you should set the width of the axis label using the [MaxWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_MaxWidth) property available in [ChartAxisLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html) to facilitate appropriate text wrapping. Additionally, use the [WrappedLabelAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html#Syncfusion_Maui_Charts_ChartAxisLabelStyle_WrappedLabelAlignment) property to align the wrapped axis label.

[XAML]
 ```html
<chart:SfCartesianChart>
  <chart:SfCartesianChart.XAxes>
    <chart:DateTimeAxis LabelsIntersectAction="Wrap">
      <chart:DateTimeAxis.LabelStyle >
        <chart:ChartAxisLabelStyle  MaxWidth="28" 
                                   WrappedLabelAlignment="Center"/>
      </chart:DateTimeAxis.LabelStyle>
    </chart:DateTimeAxis>
  </chart:SfCartesianChart.XAxes>
...
</chart:SfCartesianChart> 
 ```

[C#]
 ```csharp
 SfCartesianChart chart = new SfCartesianChart();
 DateTimeAxis primaryAxis = new DateTimeAxis()
 {
     LabelsIntersectAction = AxisLabelsIntersectAction.Wrap,
 };
 ChartAxisLabelStyle chartAxisLabelStyle = new ChartAxisLabelStyle()
 {
     MaxWidth = 28,
     WrappedLabelAlignment = ChartAxisLabelAlignment.Center
 };
 primaryAxis.LabelStyle = chartAxisLabelStyle;
 chart.XAxes.Add(primaryAxis); 
 ```
 ![wrap.png](https://support.syncfusion.com/kb/agent/attachment/article/16155/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0MDQwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.fV6ZbYWBVpfUz53uZKbLr4dsBQDBeC6O4kG7BdjG6Z8)