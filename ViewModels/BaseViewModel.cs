using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskFlow.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = string.Empty;
    }
}