using System;
using System.Net;
using System.Text.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Report
{   
    public class WeatherData 
    {
        public BasicsData main { get; set; }
    }

    public class BasicsData
    {
        public decimal temp { get; set; }
        public decimal temp_max { get; set; }
        public decimal temp_min { get; set; }
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IntroPage());
        }


        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
