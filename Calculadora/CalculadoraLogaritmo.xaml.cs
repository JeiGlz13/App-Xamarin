using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraLogaritmo : ContentPage
    {
        public CalculadoraLogaritmo()
        {
            InitializeComponent();

            string[] funciones = { "Factorial", "Logaritmo10", "LogaritmoNatural"};
            for (int i = 0; i < 3; i++) { cbLogaritmo.Items.Add(funciones[i]); }

        }

        public static long Factorial(int n)
        {
            if (n == 0)               
                return 1;
            return n * Factorial(n - 1); 
        }

        private void cbLogaritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor;
            string tbValor;
            double logaritmo = 0;
            string resultado;
            string operacion;

            tbValor = tbLogaritmo.Text;

            if(tbValor == ""){
                DisplayAlert("Hola Usuario", "Ingrese un valor", "OK");
            }
            else
            {
                char[] test = tbValor.ToCharArray();
                bool entero = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (test[i] == '.')
                    {
                        entero = false;
                    }
                }
                if ((entero == false)||(tbValor == "-"))
                {
                    DisplayAlert("Hola Usuario", "Ingrese un numero entero", "OK");
                }
                else
                {
                    valor = Convert.ToInt32(tbValor);
                    operacion = cbLogaritmo.SelectedItem.ToString();

                    if (valor < 0) DisplayAlert("Hola Usuario", "Ingrese un numero positivo", "OK");
                    else
                    {
                        switch (operacion)
                        {
                            case "Factorial":
                                logaritmo = Factorial(valor);
                                break;
                            case "Logaritmo10":
                                logaritmo = Math.Log10(valor);
                                break;
                            case "LogaritmoNatural":
                                logaritmo = Math.Log(valor);
                                break;
                        }

                        resultado = Convert.ToString(logaritmo);
                        lblResultado.Text = resultado;
                    }

                    
                }
            }
        }
    }
}