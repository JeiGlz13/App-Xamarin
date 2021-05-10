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
    public partial class CalculadoraTrigonometrica : ContentPage
    {
        public CalculadoraTrigonometrica()
        {
            InitializeComponent();

            string[] funciones = { "Seno", "Coseno", "Tangente", "Cosecante", "Secante", "Cotangente" };
            for (int i = 0; i < 6; i++) { cbTrigonometricas.Items.Add(funciones[i]); }
           
        }

        private void cbTrigonometricas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tbValor;
            double funcion = 0;
            double funcionRadian = 0;
            string resultado;
            string resultadoRadian;
            string operacion;
            double valorRadian = 0;
            double valorGrado = 0;

            tbValor = tbTrigonometrica.Text;
            if (tbValor == "")
            {
                DisplayAlert("Hola usuario", "Rellene el campo", "OK");
            }
            else
            {
               
                if ((tbValor == "-") || (tbValor == "."))
                {
                    DisplayAlert("Hola usuario", "Ingrese un numero", "OK");
                }
                else
                {
                    valorRadian = Convert.ToDouble(tbValor);
                    valorGrado = (valorRadian/180) * Math.PI;
                    operacion = cbTrigonometricas.SelectedItem.ToString();

                    switch (operacion)
                    {
                        case "Seno":
                            funcion = Math.Sin(valorGrado);
                            funcionRadian = Math.Sin(valorRadian);
                            break;
                        case "Coseno":
                            funcion = Math.Cos(valorGrado);
                            funcionRadian = Math.Cos(valorRadian);
                            break;
                        case "Tangente":
                            funcion = Math.Tan(valorGrado);
                            funcionRadian = Math.Tan(valorRadian);
                            break;
                        case "Cosecante":
                            funcion = (1 / (Math.Sin(valorGrado)));
                            funcionRadian = (1 / (Math.Sin(valorRadian)));
                            break;
                        case "Secante":
                            funcion = (1 / (Math.Cos(valorGrado)));
                            funcionRadian = (1 / (Math.Cos(valorRadian)));
                            break;
                        case "Cotangente":
                            funcion = (1 / (Math.Tan(valorGrado)));
                            funcionRadian = (1 / (Math.Tan(valorRadian)));
                            break;
                        default:
                            DisplayAlert("Hola Usuario", "Ingrese una opcion validad", "OK");
                            break;
                    }

                    resultado = Convert.ToString(funcion);
                    resultadoRadian = Convert.ToString(funcionRadian);
                    lblResultado.Text = "Grados: " + resultado;
                    lblResultadoRadian.Text = "Radian: " + resultadoRadian;
                }
            }
        }
    }
}