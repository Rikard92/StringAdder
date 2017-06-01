using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAdder
{
    public class Adition
    {
        public int Add(string numbers)
        {
            int ret =0;
            if (numbers.Contains(",")|| numbers.Contains("\n"))
            {
                char[] thecar = new[] {',', '\n'}; 

                string[] sep = numbers.Split(thecar);
                

                foreach (string thes in sep)
                {
                    if (Convert.ToInt32(thes) < 0)
                    {
                        throw new NumberNegativeException();
                    }

                    ret = ret + Convert.ToInt32(thes);
                }

            }
            else if (numbers.Equals(""))
            {
                
            }
            else
            {
                ret = Convert.ToInt32(numbers);
            }


            return ret;
        }
    }
}