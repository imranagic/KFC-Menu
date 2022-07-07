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
    public partial class Sladoledi : TabbedPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Sladoledi()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "sladoled.png", Cijena=3.00f, Ime="Sladoled Cokolada" },
                new HranaMeni{ Slika = "sladoled_k.jpg", Cijena=15.15f, Ime="Sladoled Karamela" },


            };

            BindingContext = this;
        }
    }
}