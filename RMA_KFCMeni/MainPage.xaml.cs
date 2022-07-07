using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RMA_KFCMeni
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            List<SlikeC> slike = new List<SlikeC>()
            {
                new SlikeC() {Source = "slider1.jpg" },
                new SlikeC() {Source = "slider2.jpg" },
                new SlikeC() {Source = "slider3.jpg" }
            };

            Carousel.ItemsSource = slike;
        }

        async void Vise_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ONama());
        }

        async void Meni_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Meni());
        }


    }
}
