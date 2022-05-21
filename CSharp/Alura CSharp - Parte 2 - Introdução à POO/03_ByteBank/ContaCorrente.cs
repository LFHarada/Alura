public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numerodaconta;
    public double saldo;
    public double cpf;

    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

}