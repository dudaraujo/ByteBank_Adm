using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    //Diretor é herença de Funcionario
    public class Diretor: Funcionario
    {
     
        //Esta usando os mesmo campos de Funcionario

        // O override avisa que essa classe é uma reescrita da classe pai
        public override double getBonificacao()
        {
            //return Salario + (Salario * 0.10);

            //Calculando 110%, ou seja, os 100% mais os 10% que já é calculado
            //para funcionário.
            //Reaproveitando o código
            return Salario + base.getBonificacao();
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }

        public Diretor(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando diretor");
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
