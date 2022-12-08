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
        bool acompanhado = true;
        if (idade >= 18 && acompanhado)
        {
            Console.WriteLine("você é maior de idade");
            Console.WriteLine("seja bem-vindo");
        }
        else
        {
            Console.WriteLine("Você é menor de idade");
        }
    }
}
