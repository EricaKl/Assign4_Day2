using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_Day2
{
    public class Product
    {
        int pCode;
        string pName;
        int qty_In_Stock;
        float discount_Allowed;
        float amount;
        string brand;
        List<Product> prodadd = new List<Product>();
        //public Product()
        //{
        //    Console.WriteLine("Enter Product Id");
        //    pCode = int.Parse(Console.ReadLine());

        //}
        //public Product(int pCode, string pNmae , int qty_In_Stock , float discount_Allowed)
        //{

        //}

        //static Product()
        //{
        //    Console.WriteLine("Enter Brand");
        //    brand = Console.ReadLine();

        //}
        public void GetProductDetails()
        {
            Console.WriteLine("Enter Product Id");
            pCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            pName = Console.ReadLine();
            Console.WriteLine("Enter Brand");
            brand = Console.ReadLine();
            Console.WriteLine("Enter Qty in Stock");
            qty_In_Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Discount Allowed");
            discount_Allowed = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount");
            amount = float.Parse(Console.ReadLine());

           
            prodadd.Add(new Product 
            {
                pCode = pCode, 
                pName = pName,
                brand = brand,
                qty_In_Stock = qty_In_Stock,
                discount_Allowed = discount_Allowed,
                amount = amount
                
            });
           
          
        }
    

        public void DisplayProductDetails()
        {

            for (var i = 0; i < prodadd.Count; i++)
            {

                Console.WriteLine($"Product code : {prodadd[i].pCode}");
                Console.WriteLine($"Product name : {prodadd[i].pName}");
                Console.WriteLine($"Product Quantity : {prodadd[i].qty_In_Stock}");
                Console.WriteLine($"Product Discount : {prodadd[i].discount_Allowed}");
                Console.WriteLine($"Product Brand : {prodadd[i].brand}");
                Console.WriteLine($"Product Cost : {prodadd[i].amount}");
                Console.WriteLine();
            }
        }

        public void DisplaySpecificProductDetails(string productname)
        {
            var list = prodadd.Where(x => x.pName == productname).ToList();
            float discount = 0.0f;
            float amount = 0.0f;

            for (var i = 0; i < list.Count; i++)
            {

                Console.WriteLine($"Product code : {list[i].pCode}");
                Console.WriteLine($"Product name : {list[i].pName}");
                Console.WriteLine($"Product Quantity : {list[i].qty_In_Stock}");
                Console.WriteLine($"Product Discount : {list[i].discount_Allowed}");
                Console.WriteLine($"Product Brand : {list[i].brand}");
                Console.WriteLine($"Product Cost : {list[i].amount}");
                Console.WriteLine();
                discount = list[i].discount_Allowed;
                amount = list[i].amount;
            }
            GenerateBill(productname, discount, amount);
        }

        public void GenerateBill(string productname, float discount , float amount)
        {

            float totalAmount = 0.0f;
            Console.WriteLine();
            Console.WriteLine("....Bill Generated....");
            Console.WriteLine(".............................................................");
            Console.WriteLine("Product name:" + productname);
           
            if(DateTime.Now.Equals("26-01-2024"))
            {
                discount = 50f;
                Console.WriteLine("Discount allowed on this Product: " + discount + "%");
            }
            else
            {
                Console.WriteLine("Discount allowed on this Product: " + discount + "%");
            }
            Console.WriteLine("Amount : " + amount);
            totalAmount =amount - ( amount * (discount/100));
            Console.WriteLine("Total Paid Amount : " + totalAmount);
            Console.WriteLine(".............................................................");

        }
    }
}
