using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace T2_Practica1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
     
    public partial class MainWindow : Window
    {
        private int valor;
        const int VALOR_MAXIMO = 100;
        public int ObtenerNumeroAleatorio()
        {
            Random sem = new Random();
            return sem.Next(0, VALOR_MAXIMO+1);
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

        private void numeroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string patron = "^[0-9]{1,3}$";  // de uno a 3 dígitos
            Regex pat = new Regex(patron);
            if (pat.IsMatch(numeroTextBox.Text) && int.Parse(numeroTextBox.Text) <= VALOR_MAXIMO)
                resultadoTextBlock.Text = "";
            else
                resultadoTextBlock.Text = "Valores entre 0 y 100";
                
        }
    }
}
