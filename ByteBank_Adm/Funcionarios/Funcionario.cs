using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Funcionario
    {
        
        public string Nome { get; set; }
        public string Cpf { get; private set; }

        //Com o protected, só é possível setar informações nesse campo pela própria classe ou por classes filhas
        public double Salario { get; protected set; }

        //Definindo o set como private pois é um incremento que não deve ser setado na mão
        public static int totalFuncionario { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            totalFuncionario++;
            Console.WriteLine("Criando Funcionário");
        }


        //O virtual informa que a classe filha pode ser redefinida
        public virtual double getBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual double PremioSemestral()
        {
            return Salario * 0.20; 
        } 

        public virtual void AumentaSalario()
        {
            this.Salario *= 1.1;
        }

        
    }
}
