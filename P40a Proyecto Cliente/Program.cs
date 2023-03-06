using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40a_Proyecto_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista para guardar objetos de tipo Cliente
            List<Cliente> listaClientes = new List<Cliente>();

            //StreamReader para leer del fichero
            StreamReader sR = new StreamReader("Clientes.txt",Encoding.Default);

            string registro;
            string[] vCampos;
            //Mientras no sea el final del stream del fichero de lectura iteramos para leer cada registro
            while (!sR.EndOfStream) 
            {
                registro = sR.ReadLine(); //Lo que lee el stream se guarda en la variable registro.
                vCampos = registro.Split('/'); //Guardamos en vCampos los campos de cada registro con el delimitador barra
                //Guardamos en la lista una instancia de cada Cliente leído del fichero
                listaClientes.Add(new Cliente(int.Parse(vCampos[0]), char.Parse(vCampos[1]), vCampos[3].Trim(), vCampos[2], byte.Parse(vCampos[4]), byte.Parse(vCampos[5]), byte.Parse(vCampos[6])));
            }

            //Mostramos con el método mostrar más la edad
            foreach (Cliente c in listaClientes)
            {
                c.Mostrar();
                Console.WriteLine("  "+c.Edad);
            }

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
