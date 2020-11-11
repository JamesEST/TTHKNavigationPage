using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace TTHKNavigationPage.Pages
{
    public class MyCompass
    {
        public event EventHandler<string> GetCompassValue;

        public MyCompass()
        {
            Start();
            Compass.ReadingChanged += Compass_ReadingChanged;
    


        }

        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            GetCompassValue?.Invoke(this, e.Reading.HeadingMagneticNorth.ToString());
        }
        public void Start()
        {
            try
            {
                Compass.Start(SensorSpeed.UI);
            }
            catch(FeatureNotEnabledException fnsEx)
            {
                Console.WriteLine(fnsEx.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
