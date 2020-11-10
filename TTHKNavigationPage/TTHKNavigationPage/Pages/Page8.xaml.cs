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
    public partial class Page8 : ContentPage
    {
        private int steppervalue = 0;
        public Page8()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await TextToSpeech.SpeakAsync(EntryText.Text, new SpeechOptions
                {
                    Volume = (float)VolumeStepper.Value
                });
            }
            catch (Exception exception)
            {
                await DisplayAlert ("Подсказка", "Введи сначало какой-то текст", "ОК");
            }
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            VolumeValue.Text = string.Format("Уровень громкости : {0}", e.NewValue);
        }
    }
}