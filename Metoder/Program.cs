using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Lasse på Heden!");
            Customer customer = new Customer();
            Food food = new Food();
            Tobacco tobacco = new Tobacco();
            Beer beer = new Beer();
            Console.WriteLine("Start by looking trough our meny " +
                "\n Food-----------------------" +
                "\n item1 = Half special" +
                "\n item2 = Hotdog" +
                "\n item3 = Hamburger" +
                "\n Tobacco--------------------" +
                "\n item4 = Ettan portion" +
                "\n item5 = General original" +
                "\n item6 = Camel breeze" +
                "\n item7 = Marlboro gold" +
                "\n Beer-----------------------" +
                "\n item8 = Carlsberg hof" +
                "\n item9 = Tuborg gold" +
                "\n item10 = Breznak" +
                "\n item11 = Franzikaner" +
                "\n item12 = Weihenstephaner" +
                "\n item13 = Guinness" +
                "\n ---------------------------" +
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
                        customer.shoppingCart.Add(food.item1);
                        break;
                    case "item2":
                        Console.WriteLine("Item Hotdog was added to your order");
                        customer.shoppingCart.Add(food.item2);
                        break;
                    case "item3":
                        Console.WriteLine("Item Hamburger was added to your order");
                        customer.shoppingCart.Add(food.item3);
                        break;
                    case "item4":
                        Console.WriteLine("Item Ettan portion was added to your order");
                        customer.shoppingCart.Add(tobacco.item4);
                        break;
                    case "item5":
                        Console.WriteLine("Item General original was added to your order");
                        customer.shoppingCart.Add(tobacco.item5);
                        break;
                    case "item6":
                        Console.WriteLine("Item Camel breeze was added to your order");
                        customer.shoppingCart.Add(tobacco.item6);
                        break;
                    case "item7":
                        Console.WriteLine("Item Marlboro gold was added to your order");
                        customer.shoppingCart.Add(tobacco.item7);
                        break;
                    case "item8":
                        Console.WriteLine("Item Carlsberg hof was added to your order");
                        customer.shoppingCart.Add(beer.item8);
                        break;
                    case "item9":
                        Console.WriteLine("Item Tuborg gold was added to your order");
                        customer.shoppingCart.Add(beer.item9);
                        break;
                    case "item10":
                        Console.WriteLine("Item Breznak was added to your order");
                        customer.shoppingCart.Add(beer.item10);
                        break;
                    case "item11":
                        Console.WriteLine("Item Franzikaner was added to your order");
                        customer.shoppingCart.Add(beer.item11);
                        break;
                    case "item12":
                        Console.WriteLine("Item Weihenstephaner was added to your order");
                        customer.shoppingCart.Add(beer.item12);
                        break;
                    case "item13":
                        Console.WriteLine("Item Guinness was added to your order");
                        customer.shoppingCart.Add(beer.item13);
                        break;

                    case "exit":
                        loopconditionNumber = 1;
                        break;
                    case  "done ordering":
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
