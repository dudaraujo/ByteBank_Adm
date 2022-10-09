using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Designer : Funcionario
    {
        //Comentado pois agora o salário é um número base fixo (3000)
        //public Designer(string cpf, double salario) : base(cpf, 3000)
        public Designer(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando design");
        }

        public override double getBonificacao()
        {
            return Salario * 0.17;
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
