using ByteBank_Adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    //Diretor é herença de Autenticável
    public class Diretor: FuncionarioAutenticavel
    {

        //Esta usando os mesmo campos de Funcionario

        //public string Senha { get; set; }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando diretor");
        }

        // O override avisa que essa classe é uma reescrita da classe pai
        public override double getBonificacao()
        {
            return Salario * 0.50;

            //Calculando 110%, ou seja, os 100% mais os 10% que já é calculado
            //para funcionário.
            //Reaproveitando o código
            //return Salario + base.getBonificacao();
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }

        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}
    }
}
