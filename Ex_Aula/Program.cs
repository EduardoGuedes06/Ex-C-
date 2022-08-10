using Ex_Aula;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Eduardo Guedes";
conta1.conta = "10123ix";
conta1.num_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda";
conta2.conta = "92973ts";
conta2.num_agencia = 28;
conta2.nome_agencia = "Banco do Brasil";
conta2.saldo = 100.50;

Console.WriteLine("Saldo do Eduardo pré-t: " + conta1.saldo);
Console.WriteLine("Saldo da Amanda pré-t: " + conta2.saldo);
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("Tranferencia realizada : " + transferencia);
Console.WriteLine("Saldo do Eduardo pós-t: " + conta1.saldo);
Console.WriteLine("Saldo da Amanda pós-t: " + conta2.saldo);

Console.ReadKey();


