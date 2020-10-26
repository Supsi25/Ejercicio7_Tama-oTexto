using System.Windows;
using System.Windows.Controls;

namespace Ejercicio7_TamañoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton_Button_Checked(object sender, RoutedEventArgs e)
        {
            texto_TextBlock.FontSize = int.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
