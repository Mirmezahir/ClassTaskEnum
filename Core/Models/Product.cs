using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helper.Enums;
using Core.Helper.Exeptions;

namespace Core.Models
{
    public class Product
    {
        private static int _no;
        private double _price;
        public string Sort { get; set; }



        public int No { get; set; }
        public double Price { get 
            
            { 
             return _price;
            
            } set

            {
                if (value < 0)
                {
                    throw new PriceMustBeGratherThanZeroException("ERROR PRICE CANT LESS THAN ZERO");

                }
                else _price = value;
            }    
        
        }
        public string Name { get; set; }
        public Product(double price, string name, Sorts sort)
        {
            ++_no;
            No = _no;
            Price = price;
            Name = name;
            Sort  =sort.ToString();
        }




    }
}
