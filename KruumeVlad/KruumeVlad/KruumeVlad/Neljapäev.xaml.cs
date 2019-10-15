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
    public partial class Neljapäev : ContentPage
    {
        StackLayout stackLayout;
        Image img1;
        Button btnnn;
        public Neljapäev()
        {
            btnnn = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };

            img1 = new Image { Source = "Nimetu.png" };

            stackLayout = new StackLayout()
            {
                Children = { img1, btnnn }
            };

            stackLayout.Spacing = 15;
            this.Content = stackLayout;
            btnnn.Clicked += Btnnn_ClickedAsync;
        }
        private async void Btnnn_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
