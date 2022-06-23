using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Report
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();
        }
        int count = 0;
     
        void Button_Clicked(object sender, System.EventArgs e)
        {
            
            Navigation.PushAsync(new MainPage());
        }
    }
    
}