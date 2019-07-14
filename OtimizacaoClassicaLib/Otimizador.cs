using System;
using org.mariuszgromada.math.mxparser;


namespace OtimizacaoClassicaLib
{
    public class Otimizador
    {
        public static double declaraFuncao( double x)
        {          
            string num_str = doubleToStr(x);

            //Escrevendo argumento
            string x1_str = $"x1 = {num_str}";
            Argument x1 = new Argument(x1_str);

            // Até o momento usaremos sempre a mesma função 
            Function f = new Function("f(x) = 0.65 - (0.75 / (1 + x^2)) - 0.65 * x * atan(1/x)");
            org.mariuszgromada.math.mxparser.Expression e = new org.mariuszgromada.math.mxparser.Expression("f(x1)", f, x1);
            double res = e.calculate();

            return res;
        }

        // convertendo double em string, mantendo a pontuação correta
        private static string doubleToStr( double d)
        {
            return d.ToString().Replace(',','.');
        }
    }
}
