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
    public partial class Piletina : TabbedPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Piletina()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "kentucky.jpg", Cijena=11.05f, Ime="Kentucky" },
                new HranaMeni{ Slika = "strips.png", Cijena=11.15f, Ime="Strips" },
                new HranaMeni{ Slika = "wings.jpg", Cijena=14.45f, Ime="Wings" },
                new HranaMeni{ Slika = "wings.jpg", Cijena=16f, Ime="Hot Wings" },

            };

            BindingContext = this;
        }
    }
}