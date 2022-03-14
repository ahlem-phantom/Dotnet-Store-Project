using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider: Concept
    {
        //public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
       // public string Password { get; set; }

        public string UserName { get; set; }

        public List<Product> Products { get; set; }
        
        private string password;

        public string Password { get { return password; } set { if (value.Length > 20 || value.Length < 5) Console.WriteLine("password doit comprendre de 5 a 20 caractéres");
                else password = value;
            } }

        private string confirmPassword;
        public string ConfirmPassword { 
            get { return confirmPassword; }
            set
            {
                if (value != Password)
                    Console.WriteLine("Error Confirm password");
                else confirmPassword = value;
            }
        }

        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = p.Password.Equals(p.ConfirmPassword);
        }
       
        public static void SetIsApproved(string password, string confirmPassword,  bool isApproved) {
            isApproved = password.Equals(confirmPassword);
        }
        public static void Calculer(int a,int b,ref int c) {
            c = a + b;
        }

    
        public bool Login(String username, String password,String email=null)
        {
            if (email == null)
            {
                return UserName == username && this.password == password;
            }
            else
            {
                return UserName == username && this.password == password && Email == email;
            }
        }

        public override void GetDetails()
        {   
            Console.WriteLine("Nom: "+UserName);
            /*for(int i=0; i< Products.Count; i++)
            {
                Console.WriteLine(Products[i]);
            }*/

            foreach(Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
       public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Name":
                    foreach(Product p in Products)
                    {
                        if (p.Name == filterValue) 
                            Console.WriteLine(p);
                    }
                    break;
                case "dateProd":
                    foreach (Product p in Products)
                    {
                        if (p.DateProd == DateTime.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;

                case "Price":
                    foreach (Product p in Products)
                    {
                        if (p.Price == Double.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;


            }
                
        }
    }

    
}
