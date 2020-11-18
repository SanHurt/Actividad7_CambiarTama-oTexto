
using System.Windows;
using System.Windows.Controls;

namespace Actividad7_CambiarTamañoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            medianoRadioButton.IsChecked = true;
        }

        private void medianoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textTextBlock.FontSize = 48;
        }

        private void pequeñoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textTextBlock.FontSize = int.Parse((sender as RadioButton).Tag.ToString());
        }

        private void grandeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textTextBlock.FontSize = 72;
        }
    }
}
