using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KruumeVlad
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        StackLayout stackLayout;
        Button btne;
        Button btnt;
        Button btnk;
        Button btnn;
        Button btnr;
        Button btnl;
        Button btnp;

        public MainPage()
        {
            btne = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Esmaspäev"
            };
            btnt = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Teisipäev"
            };
            btnk = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Kolmapäev"
            };
            btnn = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Neljapäev"
            };
            btnr = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Reede"
            };
            btnl = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Laulpäev"
            };
            btnp = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Pühapäev"
            };


            btne.Clicked += Btne_ClickedAsync;
            btnt.Clicked += Btnt_ClickedAsync;
            btnk.Clicked += Btnk_ClickedAsync;
            btnn.Clicked += Btnn_ClickedAsync;
            btnr.Clicked += Btnr_ClickedAsync;
            btnl.Clicked += Btnl_ClickedAsync;
            btnp.Clicked += Btnp_ClickedAsync;
            

            stackLayout = new StackLayout()
            {
                Children = { btne, btnt, btnk,btnn,btnr,btnl,btnp }
            };
            stackLayout.Spacing = 15;
            this.Content = stackLayout;


        }

        private async void Btne_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspäev());
        }

        private async void Btnt_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipäev());
        }

        private async void Btnk_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapäev());
        }
        private async void Btnn_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Neljapäev());
        }

        private async void Btnr_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reede());
        }

        private async void Btnl_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Laulpäev());
        }
        private async void Btnp_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pühapäev());
        }
    }
}
