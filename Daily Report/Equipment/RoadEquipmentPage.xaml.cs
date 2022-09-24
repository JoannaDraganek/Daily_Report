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
    public partial class RoadEquipmentPage : ContentPage
    {
        public RoadEquipmentPage()
        {
            InitializeComponent();
        }

        int millingMachineRoad = 0;
        int excavatorMachineRoad = 0;
        int loaderMachineRoad = 0;
        int bulldozerMachineRoad = 0;
        int dumpTruckRoad = 0;
        int backhoeLoaderRoad = 0;
        int compactorRoad = 0;
        int rollerRoad = 0;
        int graderRoad = 0;
        int paverRoad = 0;
        int miniExcavatorRoad = 0;
        int craneRoad = 0;
        int concretePumpRoad = 0;
        int concreteMixerTruckRoad = 0;
        int pilingMachineRoad = 0;
        int sprinklerRoad = 0;
        int sweeperRoad = 0;
        int auxiliaryEquipmentRoad = 0;

        
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

        //Koparka Excavator

        private void ExcavatorQuantityRoad_Clicked(object sender, EventArgs e)
        {
            excavatorMachineRoad++;
            ExcavatorQuantityRoad.Text = excavatorMachineRoad.ToString();
        }
        private void ExcavatorLessRoad_Clicked(object sender, EventArgs e)
        {
            if (excavatorMachineRoad > 0)
            {
                excavatorMachineRoad--;
            };
            ExcavatorQuantityRoad.Text = excavatorMachineRoad.ToString();
        }
        
                //Ładowarka loader
                private void LoaderQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    loaderMachineRoad++;
                    LoaderQuantityRoad.Text = loaderMachineRoad.ToString();
                }

                private void LoaderLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (loaderMachineRoad > 0)
                    {
                        loaderMachineRoad--;
                     };
                     LoaderQuantityRoad.Text = loaderMachineRoad.ToString();
                }

                //Spycharka bulldozer
                private void BulldozerQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    bulldozerMachineRoad++;
                    BulldozerQuantityRoad.Text = bulldozerMachineRoad.ToString();
                }

                private void BulldozerLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (bulldozerMachineRoad > 0)
                    {
                        bulldozerMachineRoad--;
                    };
                    BulldozerQuantityRoad.Text = bulldozerMachineRoad.ToString();
                }

                //Wywrotka/samochód samowyładowczy  dump truck
                private void DumpTruckQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    dumpTruckRoad++;
                    DumpTruckQuantityRoad.Text = dumpTruckRoad.ToString();
                }

                private void DumpTruckLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (dumpTruckRoad > 0)
                    {
                         dumpTruckRoad--;
                    };
                    DumpTruckQuantityRoad.Text = dumpTruckRoad.ToString();
                }

                //Koparko-ładowarki backhoe loader
                private void BackhoeLoaderQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    backhoeLoaderRoad++;
                    BackhoeLoaderQuantityRoad.Text = backhoeLoaderRoad.ToString();
                }

                private void BackhoeLoaderLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (backhoeLoaderRoad > 0)
                    {
                        backhoeLoaderRoad--;
                    };
                    BackhoeLoaderQuantityRoad.Text = backhoeLoaderRoad.ToString();
                }

                //Zagęszczarka Compactor
                private void CompactorQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    compactorRoad++;
                    CompactorQuantityRoad.Text = compactorRoad.ToString();
                }

                private void CompactorLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (compactorRoad > 0)
                    {
                        compactorRoad--;
                    };
                    CompactorQuantityRoad.Text = compactorRoad.ToString();
                }

                //Walec roller
                private void RollerQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    rollerRoad++;
                    RollerQuantityRoad.Text = rollerRoad.ToString();
                }

                private void RollerLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (rollerRoad > 0)
                    {
                        rollerRoad--;
                    };
                    RollerQuantityRoad.Text = rollerRoad.ToString();
                }

                // Równiarka grader
                private void GraderQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    graderRoad++;
                    GraderQuantityRoad.Text = graderRoad.ToString();
                }

                private void GraderLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (graderRoad > 0)
                    {
                         graderRoad--;
                    };
                     GraderQuantityRoad.Text = graderRoad.ToString();
                }

                // Rozściełacz Paver
                private void PaverQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    paverRoad++;
                    PaverQuantityRoad.Text = paverRoad.ToString();
                }

                private void PaverLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (paverRoad > 0)
                    {
                         paverRoad--;
                    };
                     PaverQuantityRoad.Text = paverRoad.ToString();
                }

                // Mini koparka/HDS mini excavator
                private void MiniExcavatorQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    miniExcavatorRoad++;
                    MiniExcavatorQuantityRoad.Text = miniExcavatorRoad.ToString();
                }

                private void MiniExcavatorLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (miniExcavatorRoad > 0)
                    {
                        miniExcavatorRoad--;
                    };
                    MiniExcavatorQuantityRoad.Text = miniExcavatorRoad.ToString();
                }

                // Dźwig/Podnośnik  Crane
                private void CraneQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    craneRoad++;
                    CraneQuantityRoad.Text = craneRoad.ToString();
                }

                private void CraneLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (craneRoad > 0)
                    {
                         craneRoad--;
                    };
                     CraneQuantityRoad.Text = craneRoad.ToString();
                }

                // Pompa do betonu  Concrete pump
                private void ConcretePumpQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    concretePumpRoad++;
                    ConcretePumpQuantityRoad.Text = concretePumpRoad.ToString();
                }

                private void ConcretePumpLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (concretePumpRoad > 0)
                    {
                        concretePumpRoad--;
                    };
                    ConcretePumpQuantityRoad.Text = concretePumpRoad.ToString();
                }

                // Betonowóz  Concrete mixer truck
                private void ConcreteMixerTruckQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    concreteMixerTruckRoad++;
                    ConcreteMixerTruckQuantityRoad.Text = concreteMixerTruckRoad.ToString();
                }

                private void ConcreteMixerTruckLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (concreteMixerTruckRoad > 0)
                    {
                       concreteMixerTruckRoad--;
                    };
                     ConcreteMixerTruckQuantityRoad.Text = concreteMixerTruckRoad.ToString();
                }

                // Palownica  Piling machine
                private void PilingMachineQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    pilingMachineRoad++;
                    PilingMachineQuantityRoad.Text = pilingMachineRoad.ToString();
                }

                private void PilingMachineLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (pilingMachineRoad > 0)
                    {
                        pilingMachineRoad--;
                    };
                    PilingMachineQuantityRoad.Text = pilingMachineRoad.ToString();
                }

                // Skrapiarka  Sprinkler
                private void SprinklerQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    sprinklerRoad++;
                    SprinklerQuantityRoad.Text = sprinklerRoad.ToString();
                }

                private void SprinklerLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (sprinklerRoad > 0)
                    {
                          sprinklerRoad--;
                    };
                    SprinklerQuantityRoad.Text = sprinklerRoad.ToString();
                }

                // Zamiatarka  Sweeper
                private void SweeperQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    sweeperRoad++;
                    SweeperQuantityRoad.Text = sweeperRoad.ToString();
                }

                private void SweeperLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (sweeperRoad > 0)
                    {
                      sweeperRoad--;
                    };
                     SweeperQuantityRoad.Text = sweeperRoad.ToString();
                }

                // Sprzęt pomocniczy (inne)  Auxiliary equipment (other)
                private void AuxiliaryEquipmentQuantityRoad_Clicked(object sender, EventArgs e)
                {
                    auxiliaryEquipmentRoad++;
                    AuxiliaryEquipmentQuantityRoad.Text = auxiliaryEquipmentRoad.ToString();
                }

                private void AuxiliaryEquipmentLessRoad_Clicked(object sender, EventArgs e)
                {
                    if (auxiliaryEquipmentRoad > 0)
                    {
                         auxiliaryEquipmentRoad--;
                    };
                    AuxiliaryEquipmentQuantityRoad.Text = auxiliaryEquipmentRoad.ToString();
                }

    }
}