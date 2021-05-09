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
    public partial class CalculadoraLogaritmo : ContentPage
    {
        public CalculadoraLogaritmo()
        {
            InitializeComponent();

            cbLogaritmo.Items.Add("Factorial");
            cbLogaritmo.Items.Add("Logaritmo");
        }
    }
}