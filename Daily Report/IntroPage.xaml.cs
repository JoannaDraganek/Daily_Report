using Daily_Report.Resources;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Globalization;
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


        
       
        void PL_Clicked(object sender, System.EventArgs e)
        {
            var culture = new CultureInfo("pl");
            AppResources.Culture = culture;
            CrossMultilingual.Current.CurrentCultureInfo = culture;
            RefreshTranslation();
        }

        void ENG_Clicked(object sender, System.EventArgs e)
        {
            var culture = new CultureInfo("en");
            AppResources.Culture = culture;
            CrossMultilingual.Current.CurrentCultureInfo = culture;
            RefreshTranslation();          
        }

        void RefreshTranslation ()
        {
            Greeting.Text = AppResources.Greeting;
            Note.Text = AppResources.Note;
            Note2.Text = AppResources.Note2;
            Npage.Text = AppResources.Npage;
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            
            Navigation.PushAsync(new MainPage());
        }
    }
    
}