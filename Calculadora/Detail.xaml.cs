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
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void CalcularArea_Clicked(object sender, EventArgs e)
        {
            string alturaTXT = Altura.Text;
            string baseTXT = tbBase.Text;
            double n1;
            double n2;
            double total;
         
            if ((alturaTXT == "") || (baseTXT == "")){
                DisplayAlert("Hola usuario", "Rellene todos los campos", "OK");
            }
            else{
                if (((alturaTXT == "-") || (alturaTXT == ".")) || ((baseTXT == "-") || (baseTXT == ".")))
                {
                    DisplayAlert("Hola usuario", "Ingrese un numero", "OK");
                }
                else
                {
                    n1 = Convert.ToDouble(alturaTXT);
                    n2 = Convert.ToDouble(baseTXT);
                    if ((n1 < 0) || (n2 < 0))
                    {
                        DisplayAlert("Hola usuario", "Las medidas no pueden ser negativas", "OK");
                    }
                    else
                    {
                        total = (n1 * n2) / 2;
                        string resultado = Convert.ToString(total);
                        Altura.Text = "";
                        tbBase.Text = "";
                        lblResultado.Text = "El area es " + resultado;
                    }
                }
            }
            
        }
    }
}