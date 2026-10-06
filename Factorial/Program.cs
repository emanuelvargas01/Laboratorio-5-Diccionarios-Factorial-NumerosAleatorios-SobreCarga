namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculo del Factorial del 0 al 10
            for (long contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("{0}! = {1}", contador, Factorial(contador));


            }//fin del for
        }//fin del meotod main
        public static long Factorial(long numero)
        {
            //caso base
            if (numero <= 1)
                return 1;
            //paso de recursividad
            else return numero * Factorial(numero - 1);
        }
    }
}
