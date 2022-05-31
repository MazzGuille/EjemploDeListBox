using System.Collections.Generic;
using System.Windows;

namespace EjemploDeListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Creamos la lista
            List<Poblaciones> listaPob = new List<Poblaciones>();

            // Agregar elementos al ListBox
            listaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Buenos Aires", Poblacion2 = "Cordoba", Temperatura1 = 12, Temperatura2 = 13, DiferenciaTemp = 1 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Bariloche", Poblacion2 = "Mar del plata", Temperatura1 = 4, Temperatura2 = 11, DiferenciaTemp = 7 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Caracas", Poblacion2 = "Maracay", Temperatura1 = 27, Temperatura2 = 32, DiferenciaTemp = 5 });
            listaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (listaPoblaciones.SelectedItem != null)
            {
                //Obtenemos el elemento seleccionado
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C    " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C   " + "Diferencia en grados centigrados: " +
                    (listaPoblaciones.SelectedItem as Poblaciones).DiferenciaTemp + "°C");
            }
            else
            {
                MessageBox.Show("No selecciono nada, favor seleccionar una poblacion");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                //Obtenemos el elemento seleccionado
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C    " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C   " + "Diferencia en grados centigrados: " +
                    (listaPoblaciones.SelectedItem as Poblaciones).DiferenciaTemp + "°C");
            }
            else
            {
                MessageBox.Show("No selecciono nada, favor seleccionar una poblacion");
            }
        }
    }
}

public class Poblaciones
{
    public string Poblacion1 { get; set; }
    public int Temperatura1 { get; set; }
    public string Poblacion2 { get; set; }
    public int Temperatura2 { get; set; }
    public int DiferenciaTemp { get; set; }


}

