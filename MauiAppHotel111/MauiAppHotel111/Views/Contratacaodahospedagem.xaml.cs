using Microsoft.Maui.Controls;

namespace MauiAppHotel111.Views
{
    public partial class Contratacaodahospedagem : ContentPage
    {
        public Contratacaodahospedagem()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;
            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sobre());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", "N�o foi poss�vel abrir a p�gina Sobre. " + ex.Message, "OK");
            }
        }
    }
}

