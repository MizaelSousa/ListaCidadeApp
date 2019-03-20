using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaCidadeApp
{
    public partial class ListView_Page : ContentPage
    {
        public ListView_Page(List<string> lista)
        {
            InitializeComponent();
            lista_de_dados.ItemsSource = lista;
        }

        void Voltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public ListView_Page()
        {
            InitializeComponent();
        }
    }
}
