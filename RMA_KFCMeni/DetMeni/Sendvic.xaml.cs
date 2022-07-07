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
    public partial class Sendvic : TabbedPage
    {
        public IList<HranaMeni> Hrana { get; private set; }
        public Sendvic()
        {
            InitializeComponent();
            Hrana = new List<HranaMeni>
            {
                new HranaMeni{ Slika = "wrapper.jpg", Cijena=8.05f, Ime="BBQ Wrapper" },
                new HranaMeni{ Slika = "sendvici.png", Cijena=10.15f, Ime="Golden Kentucky Wrapper" },
                
                

            };

            BindingContext = this;
        }
    }
}