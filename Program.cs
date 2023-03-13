using System;

namespace midterm {
    class Program {
        static void Main(string[] args) {
           int day = int.Parse(Console.ReadLine());
           int time = int.Parse(Console.ReadLine());

           string meal = Console.ReadLine();

           switch (meal) {
            case "Breakfast Set" :
            if (time <= 11) {
                for (int i =1; i<=5; i++) {
                string meal1 = Console.ReadLine();
                }
                Console.WriteLine("Sorry your order is out of stock");
            } else {
                Console.WriteLine("Sorry your order is not available");
            }
            break;

            case "Weekend Set" :
            if (day < 6) {
                for (int i=1; i<=2; i++) {
                    string meal1 = Console.ReadLine();
                }
                Console.WriteLine("Sorry your order is out of stock");
            } else {
                Console.WriteLine("Sorry your order is not available");
            }
            break;

            case "Coffee" :
            for (int i =1; i<=3; i++) {
                string meal1 = Console.ReadLine();
            }
            Console.WriteLine("Sorry your order is out of stock");
            break;

            case "End" :
            break;

            default :
            Console.WriteLine("Please enter a valid menu");
            break;
           }
        }
    }
}