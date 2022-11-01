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


        public Parcel(int length, int width, int height)
        {
            Dimension = length * width * height;
            setCost();
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
    }
}
