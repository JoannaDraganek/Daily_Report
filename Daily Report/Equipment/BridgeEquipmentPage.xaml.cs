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
    public partial class BridgeEquipmentPage : ContentPage
    {
        public BridgeEquipmentPage()
        {
            InitializeComponent();
        }
        int millingMachineBridge = 0;
        int excavatorMachineBridge = 0;
        int loaderMachineBridge = 0;
        int bulldozerMachineBridge = 0;
        int dumpTruckBridge = 0;
        int backhoeLoaderBridge = 0;
        int compactorBridge = 0;
        int rollerBridge = 0;
        int graderBridge = 0;
        int paverBridge = 0;
        int miniExcavatorBridge = 0;
        int craneBridge = 0;
        int concretePumpBridge = 0;
        int concreteMixerTruckBridge = 0;
        int pilingMachineBridge = 0;
        int sprinklerBridge = 0;
        int sweeperBridge = 0;
        int auxiliaryEquipmentBridge = 0;


        //Frezarka Milling Mashine
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

        //Koparka Excavator

        private void ExcavatorQuantityBridge_Clicked(object sender, EventArgs e)
        {
            excavatorMachineBridge++;
            ExcavatorQuantityBridge.Text = excavatorMachineBridge.ToString();
        }
        private void ExcavatorLessBridge_Clicked(object sender, EventArgs e)
        {
            if (excavatorMachineBridge > 0)
            {
                excavatorMachineBridge--;
            };
            ExcavatorQuantityBridge.Text = excavatorMachineBridge.ToString();
        }

        //Ładowarka loader
        private void LoaderQuantityBridge_Clicked(object sender, EventArgs e)
        {
            loaderMachineBridge++;
            LoaderQuantityBridge.Text = loaderMachineBridge.ToString();
        }

        private void LoaderLessBridge_Clicked(object sender, EventArgs e)
        {
            if (loaderMachineBridge > 0)
            {
                loaderMachineBridge--;
            };
            LoaderQuantityBridge.Text = loaderMachineBridge.ToString();
        }

        //Spycharka bulldozer
        private void BulldozerQuantityBridge_Clicked(object sender, EventArgs e)
        {
            bulldozerMachineBridge++;
            BulldozerQuantityBridge.Text = bulldozerMachineBridge.ToString();
        }

        private void BulldozerLessBridge_Clicked(object sender, EventArgs e)
        {
            if (bulldozerMachineBridge > 0)
            {
                bulldozerMachineBridge--;
            };
            BulldozerQuantityBridge.Text = bulldozerMachineBridge.ToString();
        }

        //Wywrotka/samochód samowyładowczy  dump truck
        private void DumpTruckQuantityBridge_Clicked(object sender, EventArgs e)
        {
            dumpTruckBridge++;
            DumpTruckQuantityBridge.Text = dumpTruckBridge.ToString();
        }

        private void DumpTruckLessBridge_Clicked(object sender, EventArgs e)
        {
            if (dumpTruckBridge > 0)
            {
                dumpTruckBridge--;
            };
            DumpTruckQuantityBridge.Text = dumpTruckBridge.ToString();
        }

        //Koparko-ładowarki backhoe loader
        private void BackhoeLoaderQuantityBridge_Clicked(object sender, EventArgs e)
        {
            backhoeLoaderBridge++;
            BackhoeLoaderQuantityBridge.Text = backhoeLoaderBridge.ToString();
        }

        private void BackhoeLoaderLessBridge_Clicked(object sender, EventArgs e)
        {
            if (backhoeLoaderBridge > 0)
            {
                backhoeLoaderBridge--;
            };
            BackhoeLoaderQuantityBridge.Text = backhoeLoaderBridge.ToString();
        }

        //Zagęszczarka Compactor
        private void CompactorQuantityBridge_Clicked(object sender, EventArgs e)
        {
            compactorBridge++;
            CompactorQuantityBridge.Text = compactorBridge.ToString();
        }

        private void CompactorLessBridge_Clicked(object sender, EventArgs e)
        {
            if (compactorBridge > 0)
            {
                compactorBridge--;
            };
            CompactorQuantityBridge.Text = compactorBridge.ToString();
        }

        //Walec roller
        private void RollerQuantityBridge_Clicked(object sender, EventArgs e)
        {
            rollerBridge++;
            RollerQuantityBridge.Text = rollerBridge.ToString();
        }

        private void RollerLessBridge_Clicked(object sender, EventArgs e)
        {
            if (rollerBridge > 0)
            {
                rollerBridge--;
            };
            RollerQuantityBridge.Text = rollerBridge.ToString();
        }

        // Równiarka grader
        private void GraderQuantityBridge_Clicked(object sender, EventArgs e)
        {
            graderBridge++;
            GraderQuantityBridge.Text = graderBridge.ToString();
        }

        private void GraderLessBridge_Clicked(object sender, EventArgs e)
        {
            if (graderBridge > 0)
            {
                graderBridge--;
            };
            GraderQuantityBridge.Text = graderBridge.ToString();
        }

        // Rozściełacz Paver
        private void PaverQuantityBridge_Clicked(object sender, EventArgs e)
        {
            paverBridge++;
            PaverQuantityBridge.Text = paverBridge.ToString();
        }

        private void PaverLessBridge_Clicked(object sender, EventArgs e)
        {
            if (paverBridge > 0)
            {
                paverBridge--;
            };
            PaverQuantityBridge.Text = paverBridge.ToString();
        }

        // Mini koparka/HDS mini excavator
        private void MiniExcavatorQuantityBridge_Clicked(object sender, EventArgs e)
        {
            miniExcavatorBridge++;
            MiniExcavatorQuantityBridge.Text = miniExcavatorBridge.ToString();
        }

        private void MiniExcavatorLessBridge_Clicked(object sender, EventArgs e)
        {
            if (miniExcavatorBridge > 0)
            {
                miniExcavatorBridge--;
            };
            MiniExcavatorQuantityBridge.Text = miniExcavatorBridge.ToString();
        }

        // Dźwig/Podnośnik  Crane
        private void CraneQuantityBridge_Clicked(object sender, EventArgs e)
        {
            craneBridge++;
            CraneQuantityBridge.Text = craneBridge.ToString();
        }

        private void CraneLessBridge_Clicked(object sender, EventArgs e)
        {
            if (craneBridge > 0)
            {
                craneBridge--;
            };
            CraneQuantityBridge.Text = craneBridge.ToString();
        }

        // Pompa do betonu  Concrete pump
        private void ConcretePumpQuantityBridge_Clicked(object sender, EventArgs e)
        {
            concretePumpBridge++;
            ConcretePumpQuantityBridge.Text = concretePumpBridge.ToString();
        }

        private void ConcretePumpLessBridge_Clicked(object sender, EventArgs e)
        {
            if (concretePumpBridge > 0)
            {
                concretePumpBridge--;
            };
            ConcretePumpQuantityBridge.Text = concretePumpBridge.ToString();
        }

        // Betonowóz  Concrete mixer truck
        private void ConcreteMixerTruckQuantityBridge_Clicked(object sender, EventArgs e)
        {
            concreteMixerTruckBridge++;
            ConcreteMixerTruckQuantityBridge.Text = concreteMixerTruckBridge.ToString();
        }

        private void ConcreteMixerTruckLessBridge_Clicked(object sender, EventArgs e)
        {
            if (concreteMixerTruckBridge > 0)
            {
                concreteMixerTruckBridge--;
            };
            ConcreteMixerTruckQuantityBridge.Text = concreteMixerTruckBridge.ToString();
        }

        // Palownica  Piling machine
        private void PilingMachineQuantityBridge_Clicked(object sender, EventArgs e)
        {
            pilingMachineBridge++;
            PilingMachineQuantityBridge.Text = pilingMachineBridge.ToString();
        }

        private void PilingMachineLessBridge_Clicked(object sender, EventArgs e)
        {
            if (pilingMachineBridge > 0)
            {
                pilingMachineBridge--;
            };
            PilingMachineQuantityBridge.Text = pilingMachineBridge.ToString();
        }

        // Skrapiarka  Sprinkler
        private void SprinklerQuantityBridge_Clicked(object sender, EventArgs e)
        {
            sprinklerBridge++;
            SprinklerQuantityBridge.Text = sprinklerBridge.ToString();
        }

        private void SprinklerLessBridge_Clicked(object sender, EventArgs e)
        {
            if (sprinklerBridge > 0)
            {
                sprinklerBridge--;
            };
            SprinklerQuantityBridge.Text = sprinklerBridge.ToString();
        }

        // Zamiatarka  Sweeper
        private void SweeperQuantityBridge_Clicked(object sender, EventArgs e)
        {
            sweeperBridge++;
            SweeperQuantityBridge.Text = sweeperBridge.ToString();
        }

        private void SweeperLessBridge_Clicked(object sender, EventArgs e)
        {
            if (sweeperBridge > 0)
            {
                sweeperBridge--;
            };
            SweeperQuantityBridge.Text = sweeperBridge.ToString();
        }

        // Sprzęt pomocniczy (inne)  Auxiliary equipment (other)
        private void AuxiliaryEquipmentQuantityBridge_Clicked(object sender, EventArgs e)
        {
            auxiliaryEquipmentBridge++;
            AuxiliaryEquipmentQuantityBridge.Text = auxiliaryEquipmentBridge.ToString();
        }

        private void AuxiliaryEquipmentLessBridge_Clicked(object sender, EventArgs e)
        {
            if (auxiliaryEquipmentBridge > 0)
            {
                auxiliaryEquipmentBridge--;
            };
            AuxiliaryEquipmentQuantityBridge.Text = auxiliaryEquipmentBridge.ToString();
        }

    }
}