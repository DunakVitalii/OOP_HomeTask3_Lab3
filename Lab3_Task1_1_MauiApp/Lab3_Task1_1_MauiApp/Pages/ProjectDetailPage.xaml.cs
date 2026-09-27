using Lab3_Task1_1_MauiApp.Models;

namespace Lab3_Task1_1_MauiApp.Pages
{
    public partial class ProjectDetailPage : ContentPage
    {
        public ProjectDetailPage(ProjectDetailPageModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }
    }
}
