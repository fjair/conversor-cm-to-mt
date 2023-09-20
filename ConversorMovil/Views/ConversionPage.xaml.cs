using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConversorMovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversionPage : ContentPage
    {
        double _centimeters;
        double _meters;

        public ConversionPage()
        {
            InitializeComponent();
        }

        private async void btnSalir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnConvertValue_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnteredValue.Text))
            {
                _centimeters = Convert.ToDouble(txtEnteredValue.Text);
                _meters = _centimeters / 100;
                lblResult.Text = $"{_centimeters} cm = {_meters} m";
            }
            else
            {
                lblResult.Text = string.Empty;
                DisplayAlert("ERROR!", "Ingresa un valor valido", "OK");
            }
        }
    }
}