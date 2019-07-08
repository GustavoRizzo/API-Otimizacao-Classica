using System;


namespace OtimizacaoClassicaLib
{
    public class Otimizador
    {
        public static double declaraFuncao( double x)
        {
            // Até o momento usaremos sempre a mesma função 
            Console.WriteLine( "função criada: " + "0.65 -(0.75/(1+ Math.Pow(x,2))) - 0.65 * x * Math.Atan(1/x)"  );
            double res = 0.65 -(0.75/(1+ Math.Pow(x,2))) - 0.65 * x * Math.Atan(1/x);
            return res;
        }
    }
}
