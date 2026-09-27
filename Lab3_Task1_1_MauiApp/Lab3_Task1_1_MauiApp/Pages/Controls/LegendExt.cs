using Syncfusion.Maui.Toolkit.Charts;

namespace Lab3_Task1_1_MauiApp.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
