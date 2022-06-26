

IColetaService coletaService = new ColetaService();

coletaService.ColetarLixo("Rua Girassol, 10");
coletaService.AgendarColeta("Rua Girassol,10", new DateTime(2022, 06, 30));

ICartao cartaoDebito = new CartaoDebito();
cartaoDebito.Creditar(100);
cartaoDebito.Debitar(50);
Console.WriteLine($"Saldo Conta corrente {cartaoDebito.ConsultarSaldo()}");


ICartao cartaoCredito = new CartaoCredito();
cartaoCredito.Creditar(100);
cartaoCredito.Debitar(50);
Console.WriteLine($"Saldo fatura do cartão {cartaoCredito.ConsultarSaldo()}");



public interface IColetaService
{
    void ColetarLixo(string endereco);

    bool AgendarColeta(string endereco, DateTime data);
}



public class ColetaService : IColetaService
{
    public bool AgendarColeta(string endereco, DateTime data)
    {
        Console.WriteLine($"Coleta agendada para {data} no endereço {endereco}");
        return true;   
    }

    public void ColetarLixo(string endereco)
    {
        Console.WriteLine($"Caminhão indo realizar a coleta no endereço {endereco}");
    }
}



public interface ICartao
{
    public void Creditar(double valor);
    public void Debitar(double valor);
    public double ConsultarSaldo();
}

public class CartaoDebito : Cartao, ICartao
{
    
    public double ConsultarSaldo()
    {
        return Saldo;
    }

    public void Creditar(double valor)
    {
        Saldo += valor;
    }

    public void Debitar(double valor)
    {
        Saldo -= valor;
    }
}
 
public class CartaoCredito : Cartao, ICartao
{
    
    public double ConsultarSaldo()
    {
        return Saldo;
    }

    public void Creditar(double valor)
    {
        Saldo -= valor;
    }

    public void Debitar(double valor)
    {
        Saldo += valor;
    }
}

public abstract class Cartao
{
    protected double Saldo = 0;
}