using System.Data;
using System.Security.Cryptography.X509Certificates;
using Core.Helper.Enums;
using Core.Helper.Exeptions;
using Core.Models;

namespace ClassTaskEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product(1.5,"Alma",Sorts.Fruit);
            Product product2 = new Product(1.7,"Armud",Sorts.Fruit);
            Product product3 = new Product(1,"Nur corek",Sorts.Bread);
            Product product4 = new Product(1.1, "Qara corek", Sorts.Bread);
            Product product5 = new Product(12,"Mal eti",Sorts.Meat);
            Product product6 = new Product(15,"Quzu eti",Sorts.Meat);
            Store store = new Store();  
            store.Addproduct(product1);
            store.Addproduct(product2); 
            store.Addproduct(product3); 
            store.Addproduct(product4);
            store.Addproduct(product5);
            store.Addproduct(product6);
            
            bool cixis = false;
            bool deyisen = false;
            do
            {
                Console.WriteLine("                      MR STORE :) ");
                Console.WriteLine("1.SHOW PRODUCTS\n2.ADD PRODUCTS\n" +
                  "\n3.SEARCH PRODUCT BY NAME\n4.SEARCH PRODUCT BY TYPE\n0.EXIT");
                Console.Write("WHAT DO YOU WANT TO DO? : ");
                int giris;
                deyisen=int.TryParse(Console.ReadLine(), out giris);
                switch (giris)
                {
                    case 1:
                        Console.WriteLine("\n\n\n");
                        store.ShowAllProducts();
                        break;


                        case 2:
                        Console.Write("Mehsulun adini daxil edin : ");
                        string name = Console.ReadLine();
                        Console.Write("Mehsulun qiymetini daxil edin : ");
                        double price;
                        do
                        {
                            deyisen=double.TryParse(Console.ReadLine(), out price);
                        } while (!deyisen);
                        Console.WriteLine("Mehsulun tipini secin : 1.Meat 2.Bread 3.Fruit");
                        int giris2;
                        do
                        {
                            deyisen = int.TryParse(Console.ReadLine(), out giris2);
                        } while (!deyisen);
                        switch (giris2)
                        { 
                            case 1:
                                try
                                {
                                    Product product = new Product(price, name,Sorts.Meat);
                                    store.Addproduct(product);
                                    Console.WriteLine("MEHSUL YARADILDI");
                                }
                                catch (PriceMustBeGratherThanZeroException)
                                {

                                    Console.WriteLine("ERROR PRICE CANT LESS THAN ZERO");
                                }
                                break;
                                case 2:
                                try
                                {
                                    
                                    Product product = new Product(price, name, Sorts.Bread);
                                    store.Addproduct(product);
                                    Console.WriteLine("MEHSUL YARADILDI");
                                }
                                catch (PriceMustBeGratherThanZeroException)
                                {

                                    Console.WriteLine("ERROR PRICE CANT LESS THAN ZERO");
                                }
                                break;
                                case 3:
                                try
                                {
                                    Product product = new Product(price, name, Sorts.Fruit);
                                    store.Addproduct(product);
                                    Console.WriteLine("MEHSUL YARADILDI");
                                }
                                catch (PriceMustBeGratherThanZeroException)
                                {

                                    Console.WriteLine("ERROR PRICE CANT LESS THAN ZERO");
                                }
                                break;



                        }
                        break;
                        case 4: 
                        string axdarisadi = Console.ReadLine();
                        store.FilterProductByName(axdarisadi);
                        break;
                        case 5:
                        string axdaristipi= Console.ReadLine(); 
                        store.FilterProductsByType(axdaristipi);
                        break;
                    case 0:
                        cixis=false;
                        
                        break;
                        





                        


                
                
                
                }






            } while (!cixis);
           
        }
      
    }
}
