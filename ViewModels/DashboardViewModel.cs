using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Navigation;
using TaskFlow.Models;

namespace TaskFlow.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly NavigationService ? _navigationService;

        [ObservableProperty]
        private object ? _currentPage;
        
        public DashboardViewModel (NavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.Navigate("Placeholder1");
        }

        [ObservableProperty]
        private ObservableCollection<WorkTask> _activeTasks = new();

        [ObservableProperty]
        private int _Points = 850;

        [ObservableProperty]
        private double _dailyProgress = 0.65;

        [ObservableProperty]
        private string _selectedPage = "Placeholder1";

        public ObservableCollection<Reward> AvailableRewards { get; } = new()
        {
            new Reward { Name = "Random1", Cost = 200 },
            new Reward { Name = "Random2", Cost = 500 }
        };

        public DashboardViewModel() => LoadSampleTasks();

        private void LoadSampleTasks()
        {
            ActiveTasks.Add(new WorkTask { Title = "TEST", Progress = 45 });
            ActiveTasks.Add(new WorkTask { Title = "TEST1", Progress = 80 });
        }

        [RelayCommand]
        private void Navigate(string parameter)
        {
            _navigationService.Navigate(parameter);
        }

        [RelayCommand]
        private void CompleteTask(WorkTask task)
        {
            task.IsCompleted = true;
            Points += 100;
            DailyProgress = ActiveTasks.Count(t => t.IsCompleted) / (double)ActiveTasks.Count;
        }

        [RelayCommand]
        private void ClaimReward(Reward reward) => Points -= reward.Cost;
    }
}