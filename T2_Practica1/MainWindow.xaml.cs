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

namespace T2_Practica1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
     
    public partial class MainWindow : Window
    {
        private int valor;
        public int ObtenerNumeroAleatorio()
        {
            Random sem = new Random();
            return sem.Next(0, 101);
        }
        public MainWindow()
        {
            InitializeComponent();
            valor = ObtenerNumeroAleatorio();
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int resultado = int.Parse(numeroTextBox.Text);

            if (valor == resultado)
                resultadoTextBlock.Text = "Has acertado.";
            else if (valor < resultado)
                     resultadoTextBlock.Text = "Estas por encima";
            else resultadoTextBlock.Text = "Estas por debajo";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Text = "";
            resultadoTextBlock.Text = "";
            valor = ObtenerNumeroAleatorio();
        }
    }
}
