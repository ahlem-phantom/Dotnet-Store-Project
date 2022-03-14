using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    //sealed pour bloquer l'heritage
    public  class Product
    {
     
        public DateTime DateProd { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public Double Price  { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Category Category { get; set; }

        public List<Provider> Providers { get; set; }

       
        public override string ToString()
        {
            return "Name: " + Name + " Description: " + Description + " Quantity: " +Quantity+" Date produit:  "+DateProd;
        }

        public void GetMyType()
        {
            Console.Write("je suis un produit");
        }
    }
}
