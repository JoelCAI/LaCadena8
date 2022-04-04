using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena8
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadenaUno;
            string cadenaDos;

            Validador.Bienvenida();

            cadenaUno = Validador.ValidarString("\n Ingrese la primera frase");

            cadenaDos = Validador.ValidarString("\n Ingrese la segunda frase");

            Validador.MostrarString(cadenaUno);
            Console.Write(" Como primera frase\n");

            Validador.MostrarString(cadenaDos);
            Console.Write(" Como segunda frase\n");

            Validador.CompararIgualdadStringSinImportarMayusculaMinuscula(cadenaUno, cadenaDos);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
