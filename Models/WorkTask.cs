using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskFlow.Models
{
    public partial class WorkTask : ObservableObject
    {
        [ObservableProperty]
        private string _title = "New Quest";

        [ObservableProperty]
        private DateTime _deadline = DateTime.Now.AddDays(3);

        [ObservableProperty]
        private bool _isCompleted;

        [ObservableProperty]
        private int _progress;
    }
}