using System.Text;

namespace CourierKataLibrary
{
    public class Courier
    {
        public string processParcel(Parcel[] parcels, bool speedyShipping)
        {
            smallParcelDiscount(parcels);

            StringBuilder sb = new StringBuilder();
            int totalCost = 0;
            for(int i = 0; i < parcels.Length; i++)
            {
                sb.Append(parcels[i].ParcelType);
                sb.Append(" Parcel: $" + parcels[i].Cost);
                totalCost += parcels[i].Cost;
            }
            sb.Append(". Total Cost: $" + totalCost);
            if (speedyShipping)
            {
                sb.Append(". Speedy Shipping: $" + totalCost * 2);
            }
            return sb.ToString();
        }

        private void smallParcelDiscount(Parcel[] parcels)
        {
            int Counter = 1;
            for (int i = 0; i < parcels.Length; i++)
            {
                if (parcels[i].ParcelType == ParcelType.Small)
                {
                    Counter++;
                    if (Counter % 4 == 0)
                    {
                        parcels[i].Cost = 0;
                    }
                }
            }
        }



    }

}