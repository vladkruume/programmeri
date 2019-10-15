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
    public partial class Pühapäev : ContentPage
    {
        StackLayout stackLayout;
        Image img1;
        Button btnpp;
        public Pühapäev()
        {
            btnpp = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };


            img1 = new Image { Source = "Nimetu.png" };
            stackLayout = new StackLayout()
            {
                Children = { img1, btnpp }
            };


            stackLayout.Spacing = 15;
            this.Content = stackLayout;
            btnpp.Clicked += Btnpp_ClickedAsync;
        }

        private async void Btnpp_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
    }
