﻿namespace Assign4_Day2
{
    class Program()
    {
        static void Main()
        {
            string role;
            int size;
            do
            {
                Console.WriteLine("...............Menu..................");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("Enter your Role");
                role = Console.ReadLine();
                Console.WriteLine("How many Products you want to add");
                size = int.Parse(Console.ReadLine());
                if (role.ToUpper() == "ADMIN")
                {
                    Product p = new Product();
                    for (int i = 0; i < size; i++)
                    {
                        p.GetProductDetails();
                    }

                    p.DisplayProductDetails();
                }
                //else if (role.ToUpper() == "CUSTOMER")
                //{


                //}
            } while ()
          

        }
    }
}