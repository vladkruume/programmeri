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
    public partial class Esmaspäev : ContentPage
    {
        StackLayout stackLayout;
        Image img1;
        Image img2;
        Image img3;
        Image img4;
        Image img5;
        Image img6;
        Label lbl1;
        Label lbl2;
        Label lbl3;
        Label lbl4;
        Label lbl5;
        Label lbl6;


        Button btnee;
        public Esmaspäev()
        {
            btnee = new Button()
            {
                BackgroundColor = Color.DarkGray,
                Text = "Menu"
            };

            lbl1 = new Label()
            {
                Text = "9:20-10:05"
            };

            lbl2 = new Label()
            {
                Text = "10:10-10:55"
            };

            lbl3 = new Label()
            {
                Text = "11:00-11:45"
            };

            lbl4 = new Label()
            {
                Text = "12:40-13:25"
            };

            lbl5 = new Label()
            {
                Text = "13:30-14:15"
            };

            lbl6 = new Label()
            {
                Text = "14:20-15:55"
            };


            img1 = new Image {
                Source = "matemE.png",
                HeightRequest=200
                
            };
            img2 = new Image { Source = "anglhtmlE.png" , HeightRequest = 200 };
            img3 = new Image { Source = "kbE.png" , HeightRequest = 200 };
            img4 = new Image { Source = "fisikaE.png", HeightRequest = 200 };
            img5 = new Image { Source = "kE.png" , HeightRequest = 200 };
            img6 = new Image { Source = "multE.png" , HeightRequest = 200 };

            stackLayout = new StackLayout()
            {
                Children = { btnee, lbl1, img1, lbl2, img2, lbl3, img3, lbl4,img4, lbl5,img5, lbl6,img6 }
            };
            stackLayout.Spacing = 15;
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;
            btnee.Clicked += Btnee_ClickedAsync;
        }

        private async void Btnee_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}