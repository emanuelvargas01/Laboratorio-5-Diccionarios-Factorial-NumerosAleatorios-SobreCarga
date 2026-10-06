using System;
using System.Collections.Generic;
using System.Text;

namespace SobreCarga_de_Metodos
{
    public class SobreCarga
    {
        //prueba los métodos Cuadrados sobrecargados
        public void ProbarMetodosSobreCargados()
        {
            Console.WriteLine("El cuadrado del integer 7 es {0}", Cuadrado(7));
            Console.WriteLine("El cuadrado del doublé 7.5 es {0}", Cuadrado(7.5));
        }
        public int Cuadrado(int valorInt)
        {
            Console.WriteLine("Se llamo un cuadrdo con argumento int: {0}, valorInt");
            return valorInt * valorInt;
        }
        public double Cuadrado(double valorDouble)
        {
            Console.WriteLine("Se llamo a cuadrado con argumento doublé: {0}", valorDouble);
            return valorDouble * valorDouble;
        }
    }


}
