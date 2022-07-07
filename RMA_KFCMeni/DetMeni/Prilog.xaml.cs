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
    public partial class Prilog : TabbedPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Prilog()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "prilog.png", Cijena=3.00f, Ime="Pomfrit" },
                new HranaMeni{ Slika = "onion_rings.jpg", Cijena=15.15f, Ime="Onion Rings" },
                new HranaMeni{ Slika = "kukuruz.jpg", Cijena=15.15f, Ime="Kukuruz" }

            };

            BindingContext = this;
        }
    }
}