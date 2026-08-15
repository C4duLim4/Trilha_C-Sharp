using System;
using System.Collections.Generic;
using System.Text;

namespace PráticaDIO_C_.Moldes
{
    internal class animal
    {
        string especie { get; set;  } = string.Empty;
        int idade { get; set; } = 0;
        
        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é anos.");
        }
       
    }
}
