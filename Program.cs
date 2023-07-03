using System;

namespace Card2
{
    public class Card
    {
        public string Code { get; set; }
        public string CVV { get; set; }
        public string ExpiryDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public decimal Balance { get; set; }

        public Card(string code, string cvv, string expirydate, string name, string surname, string company, decimal balance)
        {
            Code = code;
            CVV = cvv;
            ExpiryDate = expirydate;
            Name = name;
            Surname = surname;
            Company = company;
            Balance = balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Card myCard = new Card("12121212","212","54514","ruslan","aliyev","kapital",54);

            Console.WriteLine(myCard.Balance);

        }
    }
}
