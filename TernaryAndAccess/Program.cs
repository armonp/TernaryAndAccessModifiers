using System;

namespace TernaryAndAccessModifier {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"The cube of 17 is {Cubed(17)}.");
            Console.WriteLine($"Next Id is {Customer.PrintNextId()}."); //PrintNextId is static so it will only ever show 1. 

            var cust1 = new Customer("Max Technical Training");
            Console.WriteLine(cust1);
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");

            cust1.NationalAccount("yes");

            var order1 = new Order {Amount = 1000, Customer = cust1 };
            var order2 = new Order { Amount = 2000, Customer = cust2 };
        }

        //static int Cubed(int nbr) {
        //    return nbr * nbr * nbr;
        //}
    }
}
