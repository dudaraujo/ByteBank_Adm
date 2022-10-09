

using ByteBank_Adm.Funcionarios;
using ByteBank_Adm.ParceriaComercial;
using ByteBank_Adm.SistemaInterno;
using ByteBank_Adm.Utilitarios;

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


//Funcionario duda = new Funcionario("42135624845", 2000);
//duda.Nome = "Maria Eduarda";

//Console.WriteLine("Bonificação duda: " + duda.getBonificacao());


//Diretor maria = new Diretor("12345678909", 5000);
//maria.Nome = "Eduarda";


//Funcionario Gabriel = new Diretor("85296378945", 5000);


//Console.WriteLine("Bonificação Maria: " + maria.getBonificacao());


//gerenciador.Registrar(duda);
//gerenciador.Registrar(maria);


//Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

//Funcionario teste1 = new Funcionario("25841236585", 100);



//Funcionario teste2 = new Diretor("78945612396", 5000);



//Console.WriteLine("Premio semestral funcionário teste1: " + teste1.PremioSemestral());
//Console.WriteLine("Premio semestral diretor teste2: " + teste2.PremioSemestral());

//Console.WriteLine("Salario funcionária duda: " + duda.Salario);
//duda.AumentaSalario();
//Console.WriteLine("Salario duda após o aumento: " + duda.Salario);

//Console.WriteLine("Salario diretora maria: " + maria.Salario);
//maria.AumentaSalario();
//Console.WriteLine("Salaria maria após o aumento: " + maria.Salario);

CalcularBonificacao();

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer zago = new Designer("45678912356");
    zago.Nome = "João Zago";

    Diretor dudica = new Diretor("12345678996");
    dudica.Nome = "Duda Araújo";

    Auxiliar tino = new Auxiliar("12545698756");
    tino.Nome = "Gabriel Tinoco";

    GerenteContas isa = new GerenteContas("25689542365");
    isa.Nome = "Isabela Beretta";

    Desenvolvedor almeida = new Desenvolvedor("45678912345");
    almeida.Nome = "Gabriel de Almeida";

    gerenciador.Registrar(zago);
    gerenciador.Registrar(dudica);
    gerenciador.Registrar(tino);
    gerenciador.Registrar(isa);
    gerenciador.Registrar(almeida);


    Console.WriteLine("Total de bonificações: " + gerenciador.getBonificacao());

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor diretor1 = new Diretor("56565656");
    diretor1.Nome = "Diretor um";
    diretor1.Login = "Diretor1";
    diretor1.Senha = "12345";

    GerenteContas gerente1 = new GerenteContas("54543665");
    gerente1.Nome = "Gernte um";
    gerente1.Login = "Gerente1";
    gerente1.Senha = "54321";

    ParceiroComercial parceiro1 = new ParceiroComercial();
    parceiro1.Login = "parceiro1";
    parceiro1.Senha = "54321";

    //Dev nao pode autenticar pois herda de Funcionário então não tem a propriedade senha
    //Desenvolvedor dev1 = new Desenvolvedor("54543665");
    //dev1.Nome = "Dev um";
    //dev1.Senha = "963";

    sistema.Logar(diretor1, "Diretor", "12345");
    sistema.Logar(gerente1, "Gerente1", "54321");
    sistema.Logar(parceiro1, "parceiro1", "54321");
    //sistema.Logar(dev1, "963");

}


Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);




