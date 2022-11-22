using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executabdo Projeto While");

        double investimento = 1000;

        //rendimento de 0,5% (0.005) ao mês

        // investimento = investimento + investimento * 0.005;

        // Console.WriteLine (investimento);

        //ambos trazem o mesmo resultado.

        //laço while
        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes += 1;
        }

        //laço for

        for (int mess = 1; mess <= 12; mess++)
        {
            investimento = investimento + investimento * 0.005;
           

        }

        // encadeando laços for.

        double fatorRendimento = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mess = 1; mess <= 12; mess++)
            {
                investimento += fatorRendimento + 0.001;
            }

            fatorRendimento += 0.001;

        }


        Console.WriteLine(investimento);

        Console.WriteLine("tecle enter para fechar");


    }

}