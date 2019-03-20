using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaCidadeApp.Model;

namespace ListaCidadeApp
{
    public partial class MainPage : ContentPage
    {

        //Nome nome = new Nome();
        List<string> lista = new List<string>();
        List<string> listaEncontrado = new List<string>();

        void ChecarLista(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListView_Page(lista));
        }

        void Adicionar(object sender, System.EventArgs e)
        {
            Cidade cidade = new Cidade();
            cidade.nome = campoAddCidade.Text;
            cidade.uf = campoAddUf.Text;

            string conteudo = cidade.nome + " - " + cidade.uf;

            lista.Add(conteudo);

            campoAddCidade.Text = string.Empty;
            campoAddUf.Text = string.Empty;

            //lista.Add(campo_pra_add_ou_remover.Text);
        }

        void Buscar(object sender, System.EventArgs e)
        {
            listaEncontrado.Clear();
            int qtdItens = lista.Count - 1;
            int indice = Convert.ToInt32(valor_indice.Text);

            if (indice > qtdItens)
            {
                label_status.Text = "Item Invalido";
                label_status.TextColor = Color.Red;
            }
            else
            {
                label_status.Text = "Status...";
                label_status.TextColor = Color.Blue;
                //lista = lista[indice];
                listaEncontrado.Add(lista[indice]);
                Navigation.PushAsync(new ListView_Page(listaEncontrado));
            }
        }

        void Remover(object sender, System.EventArgs e)
        {
            lista.Remove(campoAddCidade.Text);
            lista.Remove(campoAddUf.Text);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
