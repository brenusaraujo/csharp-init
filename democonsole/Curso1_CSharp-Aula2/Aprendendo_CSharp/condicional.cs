using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class condicional
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");
        int idade = 20;
        int quantidadeDePessoas = 3;
        if (idade >= 18)
        {
            Console.WriteLine("você é maior de idade");
            Console.WriteLine("seja bem-vindo");
        }
        else
        {
            if (quantidadeDePessoas >= 2)
            {
                Console
                    .WriteLine("você não tem 18 anos mas pode entrar pois está acompanhado");
            }
            Console.WriteLine("Você é menor de idade");
        }
    }
}
