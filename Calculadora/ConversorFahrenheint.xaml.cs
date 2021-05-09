using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversorFahrenheint : ContentPage
    {
        public ConversorFahrenheint()
        {
            InitializeComponent();
        }

        private void convertirGrados_Clicked(object sender, EventArgs e){
            string lblGrados = tbGrados.Text;
            double n1;
            double conversion;
            string resultado;

            if (lblGrados == ""){
                DisplayAlert("Hola usuario", "Rellene el campo", "OK");
            }
            else 
            {
                if ((lblGrados == ".") || (lblGrados == "-"))
                {
                    DisplayAlert("Hola usuario", "Escriba un numero", "OK");
                }
                else
                {
                    n1 = Convert.ToDouble(lblGrados);
                    conversion = (n1 - 32) * 5 / 9;
                    resultado = Convert.ToString(conversion);
                    tbGrados.Text = "";
                    lblResultado.Text = resultado + " grados centigrados";
                }
            }
            
        }
    }
}