using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTHKNavigationPage.Pages;
using Xamarin.Forms;

namespace TTHKNavigationPage
{
    public partial class MainPage : ContentPage
    {
        Button _buttonOne, _buttonTwo, _buttonThree, _buttonFour, _buttonFive, _buttonSix, _buttonSeven, _buttonEight;
        public MainPage()
        {
            //InitializeComponent();
            _buttonOne = new Button()
            { 
                Text = "Компас",
                CornerRadius = 25
            };
            _buttonTwo = new Button()
            {
                Text = "Вибратор",
                CornerRadius = 25
            };
            _buttonThree = new Button()
            {
                Text = "Фонарик",
                CornerRadius = 25
            };
            _buttonFour = new Button()
            {
                Text = "Text to Speech",
                CornerRadius = 25
            };
            _buttonFive = new Button()
            {
                Text = "",
                CornerRadius = 25
            };
            _buttonSix = new Button()
            {
                Text = "",
                CornerRadius = 25
            };
            _buttonSeven = new Button()
            {
                Text = "",
                CornerRadius = 25
            };
            _buttonEight = new Button()
            {
                Text = "",
                CornerRadius = 25
            };
            StackLayout st = new StackLayout();
       
            st.Children.Add(_buttonOne);
            st.Children.Add(_buttonTwo);
            st.Children.Add(_buttonThree);
            st.Children.Add(_buttonFour);
            st.Children.Add(_buttonFive);
            st.Children.Add(_buttonSix);
            st.Children.Add(_buttonSeven);
            st.Children.Add(_buttonEight);

            Content = st;
            _buttonOne.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonTwo.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonThree.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonFour.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonFive.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonSix.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonSeven.Clicked += new EventHandler(_buttonOne_Clicked);
            _buttonEight.Clicked += new EventHandler(_buttonOne_Clicked);

        }

        private async void _buttonOne_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "Компас":
                    await Navigation.PushAsync(new Page3());
                    break;
                case "Вибратор":
                    await Navigation.PushAsync(new Page2());
                    break;
                case "Фонарик":
                    await Navigation.PushAsync(new Page7());
                    break;
                case "Text to Speech":
                    await Navigation.PushAsync(new Page8());
                    break;
                case "m":
                    await Navigation.PushAsync(new Page5());
                    break;
                case "mm":
                    await Navigation.PushAsync(new Page6());
                    break;
                case "mmm":
                    await Navigation.PushAsync(new Page1());
                    break;
                case "mmmm":
                    await Navigation.PushAsync(new Page4());
                    break;
            }


        }


    }
}
