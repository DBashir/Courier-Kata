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
                Cost = 3;
            }
            else if (Dimension < 50)
            {
                Cost = 8;
            }
            else if (Dimension < 100)
            {
                Cost = 15;
            }
            else if (Dimension >= 100)
            {
                Cost = 25;
            }
        }
    }
}
