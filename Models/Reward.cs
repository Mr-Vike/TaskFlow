using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskFlow.Models
{
    public partial class Reward : ObservableObject
    {
        [ObservableProperty]
        private string _name = "New Reward";

        [ObservableProperty]
        private int _cost = 100;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StatusIcon))]
        private bool _isClaimed;

        public string StatusIcon => IsClaimed ? "" : "";
    }
}