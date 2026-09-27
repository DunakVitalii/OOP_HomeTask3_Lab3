using Lab3_Task1_1_MauiApp.Models;
using Lab3_Task1_1_MauiApp.PageModels;

namespace Lab3_Task1_1_MauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}