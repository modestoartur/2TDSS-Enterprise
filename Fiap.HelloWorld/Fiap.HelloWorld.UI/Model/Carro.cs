﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Carro : Veiculo
    {
        public Carro(string modelo) : base(modelo)
        {
        }

        public string Placa { get; set; }

        public override void Frear()
        {
            Console.WriteLine("ABS ativado");
        }

    }
}
