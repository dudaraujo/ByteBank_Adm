using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando desenvolvedor");
        }

        public override double getBonificacao()
        {
            return Salario * 0.10;
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
