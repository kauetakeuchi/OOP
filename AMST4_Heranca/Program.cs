using AMST4_Heranca.Models;

AccountPerson AccountPerson =  new AccountPerson();
BusinessPerson BusinessPerson = new BusinessPerson();

Console.WriteLine("Deseja acessar qual conta? (Pessoa ou Juridica)");
string conta = Console.ReadLine();
if (conta == "Pessoa")
{
  Console.WriteLine($"O Id da conta é: {AccountPerson.Id}");
  Console.WriteLine($"O Nome da conta é: {AccountPerson.Name}");
  Console.WriteLine($"O CPF da conta é: {AccountPerson.CPF}");
  Console.WriteLine($"A Agência da conta é: {AccountPerson.Agency}");
  AccountPerson.CalcBalance();
} 

else if (conta == "Juridica")
{
  Console.WriteLine($"O Id da conta é: {BusinessPerson.Id}");
  Console.WriteLine($"O Nome da conta é: {BusinessPerson.Name}");
  Console.WriteLine($"O CPF da conta é: {BusinessPerson.CPF}");
  Console.WriteLine($"A Agência da conta é: {BusinessPerson.Agency}");
  BusinessPerson.CalcBalance(); 
}