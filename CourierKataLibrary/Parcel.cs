using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKataLibrary
{
    public class Parcel
    {
        public int Dimension { get; set; }
        public int Cost { get; set; }
        public ParcelType ParcelType { get; set; }
        public int Weight { get; set; }


        public Parcel(int length, int width, int height, int weight)
        {
            Dimension = length * width * height;
            Weight = weight;
            setCost();
            setWeight();
        }

        private void setCost()
        {
            if (Dimension < 10)
            {
                ParcelType = ParcelType.Small;
                Cost = 3;
            }
            else if (Dimension < 50)
            {
                ParcelType = ParcelType.Medium;
                Cost = 8;
            }
            else if (Dimension < 100)
            {
                ParcelType = ParcelType.Large;
                Cost = 15;
            }
            else if (Dimension >= 100)
            {
                ParcelType = ParcelType.XL;
                Cost = 25;
            }
        }

        private void setWeight()
        {
            int overWeightLimit = 2;
            if(ParcelType == ParcelType.Small && Weight > 1)
            {
                Cost += (Weight - 1) * overWeightLimit;
            }
            else if (ParcelType == ParcelType.Medium && Weight > 3)
            {
                Cost += (Weight - 3) * overWeightLimit;
            }
            else if (ParcelType == ParcelType.Large && Weight > 6)
            {
                Cost += (Weight - 6) * overWeightLimit;
            }
            else if (ParcelType == ParcelType.XL && Weight > 10)
            {
                Cost += (Weight - 10) * overWeightLimit;
            }
        }
    }
}
