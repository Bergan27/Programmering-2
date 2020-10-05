using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Lasse på Heden!");
            Customer customer = new Customer();
            Products products = new Products();
            Console.WriteLine("Start by looking trough our meny " +
                "\n item1 = Half special" +
                "\n item2 = Hotdog" +
                "\n item3 = Big Strong" +
                "\n exit - Done ordering");
            string answer;
            int loopconditionNumber = 0;
            
            while (loopconditionNumber != 1)
            {
                Console.WriteLine("Enter your order or write done ordering");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "item1":
                        Console.WriteLine("Item Half Special was added to your order");
                        customer.shoppingCart.Add(products.item1);
                        break;
                    case "item2":
                        Console.WriteLine("Item Hotdog was added to your order");
                        customer.shoppingCart.Add(products.item2);
                        break;
                    case "item3":
                        Console.WriteLine("Item Big Strong was added to your order");
                        customer.shoppingCart.Add(products.item3);
                        break;
                    case "exit":
                        loopconditionNumber = 1;
                        break;
                    default:
                        Console.WriteLine("Enter an item instead!");
                        break;
                }

                string listItems = "";
                foreach (var orderItem in customer.shoppingCart)
                {
                    listItems += orderItem + ", ";

                }
                Console.WriteLine(listItems);


            }
        }
    }
}
