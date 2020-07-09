using Campeonato_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        public IList<Jogo> Jogos { get; private set; }
        public PrincipalView()
        {
            InitializeComponent();

            Jogos = new List<Jogo>();
            Jogos.Add(new Jogo
            {
                id = 1,
                selecaoCasa = "Brasil",
                selecaoVisitante = "Argentina",
                placarCasa = 2,
                placarVisitante = 0,
                data = Convert.ToDateTime("01/07/2020"),
                estadio = "Arena Fonte Nova",
            });

            Jogos.Add(new Jogo
            {
                id = 2,
                selecaoCasa = "Brasil",
                selecaoVisitante = "Alemanha",
                placarCasa = 1,
                placarVisitante = 7,
                data = Convert.ToDateTime("07/07/2020"),
                estadio = "Arena Grêmio",

            });

            BindingContext = this;
        }
    }
}