using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTHKNavigationPage.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        CompassViewModel vm;
        public Page3()
        {
            InitializeComponent();
            BindingContext = vm = new CompassViewModel();
            vm.StartCompass();
        }
        

       
    }
}