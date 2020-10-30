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
                Text = "Page1",
            };
            _buttonTwo = new Button()
            {
                Text = "Page2",
            };
            _buttonThree = new Button()
            {
                Text = "Page3",
            };
            _buttonFour = new Button()
            {
                Text = "Page4",
            };
            _buttonFive = new Button()
            {
                Text = "Page5",
            };
            _buttonSix = new Button()
            {
                Text = "Page6",
            };
            _buttonSeven = new Button()
            {
                Text = "Page7",
            };
            _buttonEight = new Button()
            {
                Text = "Page8",
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
                case "Page1":
                    await Navigation.PushAsync(new Page1());
                    break;
                case "Page2":
                    await Navigation.PushAsync(new Page2());
                    break;
                case "Page3":
                    await Navigation.PushAsync(new Page3());
                    break;
                case "Page4":
                    await Navigation.PushAsync(new Page4());
                    break;
                case "Page5":
                    await Navigation.PushAsync(new Page5());
                    break;
                case "Page6":
                    await Navigation.PushAsync(new Page6());
                    break;
                case "Page7":
                    await Navigation.PushAsync(new Page7());
                    break;
                case "Page8":
                    await Navigation.PushAsync(new Page8());
                    break;
            }


        }


    }
}
