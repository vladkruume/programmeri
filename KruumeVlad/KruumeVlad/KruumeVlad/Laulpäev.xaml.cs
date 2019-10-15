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
    public partial class Laulpäev : ContentPage
    {
        StackLayout stackLayout;
        Image img1;
        Button btnll;
        public Laulpäev()
        {
            btnll = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };


            img1 = new Image { Source = "Nimetu.png" };

            stackLayout = new StackLayout()
            {
                Children = { img1, btnll }
            };



            stackLayout.Spacing = 15;
            this.Content = stackLayout;
            btnll.Clicked += Btnll_ClickedAsync;
        }

        private async void Btnll_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
    }
