using Syncfusion.Maui.Charts;

namespace ZoomEventsSample
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

        private void chart_ZoomStart(object sender, Syncfusion.Maui.Charts.ChartZoomStartEventArgs e)
        {
            

        }

        private void chart_ZoomEnd(object sender, ChartZoomEventArgs e)
        {
            if (e.Axis is DateTimeAxis dateTimeAxis)
            {
                DateTime minimum = DateTime.FromOADate(dateTimeAxis.VisibleMinimum);
                DateTime maximum = DateTime.FromOADate(dateTimeAxis.VisibleMaximum);
               
                System.Diagnostics.Debug.WriteLine($"ZoomMin: {minimum}");
                System.Diagnostics.Debug.WriteLine($"ZoomMax: {maximum}");
               
                viewModel.VisibleMinimum = minimum;
                viewModel.VisibleMaximum = maximum;

                System.Diagnostics.Debug.WriteLine($"ZoomMin: {viewModel.VisibleMinimum}");
                System.Diagnostics.Debug.WriteLine($"ZoomMax: {viewModel.VisibleMaximum}");

            }
        }
    }

}
