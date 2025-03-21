using Wpf.Ui.Controls;

namespace TaskFlow.Services
{
    public class NotificationService
    {
        private readonly Snackbar _snackbar;

        public NotificationService(Snackbar snackbar)
        {
            _snackbar = snackbar;
        }

        public void ShowNotification(string title)
        {
            _snackbar.Title = title;
            _snackbar.Show();
        }
    }
}