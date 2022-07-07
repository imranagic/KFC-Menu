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
    public partial class Box : TabbedPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Box()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "box.jpg", Cijena=18.05f, Ime="Box Menu 2" },
                new HranaMeni{ Slika = "klasik_kosara.jpg", Cijena=15.15f, Ime="Classic Box" },
                new HranaMeni{ Slika = "strips_box.jpg", Cijena=15.15f, Ime="Strips Box" }

            };

            BindingContext = this;
        }
    }
}