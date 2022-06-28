

namespace Aula.Interface.Services
{
    public class CartaoCredito
    {
        private double _saldo;
        public double ConsultarSaldo()
        {
            return _saldo;
        }

        public void Creditar(double valor)
        {
            _saldo -= valor;
        }

        public void Debitar(double valor)
        {
            _saldo += valor;
        }
    }
}
