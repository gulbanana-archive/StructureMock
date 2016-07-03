using Lib.Common.Formats;
using System.Windows;

namespace DesktopApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button.Formatter = new QuoteFormatter();
            Button.Output = Output;
        }
    }
}
