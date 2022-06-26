using Aula.Interface.Services;


CartaoDebito cartaoDebito = new CartaoDebito();
cartaoDebito.Creditar(100);
cartaoDebito.Debitar(50);
Console.WriteLine($"Saldo Conta corrente {cartaoDebito.ConsultarSaldo()}");


CartaoCredito cartaoCredito = new CartaoCredito();
cartaoCredito.Creditar(100);
cartaoCredito.Debitar(50);
Console.WriteLine($"Saldo fatura do cartão {cartaoCredito.ConsultarSaldo()}");
