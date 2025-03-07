using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskFlow.Views
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        ProgressBar bar = new ProgressBar(100);

        public string Value { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            bar.ProgressComplete += OnProgressComplete;
        }

        static void OnProgressComplete(object sender, EventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bar.Load(10);
        }
    }
}
