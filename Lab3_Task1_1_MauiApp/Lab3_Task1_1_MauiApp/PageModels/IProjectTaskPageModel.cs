using CommunityToolkit.Mvvm.Input;
using Lab3_Task1_1_MauiApp.Models;

namespace Lab3_Task1_1_MauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}