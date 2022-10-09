using ByteBank_Adm.Funcionarios;
using ByteBank_Adm.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            } 
            else
            {
                Console.WriteLine("Senha ou usuário incorretos");
                return false;
            }
          
        }

        //public bool Logar(ParceiroComercial funcionario, string login, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(login, senha);

        //    if (usuarioAutenticado == true)
        //    {
        //        Console.WriteLine("Bem vindo ao sistema!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta");
        //        return false;
        //    }

        //}
    }
}
