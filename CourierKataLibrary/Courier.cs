using System.Text;

namespace CourierKataLibrary
{
    public class Courier
    {
        public string processParcel(Parcel[] parcels)
        {
            StringBuilder sb = new StringBuilder();
            int totalCost = 0;
            for(int i = 0; i < parcels.Length; i++)
            {
                sb.Append(parcels[i].ParcelType);
                sb.Append(" Parcel: $" + parcels[i].Cost);
                totalCost += parcels[i].Cost;
            }
            sb.Append(". Total Cost: $" + totalCost);
            return sb.ToString();
        }

    }
}