using Wpf.Ui.Controls;

namespace TaskFlow.Views
{
    public partial class Dashboard : FluentWindow
    {
        public Dashboard()
        {
            InitializeComponent();
            ApplyBackdrop();
        }

        private void ApplyBackdrop()
        {
            if (WindowBackdrop.IsSupported(WindowBackdropType.Mica))
            {
                WindowBackdrop.ApplyBackdrop(this, WindowBackdropType.Mica);
            }
        }
    }
}