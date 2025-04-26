using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace CoinFlip
{
    //Classe internal especifica que a classe gerada é acessível somente dentro de tipos no mesmo assembly.
    public class Coin
    {
        //ModificadorDeAcesso (TIPO) (NOME)
        private string ladoSorteado; //um atributo que pode ser nulo, colocamos ? do lado dele 

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; } //L para usar o metodo get e set

        //metodo costuma ser publico
        public Coin()
        {
            //metodo construtor, metodo com o mesmo nome da classe se torna o construtor 
        }

        public string Flip()
        {
            Random random = new Random();

            /* if (random.Next(2) == 0)
             {
                 LadoSorteado = "Cara";
             }
             else
             {
                 LadoSorteado = "Coroa";
             }
            */

            //operador ternario so serve quando vou fazer uma atribuição no IF
            LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);
        }
       
    }
}
