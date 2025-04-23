using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Models;
using Controllers;


namespace Controllers
{
    class ProductController
    {
        
        public ProductController()
        {
        }

        public Product LoadProduct()
        {
            Console.WriteLine("------LOADING PRODUCT------");
            return ProductView.LoadProduct();
        }
        public static List<Product> LoadProductList()
        {
            string resp = "n";
            List<Product> temp = new List<Product>();
            do
            {
                temp.Add(ProductView.LoadProduct());
                Console.WriteLine("Add another product? Y/N");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");

            return temp;
        }

        public void ShowProductList(List <Product>productList)
        {
            ProductView.ShowProductList(productList);
        }




    }
}
