﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Funcionario
    {
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        //private int _cargo;

       

        public double getBonificacao()
        {
            return Salario;
        }

        
    }
}
