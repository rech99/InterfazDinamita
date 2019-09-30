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

namespace InterfazDinamita
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

        private void CbSeleccion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Guardar.Visibility = Visibility.Visible;
            Cerrar.Visibility = Visibility.Visible;
            grdParametros.Children.Clear();
            switch (cbSeleccion.SelectedIndex)

            {
                case 0:

                    grdParametros.Children.Add(new ParametrosAlumnos());
                    break;

                case 1:

                    grdParametros.Children.Add(new ParametrosMaestros());
                    break;
            }
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            Guardar.Visibility = Visibility.Hidden;
            Cerrar.Visibility = Visibility.Hidden;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            Guardar.Visibility = Visibility.Hidden;
            Cerrar.Visibility = Visibility.Hidden;
        }
    }


}
