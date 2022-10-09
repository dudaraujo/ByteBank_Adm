using ByteBank_Adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class GerenteContas : FuncionarioAutenticavel
    {

        //public string Senha { get; set; }

        public GerenteContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando Gerente de contas");
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.05;
        }

        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha; 
        //}

    }
}
