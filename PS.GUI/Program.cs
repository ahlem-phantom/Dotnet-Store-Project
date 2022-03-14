using PS.Domain;
using PS.Services;
using System;
using System.Collections.Generic;

namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             Product p1 = new Product();

            p1.Name = "Fraises";

            p1.DateProd = new DateTime(2022, 1, 31);

             p1.DateProd = new DateTime(2020,10,20);

             p1.Description = "this is a description of product";
            p1.Price = 200;


            Product p2 = new Product()
            {
                Name = "Fraises",
                Quantity = 5,
                DateProd=DateTime.Now,
                Description= "this is a description of product",
                Price=100
            };

            Console.WriteLine(p2);



            Provider p = new Provider(){
                UserName="mouheb",
                Email="mhamdi.mouheb@esprit.tn",
                Password="1234567",
                ConfirmPassword= "1234567"
            };

            //passage par réference

                // Provider.SetIsApproved(p);

            //passage par valeur

            Provider.SetIsApproved(p.Password, p.ConfirmPassword, p.IsApproved);
            
            Console.WriteLine(p.IsApproved);

            int j = 5;
            int i = 3;
            int k = 2;

            Provider.Calculer(i, j,ref k);

            Console.WriteLine("Login: "+p.Login("mouheb", "1234567"));

            Console.WriteLine("Login: " + p.Login("mouheb", "1234567","mhamdi.mouheb@esprit.tn"));
            Console.WriteLine(k);

            Console.WriteLine("-------------------------------------------------------------------");

            Product ps = new Product();
            Chemical c = new Chemical();
            Biological b = new Biological();
            ps.GetMyType();
            c.GetMyType();
            b.GetMyType();

            //Collection

            List<Product> products = new List<Product>
            {
                p1
            };

           
            products.Add(p2);

            p.Products = products;
            Console.WriteLine("\n");
            p.GetDetails();

            Console.WriteLine("la methode getProducts");
            p.GetProducts("dateProd", "2020/10/20");


            Console.WriteLine("---------------------déléguer-----------------------------");

            ManageProduct mp = new ManageProduct();
            mp.lsProduct = products;

            foreach(Product pp in mp.FindProduct('F'))
            {
                Console.WriteLine(pp);
            }


            foreach(Chemical ch in mp.Get5Chemical(10))
            {
                Console.WriteLine(ch);
            }
        }
    }
}
