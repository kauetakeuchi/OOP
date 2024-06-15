namespace AMST4_Heranca.Models
{
    public class BusinessPerson : Person
    {
        public BusinessPerson()
        {

        }

        public override void CalcBalance()
        {
            Balance = (Deposit - Withdraw) * 1.02;
            Console.WriteLine($"O saldo da conta é: {Balance}");
        } 

    }

}