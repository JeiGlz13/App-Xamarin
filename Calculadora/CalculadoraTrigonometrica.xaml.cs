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

            cbTrigonometricas.Items.Add("Seno");
            cbTrigonometricas.Items.Add("Coseno");
            cbTrigonometricas.Items.Add("Tangente");
            cbTrigonometricas.Items.Add("Secante");
        }
    }
}