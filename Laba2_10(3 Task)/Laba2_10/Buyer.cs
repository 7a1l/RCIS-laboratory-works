namespace Laba2_10;

public class Buyer
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int CreditCardNumber { get; set; }
    public int BankAccountNumber { get; set; }

    public Buyer(String surname, String name, String lastName, string address, int creditCardNumber, int bankAccountNumber)
    {
        Surname = surname;
        Name = name;
        LastName = lastName;
        CreditCardNumber = creditCardNumber;
        BankAccountNumber = bankAccountNumber;
        Address = address;
    }
}