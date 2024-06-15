namespace AMST4_Heranca.Models
{
    public class AccountPerson : Person
    {
        public AccountPerson()
        {

        }

        public override void CalcBalance()
        {
            Balance = (Deposit - Withdraw) * 0.9;
            Console.WriteLine($"O saldo da conta é: {Balance}");
        }

    }   

}
