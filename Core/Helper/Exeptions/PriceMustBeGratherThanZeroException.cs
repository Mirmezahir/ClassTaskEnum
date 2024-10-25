using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper.Exeptions
{
    public class PriceMustBeGratherThanZeroException:Exception
    {
        public PriceMustBeGratherThanZeroException()
        {
            

        }
        public PriceMustBeGratherThanZeroException(string word):base(word) 
        {
            
        }


    }
}
