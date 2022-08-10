using Ex_Aula;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Eduardo Guedes";
conta1.conta = "10123ix";
conta1.num_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 1341.50;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda";
conta2.conta = "92973ts";
conta2.num_agencia = 28;
conta2.nome_agencia = "Banco do Brasil";
conta2.saldo = 100.50;


Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("conta: " + conta2.conta);
Console.WriteLine("numero de agencia: " + conta2.num_agencia);
Console.WriteLine("nome da agencia " + conta2.nome_agencia);
Console.WriteLine("Saldo " + conta2.saldo);

Console.WriteLine("Saldo da Amanda pré-saque: "+conta2.saldo);
conta2.Sacar(50);
Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);
conta2.Depositar(50);
Console.WriteLine("Saldo da Amanda pós-Deposito: " + conta2.saldo);
Console.ReadKey();


