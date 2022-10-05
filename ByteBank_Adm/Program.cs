

using ByteBank_Adm.Funcionarios;

Funcionario duda = new Funcionario();
duda.Nome = "Maria Eduarda";
duda.Cpf = "42135624845";
duda.Salario = 10000;

Console.WriteLine("Bonificação duda: " + duda.getBonificacao());

Diretor maria = new Diretor();
maria.Nome = "Eduarda";
maria.Cpf = "12345678909";
maria.Salario = 20000;

Console.WriteLine("Bonificação Maria" + maria.getBonificacao()
    );