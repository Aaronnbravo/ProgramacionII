using System;
using Views;
using Controllers;
using Models;
namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
               
        }

        static void MenuPrincipal()
        {
            OrderController oController = new OrderController();
            bool salir = false;
            int opcion = 0;
            Console.WriteLine("welcome to the ordering system");
            Console.WriteLine("Enter the option you want to make");
            Console.WriteLine("1_Show Products");
            Console.WriteLine("2_Load Products");
            Console.WriteLine("3_Show Clients");
            Console.WriteLine("4_Load Clients");
            Console.WriteLine("5_Show Order");
            Console.WriteLine("6_Load Order");
            Console.WriteLine("7_Exit");
            opcion = int.Parse(Console.ReadLine());
            do
            {

                switch (opcion)
                {
                    case 1:
                        oController.CreateOrder();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;

                }
            } while (salir);

        }
    }
}
