

using ByteBank_Adm.Funcionarios;
using ByteBank_Adm.Utilitarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
Funcionario duda = new Funcionario();
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
duda.Nome = "Maria Eduarda";
duda.Cpf = "42135624845";
duda.Salario = 2000;


Console.WriteLine("Bonificação duda: " + duda.getBonificacao());

Diretor maria = new Diretor();
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
maria.Nome = "Eduarda";
maria.Cpf = "12345678909";
maria.Salario = 5000;



Funcionario Gabriel = new Diretor();
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);

Console.WriteLine("Bonificação Maria: " + maria.getBonificacao());


gerenciador.Registrar(duda);
gerenciador.Registrar(maria);


Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

Funcionario teste1 = new Funcionario();
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
teste1.Salario = 100;


Funcionario teste2 = new Diretor();
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
teste2.Salario = 100;


Console.WriteLine("Premio semestral funcionário teste1: " + teste1.PremioSemestral());
Console.WriteLine("Premio semestral diretor teste2: " + teste2.PremioSemestral());

