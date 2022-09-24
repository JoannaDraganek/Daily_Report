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
    public partial class OtherEquipmentPage : ContentPage
    {
        public OtherEquipmentPage()
        {
            InitializeComponent();
        }
        int millingMachineOther = 0;
        int excavatorMachineOther = 0;
        int loaderMachineOther = 0;
        int bulldozerMachineOther = 0;
        int dumpTruckOther = 0;
        int backhoeLoaderOther = 0;
        int compactorOther = 0;
        int rollerOther = 0;
        int graderOther = 0;
        int paverOther = 0;
        int miniExcavatorOther = 0;
        int craneOther = 0;
        int concretePumpOther = 0;
        int concreteMixerTruckOther = 0;
        int pilingMachineOther = 0;
        int sprinklerOther = 0;
        int sweeperOther = 0;
        int auxiliaryEquipmentOther = 0;


        //Frezarka Milling Mashine
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

        //Koparka Excavator

        private void ExcavatorQuantityOther_Clicked(object sender, EventArgs e)
        {
            excavatorMachineOther++;
            ExcavatorQuantityOther.Text = excavatorMachineOther.ToString();
        }
        private void ExcavatorLessOther_Clicked(object sender, EventArgs e)
        {
            if (excavatorMachineOther > 0)
            {
                excavatorMachineOther--;
            };
            ExcavatorQuantityOther.Text = excavatorMachineOther.ToString();
        }

        //Ładowarka loader
        private void LoaderQuantityOther_Clicked(object sender, EventArgs e)
        {
            loaderMachineOther++;
            LoaderQuantityOther.Text = loaderMachineOther.ToString();
        }

        private void LoaderLessOther_Clicked(object sender, EventArgs e)
        {
            if (loaderMachineOther > 0)
            {
                loaderMachineOther--;
            };
            LoaderQuantityOther.Text = loaderMachineOther.ToString();
        }

        //Spycharka bulldozer
        private void BulldozerQuantityOther_Clicked(object sender, EventArgs e)
        {
            bulldozerMachineOther++;
            BulldozerQuantityOther.Text = bulldozerMachineOther.ToString();
        }

        private void BulldozerLessOther_Clicked(object sender, EventArgs e)
        {
            if (bulldozerMachineOther > 0)
            {
                bulldozerMachineOther--;
            };
            BulldozerQuantityOther.Text = bulldozerMachineOther.ToString();
        }

        //Wywrotka/samochód samowyładowczy  dump truck
        private void DumpTruckQuantityOther_Clicked(object sender, EventArgs e)
        {
            dumpTruckOther++;
            DumpTruckQuantityOther.Text = dumpTruckOther.ToString();
        }

        private void DumpTruckLessOther_Clicked(object sender, EventArgs e)
        {
            if (dumpTruckOther > 0)
            {
                dumpTruckOther--;
            };
            DumpTruckQuantityOther.Text = dumpTruckOther.ToString();
        }

        //Koparko-ładowarki backhoe loader
        private void BackhoeLoaderQuantityOther_Clicked(object sender, EventArgs e)
        {
            backhoeLoaderOther++;
            BackhoeLoaderQuantityOther.Text = backhoeLoaderOther.ToString();
        }

        private void BackhoeLoaderLessOther_Clicked(object sender, EventArgs e)
        {
            if (backhoeLoaderOther > 0)
            {
                backhoeLoaderOther--;
            };
            BackhoeLoaderQuantityOther.Text = backhoeLoaderOther.ToString();
        }

        //Zagęszczarka Compactor
        private void CompactorQuantityOther_Clicked(object sender, EventArgs e)
        {
            compactorOther++;
            CompactorQuantityOther.Text = compactorOther.ToString();
        }

        private void CompactorLessOther_Clicked(object sender, EventArgs e)
        {
            if (compactorOther > 0)
            {
                compactorOther--;
            };
            CompactorQuantityOther.Text = compactorOther.ToString();
        }

        //Walec roller
        private void RollerQuantityOther_Clicked(object sender, EventArgs e)
        {
            rollerOther++;
            RollerQuantityOther.Text = rollerOther.ToString();
        }

        private void RollerLessOther_Clicked(object sender, EventArgs e)
        {
            if (rollerOther > 0)
            {
                rollerOther--;
            };
            RollerQuantityOther.Text = rollerOther.ToString();
        }

        // Równiarka grader
        private void GraderQuantityOther_Clicked(object sender, EventArgs e)
        {
            graderOther++;
            GraderQuantityOther.Text = graderOther.ToString();
        }

        private void GraderLessOther_Clicked(object sender, EventArgs e)
        {
            if (graderOther > 0)
            {
                graderOther--;
            };
            GraderQuantityOther.Text = graderOther.ToString();
        }

        // Rozściełacz Paver
        private void PaverQuantityOther_Clicked(object sender, EventArgs e)
        {
            paverOther++;
            PaverQuantityOther.Text = paverOther.ToString();
        }

        private void PaverLessOther_Clicked(object sender, EventArgs e)
        {
            if (paverOther > 0)
            {
                paverOther--;
            };
            PaverQuantityOther.Text = paverOther.ToString();
        }

        // Mini koparka/HDS mini excavator
        private void MiniExcavatorQuantityOther_Clicked(object sender, EventArgs e)
        {
            miniExcavatorOther++;
            MiniExcavatorQuantityOther.Text = miniExcavatorOther.ToString();
        }

        private void MiniExcavatorLessOther_Clicked(object sender, EventArgs e)
        {
            if (miniExcavatorOther > 0)
            {
                miniExcavatorOther--;
            };
            MiniExcavatorQuantityOther.Text = miniExcavatorOther.ToString();
        }

        // Dźwig/Podnośnik  Crane
        private void CraneQuantityOther_Clicked(object sender, EventArgs e)
        {
            craneOther++;
            CraneQuantityOther.Text = craneOther.ToString();
        }

        private void CraneLessOther_Clicked(object sender, EventArgs e)
        {
            if (craneOther > 0)
            {
                craneOther--;
            };
            CraneQuantityOther.Text = craneOther.ToString();
        }

        // Pompa do betonu  Concrete pump
        private void ConcretePumpQuantityOther_Clicked(object sender, EventArgs e)
        {
            concretePumpOther++;
            ConcretePumpQuantityOther.Text = concretePumpOther.ToString();
        }

        private void ConcretePumpLessOther_Clicked(object sender, EventArgs e)
        {
            if (concretePumpOther > 0)
            {
                concretePumpOther--;
            };
            ConcretePumpQuantityOther.Text = concretePumpOther.ToString();
        }

        // Betonowóz  Concrete mixer truck
        private void ConcreteMixerTruckQuantityOther_Clicked(object sender, EventArgs e)
        {
            concreteMixerTruckOther++;
            ConcreteMixerTruckQuantityOther.Text = concreteMixerTruckOther.ToString();
        }

        private void ConcreteMixerTruckLessOther_Clicked(object sender, EventArgs e)
        {
            if (concreteMixerTruckOther > 0)
            {
                concreteMixerTruckOther--;
            };
            ConcreteMixerTruckQuantityOther.Text = concreteMixerTruckOther.ToString();
        }

        // Palownica  Piling machine
        private void PilingMachineQuantityOther_Clicked(object sender, EventArgs e)
        {
            pilingMachineOther++;
            PilingMachineQuantityOther.Text = pilingMachineOther.ToString();
        }

        private void PilingMachineLessOther_Clicked(object sender, EventArgs e)
        {
            if (pilingMachineOther > 0)
            {
                pilingMachineOther--;
            };
            PilingMachineQuantityOther.Text = pilingMachineOther.ToString();
        }

        // Skrapiarka  Sprinkler
        private void SprinklerQuantityOther_Clicked(object sender, EventArgs e)
        {
            sprinklerOther++;
            SprinklerQuantityOther.Text = sprinklerOther.ToString();
        }

        private void SprinklerLessOther_Clicked(object sender, EventArgs e)
        {
            if (sprinklerOther > 0)
            {
                sprinklerOther--;
            };
            SprinklerQuantityOther.Text = sprinklerOther.ToString();
        }

        // Zamiatarka  Sweeper
        private void SweeperQuantityOther_Clicked(object sender, EventArgs e)
        {
            sweeperOther++;
            SweeperQuantityOther.Text = sweeperOther.ToString();
        }

        private void SweeperLessOther_Clicked(object sender, EventArgs e)
        {
            if (sweeperOther > 0)
            {
                sweeperOther--;
            };
            SweeperQuantityOther.Text = sweeperOther.ToString();
        }

        // Sprzęt pomocniczy (inne)  Auxiliary equipment (other)
        private void AuxiliaryEquipmentQuantityOther_Clicked(object sender, EventArgs e)
        {
            auxiliaryEquipmentOther++;
            AuxiliaryEquipmentQuantityOther.Text = auxiliaryEquipmentOther.ToString();
        }

        private void AuxiliaryEquipmentLessOther_Clicked(object sender, EventArgs e)
        {
            if (auxiliaryEquipmentOther > 0)
            {
                auxiliaryEquipmentOther--;
            };
            AuxiliaryEquipmentQuantityOther.Text = auxiliaryEquipmentOther.ToString();
        }

    }
}