﻿
using MauiAppHotel111.Models;

namespace MauiAppHotel111
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.0
            },

            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.00,
                ValorDiariaCrianca = 40.0
            },

            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.00,
                ValorDiariaCrianca = 25.0
            },

            new Quarto()
            {
                Descricao = "Suíte Básica",
                ValorDiariaAdulto = 25.00,
                ValorDiariaCrianca = 12.50
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Contratacaodahospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
