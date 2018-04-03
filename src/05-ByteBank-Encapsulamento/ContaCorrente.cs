namespace _05_ByteBank_Encapsulamento
{
    public class ContaCorrente
    {
        public int numero;
        public int agencia;
        public double saldo;
        public Cliente titular;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transfere(double valor, ContaCorrente outraConta)
        {
            // Começamos assim, mas podemos fazer invocando o Saca
            // e ganhamos um DRY ?

            //if (this.saldo >= valor)
            //{
            //    this.saldo -= valor;
            //    outraConta.Deposita(valor);
            //    return true;
            //}

            bool saqueRealizado = Saca(valor);
            if (saqueRealizado)
            {
                outraConta.Deposita(valor);
                return true;
            }

            return false;
        }

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetAgencia()
        {
            return agencia;
        }
        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public Cliente GetTitular()
        {
            return titular;
        }
        public void SetTitular(Cliente titular)
        {
            this.titular = titular;
        }

    }
}