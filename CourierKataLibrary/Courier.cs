using System.Text;

namespace CourierKataLibrary
{
    public class Courier
    {
        public string processParcel(Parcel[] parcels, bool speedyShipping)
        {
            bestDiscount(parcels);

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

        //TODO change logic to use a mixture of discounts to get the best value
        private int bestDiscount(Parcel[] parcels)
        {
            Parcel[] smallParcels = smallParcelDiscount(parcels);
            int smallDiscountTotal = 0;
            foreach (Parcel parcel in smallParcels)
            {
                smallDiscountTotal += parcel.Cost;
            }

            Parcel[] mediumParcels = mediumParcelDiscount(parcels);
            int mediumDiscountTotal = 0;
            foreach (Parcel parcel in mediumParcels)
            {
                mediumDiscountTotal += parcel.Cost;
            }

            Parcel[] mixedParcels = mixedParcelDiscount(parcels);
            int mixedDiscountTotal = 0;
            foreach (Parcel parcel in mixedParcels)
            {
                mixedDiscountTotal += parcel.Cost;
            }


        }

        private Parcel[] smallParcelDiscount(Parcel[] parcels)
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
            return parcels;
        }

        private Parcel[] mediumParcelDiscount(Parcel[] parcels)
        {
            int Counter = 1;
            for (int i = 0; i < parcels.Length; i++)
            {
                if (parcels[i].ParcelType == ParcelType.Medium)
                {

                    if (Counter % 3 == 0) parcels[i].Cost = 0;
                    Counter++;
                }
            }
            return parcels;
        }

        private Parcel[] mixedParcelDiscount(Parcel[] parcels)
        {
            int Counter = 1;
            for (int i = 0; i < parcels.Length; i++)
            {
                if (Counter % 5 == 0) parcels[i].Cost = 0;
                Counter++;
            }
            return parcels;
        }

    }

}