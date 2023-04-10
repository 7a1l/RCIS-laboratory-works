using System;
using Laba2_10;

class RCIS
{
    static void Main()
    {
        List<Buyer> Buyers = new List<Buyer>()
        {
            new Buyer("Fedorov","Pavel","Olegovich","Tomsk",123,1),
            new Buyer("Q","QQ","QQQ","TomQQ",9,2),
            new Buyer("W","WW","WWW","TomWW",900,3),
        };
        while (true)
        {
            Console.WriteLine("1 - список по алфавиту\n2 - Сортировка по диапазону кредитной карты\nOther number - finish");
            int op = int.Parse(Console.ReadLine()!);
            switch (op)
            {
                case 1:
                    var list = Buyers.OrderBy(buyer => buyer.Surname);
                    foreach (var customer in list)
                    {
                        Console.WriteLine($"{customer.Surname} {customer.Name} {customer.LastName} {customer.Address} {customer.CreditCardNumber} {customer.BankAccountNumber}");
                    }
                    break;
                case 2:
                    Console.Write("Введите начало диапазона: ");
                    int beg = int.Parse(Console.ReadLine());
                    Console.Write("Введите конец диапазона: ");
                    int end = int.Parse(Console.ReadLine());
                    var array = Buyers.Where(buyer => buyer.CreditCardNumber > beg && buyer.CreditCardNumber < end);
                    foreach (var customer in array)
                    {
                        Console.WriteLine($"{customer.Surname} {customer.Name} {customer.LastName} {customer.Address} {customer.CreditCardNumber} {customer.BankAccountNumber}");
                    }
                    break;
                default:
                    return;
            }
        }
    }
}