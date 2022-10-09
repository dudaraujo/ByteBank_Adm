

using ByteBank_Adm.Funcionarios;
using ByteBank_Adm.Utilitarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
Funcionario duda = new Funcionario("42135624845", 2000);
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
duda.Nome = "Maria Eduarda";



Console.WriteLine("Bonificação duda: " + duda.getBonificacao());

Diretor maria = new Diretor("12345678909", 5000);
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);
maria.Nome = "Eduarda";



Funcionario Gabriel = new Diretor("85296378945", 2000);
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);

Console.WriteLine("Bonificação Maria: " + maria.getBonificacao());


gerenciador.Registrar(duda);
gerenciador.Registrar(maria);


Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

Funcionario teste1 = new Funcionario("25841236585", 100);
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);


Funcionario teste2 = new Diretor("78945612396", 100);
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionario);



Console.WriteLine("Premio semestral funcionário teste1: " + teste1.PremioSemestral());
Console.WriteLine("Premio semestral diretor teste2: " + teste2.PremioSemestral());

Console.WriteLine("Salario funcionária duda: " + duda.Salario);
duda.AumentaSalario();
Console.WriteLine("Salario duda após o aumento: " + duda.Salario);

Console.WriteLine("Salario diretora maria: " + maria.Salario);
maria.AumentaSalario();
Console.WriteLine("Salaria maria após o aumento: " + maria.Salario);


