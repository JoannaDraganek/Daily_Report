using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Report.Equipment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkersEquipmentPage : ContentPage
    {
        public WorkersEquipmentPage()
        {
            InitializeComponent();
        }
        int roadmanWorkers = 0;
        int bridgeWorkers = 0;
        int otherWorkers = 0;
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

    }
}