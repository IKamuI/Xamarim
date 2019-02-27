using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_consultarCEP.Servico.Modelo;
using App01_consultarCEP.Servico;

namespace App01_consultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs e)
        {
            string cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = $"Endereco: {end.bairro} CEP: {end.cep}" +
                            $"Rua: {end.logradouro} UF: {end.uf}";

        }
    }
}
