using System.Windows.Controls;
using TaskFlow.ViewModels;
using TaskFlow.Views.Pages;

namespace TaskFlow.Services
{
    public class NavigationService
    {
        private readonly DashboardViewModel _viewModel;

        public NavigationService(DashboardViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        
        public void NavigateTo(string pageKey)
        {
            _viewModel.CurrentPage = pageKey switch
            {
                "Placeholder1" => new PlaceHolder1(),
                "Placeholder2" => new PlaceHolder2(),

                _ => new PlaceHolder1()
            };
        }
    }
}