using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Game
    {
        //ModificadorDeAcesso Tipo Nome
        private int playerPoint = 0;
        private int streak = 0;

        public int PlayerPoint { get => playerPoint; set => playerPoint = value; }
        public int Streak { get => streak; set => streak = value; }

        public Game()
        {
        }

        public Boolean CheckWinner(int ladoSorteado, int ladoEscolhido)
        {
            if (ladoSorteado == ladoEscolhido)
            {
                PlayerPoint++;
                Streak++;
                return true;
            }
            else
            {
                Streak = 0;
                return false;
            }

        }
    }
}
