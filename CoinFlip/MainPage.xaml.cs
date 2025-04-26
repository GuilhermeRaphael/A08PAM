using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System.Security.Cryptography.X509Certificates;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        Game jogo = new Game();


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


            /* COMO FAZER O GIF DA MOEDA 
            MoedaImg.Source = "giro.gif";
            MoedaImg.IsAnimationPlaying = true;
            await Task.Delay(1500);
            string escolha;
            MoedaImg.IsAnimationPlaying = false;
            */

            Coin moeda = new Coin();
            MoedaImg.Source = moeda.Flip() + ".png";


            int sorteio = moeda.LadoSorteado == "Cara" ? 0 : 1;
            
            /*
             if (pickselect == sorteio )
             {
                 await DisplayAlert("Parabéns!", "Você ganhou!", "OK");
                  seq++;
             }
             else
             {
                 await DisplayAlert("Que pena!", "Você perdeu. Tente novamente.", "OK");
             }
            */

            if (jogo.CheckWinner(SelecaoPicker.SelectedIndex, sorteio))
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }

            PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
            StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia.";



        }

       

    }

}

