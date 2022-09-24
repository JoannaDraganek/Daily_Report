using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Globalization;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using DinkToPdf;
using Daily_Report.Helpers;
using Daily_Report.Resources;
using Daily_Report.Equipment;

namespace Daily_Report
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Equipment_Clicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new EquipmentTabs());
        }

             
        CancellationTokenSource cts;

        async Task<Location> GetCurrentLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);
                return location;
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Faild", fnsEx.Message, "OK");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            return null;
        }

        protected override void OnDisappearing()
        {
            if (cts != null && !cts.IsCancellationRequested)
                cts.Cancel();
            base.OnDisappearing();
        }


        protected override async void OnAppearing()
        {
            this.Sky.ItemsSource = new string[]
            {
                AppResources.Sunny,
                AppResources.Cloud,
                AppResources.Rain,
                AppResources.Storm,
                AppResources.Fog
            };

            var location = await GetCurrentLocation();
            var client = new WebClient();
            client.UseDefaultCredentials = true;
            var culture = CultureInfo.GetCultureInfo("en-US");
            var lat = location.Latitude.ToString(culture);
            var lng = location.Longitude.ToString(culture);

            var address = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lng}&appid=bfff428d1bd6b2219139b7884de65975";

            try
            {
                var json = client.DownloadString(address);
                var weatherForecast = JsonSerializer.Deserialize<WeatherData>(json);
                //weatherForecast.main.temp = weatherForecast.main.temp - 273.17m;
                weatherForecast.main.temp_max = weatherForecast.main.temp_max - 273.17m;
                weatherForecast.main.temp_min = weatherForecast.main.temp_min - 273.17m;
                WeatherNow.Text = $" Temp. max {weatherForecast.main.temp_max} ℃" +
                    $" Temp. min {weatherForecast.main.temp_min} ℃";
            }
            catch (Exception ex)
            {

            };
        }

        
       
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            //var font = new XFont("Arial", 20);

            //gfx.DrawString(
            //    "Hello World!", font, XBrushes.Black,
            //    new XRect(20, 20, page.Width, page.Height),
            //    XStringFormats.Center);
           // gfx.DrawRectangle(new XPen(XColor.FromArgb(255, 0,0)), new XRect(20, 30,15,30));
           // var tmp = System.IO.Path.GetTempPath();
          //  document.Save($"{tmp}test.pdf");
            /*
            var converter = new BasicConverter(new PdfTools());
            var doc = new HtmlToPdfDocument()
            {
                    GlobalSettings =
                     {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings() { Top = 10 },
                    Out = @"test.pdf",
                     },
                    Objects = {
                    new ObjectSettings()
                    {
                    Page = "http://google.com/",
                    },
                     }
            };
            converter.Convert(doc);
            */
        }

    }

}
