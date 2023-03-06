using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40a_Proyecto_Cliente
{
    class Cliente
    {
        //Atributos
        private int numDni;
        private char letraDni;
        private string nombre, apellidos;
        private byte año, mes, dia;
        
        //Constructor
        public Cliente(int numDni,char letraDni, string nombre,string apellidos, byte año, byte mes, byte dia) 
        {
            this.numDni = numDni;
            this.letraDni = letraDni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.año = año;
            this.mes = mes;
            this.dia = dia;
        }

        //Propiedades
        public int NumDni { get => numDni; set => numDni = value; }
        public char LetraDni { get => letraDni; set => letraDni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public byte Año { get => año; set => año = value; }
        public byte Mes { get => mes; set => mes = value; }
        public byte Dia { get => dia; set => dia = value; }

        //Propiedad edad --> Devuelve la edad dependiendo de si la persona ya cumplio años o no
        public int Edad
        {
            get
            {
                int edad = 0;

                int anyoHoy = DateTime.Now.Year;
                int mesHoy = DateTime.Now.Month;
                int diaHoy = DateTime.Now.Day;

                if (mesHoy < mes || (mesHoy == mes && diaHoy < dia))
                    edad = anyoHoy - Anyo4Cifras - 1;
                else
                    edad = anyoHoy - Anyo4Cifras;

                return edad;

            }
        }
        //Propiedad Anyo4Cifras que devuelve el año con 4 cifras
        public int Anyo4Cifras 
        {
            get
            {
                int anyoHoy2cifras=DateTime.Now.Year%100;
                if (año > anyoHoy2cifras)
                    return 1900 + año;
                else
                    return 2000 + año;
                
            }
        }
        
        //Método mostrar que muestra por consola dni con su letra, nombre y apellidos de la persona con su fecha nacimiento
        public void Mostrar() 
        {
            Console.Write("\t{0}-{1} {2} {3}/{4}/{5}",numDni,letraDni,Utils.CuadraTexto(nombre+" "+apellidos,27,' '),dia.ToString("00"),mes.ToString("00"),Anyo4Cifras);
        }
    }
}
