using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto ");


        int idadeJoão = 16;
        int quantidadePessoas = 2;

        if (idadeJoão >= 18)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("esta acompanhado pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode Entar");
            }

        }


        //variavel booleana

        int idadeJoão2 = 16;
        int quantidadePessoas2 = 2;

        bool grupo = true;


        if (idadeJoão2 >= 18 || quantidadePessoas2 > 1)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine("Não pode Entrar");
        }

        Console.WriteLine("Tecle enter para fechar");


    }



}

