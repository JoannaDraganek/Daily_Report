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
    public partial class EquipmentTabs : TabbedPage
    {
        // 4  Tabs in  Action Bar
        public EquipmentTabs()
        {
            InitializeComponent();
        }
    
    }
}