using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void FlipButton_Clicked(object sender, EventArgs e)
        {

            //Algoritmo
            //Verificar qual opcao esta selecionada
            //Fazer o sorteio da moeda  (Random.Next(2))
            //Exibir o lado que foi sorteado (alterar a propriedade, nome do objeto.classe) MoedaImage.Source="coroa.png"
            //Verificar se a opção é igual ao lado escolhido
            //Exibir o resultado do jogo em um alerta (DisplayAlert)
            int selectedIndex = SelecaoPicker.SelectedIndex;

            Random rnd = new Random();

            int sorteio = rnd.Next(2);

            if (sorteio == 0)
            {
                MoedaImg.Source = "cara.png";
            }
            else
            {
                MoedaImg.Source = "coroa.png";
            }

            if (selectedIndex == sorteio )
            {
                await DisplayAlert("Parabéns!", "Você ganhou!", "OK");
            }
            else
            {
                await DisplayAlert("Que pena!", "Você perdeu. Tente novamente.", "OK");
            }




        }
    }
}
