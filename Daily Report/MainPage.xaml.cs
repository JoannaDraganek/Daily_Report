﻿using System;
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

namespace Daily_Report
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int roadmanWorkers = 0;
        int bridgeWorkers = 0;
        int otherWorkers = 0;
        int millingMachine = 0;
        int excavatorMachine = 0;
        int loaderMachine = 0;
        int bulldozerMachine = 0;
        int dumpTruck = 0;
        int backhoeLoader = 0;
        int compactor = 0;
        int roller = 0;
        int grader = 0;
        int paver = 0;
        int miniExcavator = 0;


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

           


        //Drogowcy
        private void RoadmanQuantity_Clicked(object sender, EventArgs e)
        {
            roadmanWorkers++;
            RoadmanQuantity.Text = roadmanWorkers.ToString();
        }

        private void PlusFiveRoadman_Clicked(object sender, EventArgs e)
        {
            roadmanWorkers += 5;
            RoadmanQuantity.Text = roadmanWorkers.ToString();
        }
        private void RoadmanLess_Clicked(object sender, EventArgs e)
        {
            if (roadmanWorkers > 0)
            {
                roadmanWorkers--;
            };
            RoadmanQuantity.Text = roadmanWorkers.ToString();
        }


        //Mostowcy
        private void BridgeWorkersQuantity_Clicked(object sender, EventArgs e)
        {
            bridgeWorkers++;
            BridgeWorkers.Text = bridgeWorkers.ToString();
        }

        private void PlusFiveBridgeWorkers_Clicked(object sender, EventArgs e)
        {
            bridgeWorkers += 5;
            BridgeWorkers.Text = bridgeWorkers.ToString();
        }

        private void BridgeWorkersLess_Clicked(object sender, EventArgs e)
        {
            if (bridgeWorkers > 0)
            {
                bridgeWorkers--;
            };
            BridgeWorkers.Text = bridgeWorkers.ToString();
        }


        //Pozostali pracownicy
        private void OtherWorkersQuantity_Clicked(object sender, EventArgs e)
        {
            otherWorkers++;
            OtherWorkers.Text = otherWorkers.ToString();
        }

        private void PlusFiveOtherWorkers_Clicked(object sender, EventArgs e)
        {
            otherWorkers += 5;
            OtherWorkers.Text = otherWorkers.ToString();
        }

        private void OtherWorkersLess_Clicked(object sender, EventArgs e)
        {
            if (otherWorkers > 0)
            {
                otherWorkers--;
            };
            OtherWorkers.Text = otherWorkers.ToString();
        }

        //Koparka
        private void ExcavatorQuantity_Clicked(object sender, EventArgs e)
        {
            excavatorMachine++;
            ExcavatorQuantity.Text = excavatorMachine.ToString();
        }
        private void ExcavatorLess_Clicked(object sender, EventArgs e)
        {
            if (excavatorMachine > 0)
            {
                excavatorMachine--;
            };
            ExcavatorQuantity.Text = excavatorMachine.ToString();
        }


        //Frezarka
        private void MillingMashineQuantity_Clicked(object sender, EventArgs e)
        {
            millingMachine++;
            MillingMachineQuantity.Text = millingMachine.ToString();
        }

        private void MillingMashineLess_Clicked(object sender, EventArgs e)
        {
            if (millingMachine > 0)
            {
                millingMachine--;
            };
            MillingMachineQuantity.Text = millingMachine.ToString();
        }


        //Ładowarka loader
        private void LoaderQuantity_Clicked(object sender, EventArgs e)
        {
            loaderMachine++;
            LoaderQuantity.Text = loaderMachine.ToString();
        }

        private void LoaderLess_Clicked(object sender, EventArgs e)
        {
            if (loaderMachine > 0)
            {
                loaderMachine--;
            };
            LoaderQuantity.Text = loaderMachine.ToString();
        }

        //Spycharka bulldozer
        private void BulldozerQuantity_Clicked(object sender, EventArgs e)
        {
            bulldozerMachine++;
            BulldozerQuantity.Text = bulldozerMachine.ToString();
        }

        private void BulldozerLess_Clicked(object sender, EventArgs e)
        {
            if (bulldozerMachine > 0)
            {
                bulldozerMachine--;
            };
            BulldozerQuantity.Text = bulldozerMachine.ToString();
        }

        //Wywrotka/samochód samowyładowczy  dump truck
        private void DumpTruckQuantity_Clicked(object sender, EventArgs e)
        {
            dumpTruck++;
            DumpTruckQuantity.Text = dumpTruck.ToString();
        }

        private void DumpTruckLess_Clicked(object sender, EventArgs e)
        {
            if (dumpTruck > 0)
            {
                dumpTruck--;
            };
            DumpTruckQuantity.Text = dumpTruck.ToString();
        }

        //Koparko-ładowarki backhoe loader
        private void BackhoeLoaderQuantity_Clicked(object sender, EventArgs e)
        {
            backhoeLoader++;
            BackhoeLoaderQuantity.Text = backhoeLoader.ToString();
        }

        private void BackhoeLoaderLess_Clicked(object sender, EventArgs e)
        {
            if (backhoeLoader > 0)
            {
                backhoeLoader--;
            };
            BackhoeLoaderQuantity.Text = backhoeLoader.ToString();
        }

        //Zagęszczarka Compactor
        private void CompactorQuantity_Clicked(object sender, EventArgs e)
        {
            compactor++;
            CompactorQuantity.Text = compactor.ToString();
        }

        private void CompactorLess_Clicked(object sender, EventArgs e)
        {
            if (compactor > 0)
            {
                compactor--;
            };
            CompactorQuantity.Text = compactor.ToString();
        }

        //Walec roller
        private void RollerQuantity_Clicked(object sender, EventArgs e)
        {
            roller++;
            RollerQuantity.Text = roller.ToString();
        }

        private void RollerLess_Clicked(object sender, EventArgs e)
        {
            if (roller > 0)
            {
                roller--;
            };
            RollerQuantity.Text = roller.ToString();
        }

        // Równiarka grader
        private void GraderQuantity_Clicked(object sender, EventArgs e)
        {
            grader++;
            GraderQuantity.Text = grader.ToString();
        }

        private void GraderLess_Clicked(object sender, EventArgs e)
        {
            if (grader > 0)
            {
                grader--;
            };
            GraderQuantity.Text = grader.ToString();
        }

        // Rozściełacz Paver
        private void PaverQuantity_Clicked(object sender, EventArgs e)
        {
            paver++;
            PaverQuantity.Text = paver.ToString();
        }

        private void PaverLess_Clicked(object sender, EventArgs e)
        {
            if (paver > 0)
            {
                paver--;
            };
            PaverQuantity.Text = paver.ToString();
        }

        // Mini koparka mini excavator
        private void MiniExcavatorQuantity_Clicked(object sender, EventArgs e)
        {
            miniExcavator++;
            MiniExcavatorQuantity.Text = miniExcavator.ToString();
        }

        private void MiniExcavatorLess_Clicked(object sender, EventArgs e)
        {
            if (miniExcavator > 0)
            {
                miniExcavator--;
            };
            MiniExcavatorQuantity.Text = miniExcavator.ToString();
        }




        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            roadmanWorkers = 0;
            RoadmanQuantity.Text = roadmanWorkers.ToString();

            bridgeWorkers = 0;
            BridgeWorkers.Text = bridgeWorkers.ToString();

            otherWorkers = 0;
            OtherWorkers.Text = otherWorkers.ToString();

            millingMachine = 0;
            MillingMachineQuantity.Text = millingMachine.ToString();

            excavatorMachine = 0;
            ExcavatorQuantity.Text = excavatorMachine.ToString();

            loaderMachine = 0;
            LoaderQuantity.Text = loaderMachine.ToString();

            bulldozerMachine = 0;
            BulldozerQuantity.Text = bulldozerMachine.ToString();

            dumpTruck = 0;
            DumpTruckQuantity.Text = dumpTruck.ToString();

            backhoeLoader = 0;
            BackhoeLoaderQuantity.Text = backhoeLoader.ToString();

            compactor = 0;
            CompactorQuantity.Text = compactor.ToString();

            roller = 0;
            RollerQuantity.Text = roller.ToString();

            grader = 0;
            GraderQuantity.Text = grader.ToString();

            paver = 0;
            PaverQuantity.Text = paver.ToString();

            miniExcavator = 0;
            MiniExcavatorQuantity.Text = miniExcavator.ToString();
        }

    }

}
