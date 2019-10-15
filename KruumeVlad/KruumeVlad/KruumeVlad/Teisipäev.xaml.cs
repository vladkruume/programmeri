using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KruumeVlad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipäev : ContentPage
    {       
        Button btntt;
        StackLayout stackLayout;
        Image img1;
        public Teisipäev()
        {
            btntt = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };


            img1 = new Image { Source = "Nimetu.png" };
            stackLayout = new StackLayout()
            {
                Children = { img1, btntt }
            };


            stackLayout.Spacing = 15;
            this.Content = stackLayout;
            btntt.Clicked += Btntt_ClickedAsync;
        }

        private async void Btntt_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}