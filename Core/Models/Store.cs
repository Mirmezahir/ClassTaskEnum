using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Core.Helper.Enums;

namespace Core.Models
{
    public class Store
    {
        Product[] Products= new Product[0];
        public void Addproduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = product;
        }

        public void ShowAllProducts()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item.No+"."+item.Name+"-"+item.Price);
            }
        }
        public void RemoveProductbyNO(int no)
        {
           
            
        }
        
        public void GetProduct(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
               if( Products[i].No == no)
                {
                    Console.WriteLine(Products[i].Name);    
                }
            }

        }

        public void FilterProductsByType(string name)
        {
            if (name.ToLower() == Sorts.Meat.ToString().ToLower())
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i].Sort.ToString().ToLower() == Sorts.Meat.ToString().ToLower())
                    {
                        Console.WriteLine(Products[i].Name);
                    }
                }
            }
            else if (name.ToLower() == Sorts.Bread.ToString().ToLower())
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i].Sort.ToString().ToLower() == Sorts.Bread.ToString().ToLower())
                    {
                        Console.WriteLine(Products[i].Name);
                    }
                }
            }
            else if (name.ToLower() == Sorts.Fruit.ToString().ToLower())
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i].Sort.ToString().ToLower() == Sorts.Fruit.ToString().ToLower())
                    {
                        Console.WriteLine(Products[i].Name);
                    }
                }
            }
            else Console.WriteLine("Novu duzgun daxil edin ! ");



        }
        public void FilterProductByName(string name)
        {
            foreach(Product product in Products)
            {
                if(product.Name == name)
                {
                    Console.WriteLine(product.Name);    
                }
                else Console.WriteLine("bele mehsul yoxdur");
            }
        }
    }
}
