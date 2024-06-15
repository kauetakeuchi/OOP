namespace AMST4_Heranca.Models
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
            Name = "Kaue";
            CPF = 43534534;
            Agency = "Santander";
            Withdraw = 100;
            Deposit = 222;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CPF { get; set; }
        public string Agency { get; set; }
        public double Withdraw { get; set; }
        public double Deposit { get; set; }
        public double Balance { get; set; } 

        public virtual void CalcBalance()
        {
            Balance = Deposit - Withdraw;
        }
    }

}