using ByteBank_Adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.SistemaInterno
{

    public interface IAutenticavel
    {
        public bool Autenticar(string login, string senha);
    }


    ////transformando a classe em abstrata para não ser necessário herdar os métodos de salário e bonus de funcionário
    //public abstract class Autenticavel : Funcionario
    //{
    //    public Autenticavel(string cpf, double salario) : base(cpf, salario)
    //    {

    //    }

    //    public string Senha { get; set; }
    //    public string Login { get; set; }

    //    public bool Autenticar(string login, string senha)
    //    {
    //        return this.Senha == senha && this.Login == login; 
    //    }

     
    //}
}
