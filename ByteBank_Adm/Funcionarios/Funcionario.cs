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
        public string Cpf { get; set; }
        public double Salario { get; set; }

        //Definindo o set como private pois é um incremento que não deve ser setado na mão
        public static int totalFuncionario { get; private set; }

        public Funcionario()
        {
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

        
    }
}
