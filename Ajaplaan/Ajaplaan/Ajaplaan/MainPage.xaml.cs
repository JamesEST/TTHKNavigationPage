using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ajaplaan
{
    public partial class MainPage : ContentPage
    {
        TimeSpan _triggerTime;

        public MainPage()
        {
            InitializeComponent();
        }

        private void _timePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _triggerTime = _timePicker.Time;
            
            if (_triggerTime.Hours.ToString() == "1")
            {
                LabelInfo.Text = "Python Time";
                imageforpicker.Source = "python.jpg";
            }
            else if(_triggerTime.Hours.ToString() == "2")
            {
                LabelInfo.Text = "Html Time";
                imageforpicker.Source = "html.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "3")
            {
                LabelInfo.Text = "Css Time";
                imageforpicker.Source = "css.png";
            }
            else if (_triggerTime.Hours.ToString() == "4")
            {
                LabelInfo.Text = "JavaScript Time";
                imageforpicker.Source = "js.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "5")
            {
                LabelInfo.Text = "Ruby Time";
                imageforpicker.Source = "ruby.png";
            }
            else if (_triggerTime.Hours.ToString() == "6")
            {
                LabelInfo.Text = "Php Time";
                imageforpicker.Source = "php.png";
            }
            else if (_triggerTime.Hours.ToString() == "7")
            {
                LabelInfo.Text = "Pascal Time";
                imageforpicker.Source = "pascal.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "8")
            {
                LabelInfo.Text = "Node JS Time";
                imageforpicker.Source = "nodejs.png";
            }
            else if (_triggerTime.Hours.ToString() == "9")
            {
                LabelInfo.Text = "Java Time";
                imageforpicker.Source = "java.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "10")
            {
                LabelInfo.Text = "C# Time";
                imageforpicker.Source = "charh.png";
            }
            else if (_triggerTime.Hours.ToString() == "11")
            {
                LabelInfo.Text = "C++ Time";
                imageforpicker.Source = "ccc.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "0")
            {
                LabelInfo.Text = "C Time";
                imageforpicker.Source = "c.jpg";
            }
        }

      
    }
}
