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

           
            prodadd.Add(new Product 
            {
                pCode = pCode, 
                pName = pName,
                brand = brand,
                qty_In_Stock = qty_In_Stock,
                discount_Allowed = discount_Allowed,
                
            });
           
            //Product obj = new Product();
            //obj.pCode = pCode;
            //obj.pName = pName;
            //obj.qty_In_Stock = qty_In_Stock;
            //obj.discount_Allowed = discount_Allowed;
            //Product.brand = brand;
            //prodadd.Add(obj);
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
            }
        }
    }
}
