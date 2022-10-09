using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override double getBonificacao()
        {
            return Salario * 0.20;
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.10; 
        }
    }
}
