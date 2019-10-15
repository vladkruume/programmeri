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
    public partial class Reede : ContentPage
    {
        StackLayout stackLayout;
        Image img1;
        Button btnrr;
        public Reede()
        {
            btnrr = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };


            img1 = new Image { Source = "Nimetu.png" };
            stackLayout = new StackLayout()
            {
                Children = { img1, btnrr }
            };


            stackLayout.Spacing = 15;
            this.Content = stackLayout;
            btnrr.Clicked += Btnrr_ClickedAsync;
        }

        private async void Btnrr_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
