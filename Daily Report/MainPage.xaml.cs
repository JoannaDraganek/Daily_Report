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

        int millingMachineRoad = 0;
        int millingMachineBridge = 0;
        int millingMachineOther =  0;

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
        int crane = 0;
        int concretePump = 0;
        int concreteMixerTruck = 0;
        int pilingMachine = 0;
        int sprinkler = 0;
        int sweeper = 0;
        int auxiliaryEquipment = 0;


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

        //Koparka Excavator
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


        //Frezarka Milling Mashine
        private void MillingMashineQuantityRoad_Clicked(object sender, EventArgs e)
        {
            millingMachineRoad++;
            MillingMachineQuantityRoad.Text = millingMachineRoad.ToString();
        }

        private void MillingMashineLessRoad_Clicked(object sender, EventArgs e)
        {
            if (millingMachineRoad > 0)
            {
                millingMachineRoad--;
            };
            MillingMachineQuantityRoad.Text = millingMachineRoad.ToString();
        }

        private void MillingMashineQuantityBridge_Clicked(object sender, EventArgs e)
        {
            millingMachineBridge++;
            MillingMachineQuantityBridge.Text = millingMachineBridge.ToString();
        }

        private void MillingMashineLessBridge_Clicked(object sender, EventArgs e)
        {
            if (millingMachineBridge > 0)
            {
                millingMachineBridge--;
            };
            MillingMachineQuantityBridge.Text = millingMachineBridge.ToString();
        }

        private void MillingMashineQuantityOther_Clicked(object sender, EventArgs e)
        {
            millingMachineOther++;
            MillingMachineQuantityOther.Text = millingMachineOther.ToString();
        }

        private void MillingMashineLessOther_Clicked(object sender, EventArgs e)
        {
            if (millingMachineOther > 0)
            {
                millingMachineOther--;
            };
            MillingMachineQuantityOther.Text = millingMachineOther.ToString();

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

        // Mini koparka/HDS mini excavator
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

        // Dźwig/Podnośnik  Crane
        private void CraneQuantity_Clicked(object sender, EventArgs e)
        {
            crane++;
            CraneQuantity.Text = crane.ToString();
        }

        private void CraneLess_Clicked(object sender, EventArgs e)
        {
            if (crane > 0)
            {
                crane--;
            };
            CraneQuantity.Text = crane.ToString();
        }

        // Pompa do betonu  Concrete pump
        private void ConcretePumpQuantity_Clicked(object sender, EventArgs e)
        {
            concretePump++;
            ConcretePumpQuantity.Text = concretePump.ToString();
        }

        private void ConcretePumpLess_Clicked(object sender, EventArgs e)
        {
            if (concretePump > 0)
            {
                concretePump--;
            };
            ConcretePumpQuantity.Text = concretePump.ToString();
        }

        // Betonowóz  Concrete mixer truck
        private void ConcreteMixerTruckQuantity_Clicked(object sender, EventArgs e)
        {
            concreteMixerTruck++;
            ConcreteMixerTruckQuantity.Text = concreteMixerTruck.ToString();
        }

        private void ConcreteMixerTruckLess_Clicked(object sender, EventArgs e)
        {
            if (concreteMixerTruck > 0)
            {
                concreteMixerTruck--;
            };
            ConcreteMixerTruckQuantity.Text = concreteMixerTruck.ToString();
        }

        // Palownica  Piling machine
        private void PilingMachineQuantity_Clicked(object sender, EventArgs e)
        {
            pilingMachine++;
            PilingMachineQuantity.Text = pilingMachine.ToString();
        }

        private void PilingMachineLess_Clicked(object sender, EventArgs e)
        {
            if (pilingMachine > 0)
            {
                pilingMachine--;
            };
            PilingMachineQuantity.Text = pilingMachine.ToString();
        }

        // Skrapiarka  Sprinkler
        private void SprinklerQuantity_Clicked(object sender, EventArgs e)
        {
            sprinkler++;
            SprinklerQuantity.Text = sprinkler.ToString();
        }

        private void SprinklerLess_Clicked(object sender, EventArgs e)
        {
            if (sprinkler > 0)
            {
                sprinkler--;
            };
            SprinklerQuantity.Text = sprinkler.ToString();
        }

        // Zamiatarka  Sweeper
        private void SweeperQuantity_Clicked(object sender, EventArgs e)
        {
            sweeper++;
            SweeperQuantity.Text = sweeper.ToString();
        }

        private void SweeperLess_Clicked(object sender, EventArgs e)
        {
            if (sweeper > 0)
            {
                sweeper--;
            };
            SweeperQuantity.Text = sweeper.ToString();
        }

        // Sprzęt pomocniczy (inne)  Auxiliary equipment (other)
        private void AuxiliaryEquipmentQuantity_Clicked(object sender, EventArgs e)
        {
            auxiliaryEquipment++;
            AuxiliaryEquipmentQuantity.Text = auxiliaryEquipment.ToString();
        }

        private void AuxiliaryEquipmentLess_Clicked(object sender, EventArgs e)
        {
            if (auxiliaryEquipment > 0)
            {
                auxiliaryEquipment--;
            };
            AuxiliaryEquipmentQuantity.Text = auxiliaryEquipment.ToString();
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
