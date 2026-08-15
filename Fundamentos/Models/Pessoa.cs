using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar()
        {
            
           //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); 

           Console.WriteLine($"Olá, meu nome é {Nome}," + 
           $"e tenho {Idade} anos"); //Pode concatenar para pular a linha e organizar o código

           Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos"); //Quebra de linha na execução
        }
    }
}