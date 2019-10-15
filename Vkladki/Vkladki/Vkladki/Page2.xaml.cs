using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vkladki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Sc_OnChanged(object sender, ToggledEventArgs e)
        {
            if(sc.On)
            {
                img.ImageSource = "androidd.png";


            }
            else
            {
                img.ImageSource = "android.png";



            }
        }

        async void Share_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = "text",
                Title = "Share Text"
            });
        }
    }
}