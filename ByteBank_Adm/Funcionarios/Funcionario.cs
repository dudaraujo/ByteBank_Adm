using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    //Quando uma classe é abstrata, não é possível criar objetos dela
    //Ela apenas serve como base para a criação de outras classes 
    public abstract class Funcionario
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
        //public virtual double getBonificacao()
        //{
        //    return Salario * 0.10;
        //}

        ///O abstract informa que esse método é abstrato, todo objeto/classe filha dessa classe precisa ter ele 
        ///mas o bloco de código dentro dele só é definido na classe filha
        public abstract double getBonificacao();
       

        public virtual double PremioSemestral()
        {
            return Salario * 0.20; 
        }

        public abstract void AumentaSalario();

        
        
    }
}
