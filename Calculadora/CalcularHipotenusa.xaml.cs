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
    public partial class CalcularHipotenusa : ContentPage
    {
        public CalcularHipotenusa()
        {
            InitializeComponent();
        }

        private void calcularHipotenusa_Clicked(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double hipotenusa;

            string lblCatetoA = CatetoA.Text;
            string lblCatetoB = CatetoB.Text;
            string resultado;

            if ((lblCatetoA == "") || (lblCatetoB == ""))
            {
                DisplayAlert("Hola usuario", "Rellene los campos", "OK");
            }
            else
            {
                if (((lblCatetoA == "-") || (lblCatetoA == ".")) || ((lblCatetoB == "-") || (lblCatetoB == ".")))
                {
                    DisplayAlert("Hola usuario", "Ingrese un numero", "OK");
                }
                else
                {
                    n1 = Convert.ToDouble(lblCatetoA);
                    n2 = Convert.ToDouble(lblCatetoB);
                    if ((n1 < 0) || (n2 < 0))
                    {
                        DisplayAlert("Hola usuario", "Las medidas no pueden ser negativas", "OK");
                    }
                    else
                    {
                        hipotenusa = Math.Sqrt((n1*n1)+(n2*n2));
                        resultado = Convert.ToString(hipotenusa);

                        CatetoA.Text = "";
                        CatetoB.Text = "";
                        lblResultado.Text = "La hipotenusa es " + resultado;
                    }
                }
            }
        }
    }
}