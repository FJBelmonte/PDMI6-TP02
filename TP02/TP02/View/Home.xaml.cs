using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
            InitializeComponent();

            var contato = new Contato
            {
                Nome = "Flavio Mariotti",
                Idade = 32,
                Profissao = "Developer",
                Pais = "Brasil"
            };

            Nome.Text = contato.Nome;
            Idade.Text = Convert.ToString(contato.Idade);
            Profissao.Text = contato.Profissao;
            Pais.Text = contato.Pais;

            
        }
    }
}