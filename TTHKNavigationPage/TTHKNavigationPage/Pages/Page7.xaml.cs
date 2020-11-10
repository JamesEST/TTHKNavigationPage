using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTHKNavigationPage.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7 : ContentPage
    {
        int ValueClik = 1;
        public Page7()
        {
            InitializeComponent();
        }

    

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (ValueClik == 2)
            {
                ImageSourse.Source = "torchON.png";
                await Flashlight.TurnOnAsync();
                ValueClik = 1;
            }
            else if (ValueClik == 1)
            {
                ImageSourse.Source = "torchOFF.png";
                await Flashlight.TurnOffAsync();
                ValueClik = 2;
            }
        }
    }
}