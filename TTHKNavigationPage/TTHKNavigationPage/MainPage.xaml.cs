using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TTHKNavigationPage
{
    public partial class MainPage : ContentPage
    {
        Button _buttonOne, _buttonTwo;
        public MainPage()
        {
            //InitializeComponent();
            _buttonOne = new Button()
            { 
                Text = "Page1",
            };
            _buttonTwo = new Button()
            {
                Text = "Page2",
            };
            StackLayout st = new StackLayout();
            st.Children.Add(_buttonOne);
            Content = st;
            _buttonOne.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonTwo.Clicked += new EventHandler(_buttonOne_Clicked);

        }

        private async void _buttonOne_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "Page1":
                    await Navigation.PushAsync(new TestPage());
                    break;
                case "Page2":
                    await Navigation.PushAsync(new TwoTestPage());
                    break;

            }


        }


    }
}
