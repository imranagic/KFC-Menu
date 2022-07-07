using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RMA_KFCMeni.DetMeni
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sok : ContentPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Sok()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "pep.jpg", Cijena=3.00f, Ime="Pepsi" },
                new HranaMeni{ Slika = "cappuccino.jpg", Cijena=2.25f, Ime="Cappuccino" },


            };

            BindingContext = this;
        }
    }
}