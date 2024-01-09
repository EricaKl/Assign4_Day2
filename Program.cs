namespace Assign4_Day2
{
    class Program()
    {
        enum role { Admin = 1 ,Customer = 2}
        static void Main()
        {
            int Role;
            int size;
            string ch;
            string productName;
       
        Product p = new Product();
            
            do
            {
                Console.WriteLine("...............Menu..................");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("Enter your Role");
                Role = int.Parse(Console.ReadLine());
               
                if (Role == (int)role.Admin)
                {
                    Console.WriteLine("How many Products you want to add");
                    size = int.Parse(Console.ReadLine());
                   
                    for (int i = 0; i < size; i++)
                    {
                        
                        p.GetProductDetails();
                    }

                    p.DisplayProductDetails();
                }
                else if (Role == (int)role.Customer)
                {
                    //Product p = new Product();
                    Console.WriteLine("Enter Product Name");
                    productName = Console.ReadLine();
                    p.DisplaySpecificProductDetails(productName);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you wish to run again y/n ");
                ch = Console.ReadLine();
            } while (ch == "y"||ch =="Y");
          

        }
    }
}