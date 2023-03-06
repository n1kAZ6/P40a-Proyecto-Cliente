using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40a_Proyecto_Cliente
{
    class Utils
    {
        static public string CuadraTexto(string texto, int numCaracteres, char caracter) 
        {
            if(texto.Length>numCaracteres)
                return texto.Substring(0, numCaracteres);

            while (texto.Length<numCaracteres)
                texto += caracter;

            return texto;
            
        }

    }
}
