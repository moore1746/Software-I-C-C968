using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU968
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int Stock;
        private int min;
        private int max;

       //Getters and Setters

        public int PartID
        {
            get { return partID; }
            set { partID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int InStock
        {
            get { return Stock; }
            set { Stock = value; }
        }

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }
    }

   
   


}
