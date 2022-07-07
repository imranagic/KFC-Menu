
using RMA_KFCMeni.DetMeni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RMA_KFCMeni
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Meni : ContentPage
    {
        public Meni()
        {
            InitializeComponent();
        }

        private async void Logo_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ONama());
        }

        private async void Piletina_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Piletina());
        }

        private async void Sendvici_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sendvic());
        }

        private async void Box_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Box());
        }

        private async void Prilog_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Prilog());
        }

        private async void Sla_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sladoledi());
        }

        private async void Sok_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Sok());
        }
    }
}