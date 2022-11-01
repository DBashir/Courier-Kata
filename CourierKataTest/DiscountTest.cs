using CourierKataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKataTest
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void fourthSmallParcelFreeTest()
        {
            Parcel smallParcel = new Parcel(1, 1, 1, 0);
            Parcel smallParcel2 = new Parcel(1, 1, 1, 0);
            Parcel smallParcel3 = new Parcel(1, 1, 1, 0);
            Parcel smallParcel4 = new Parcel(1, 1, 1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { smallParcel, smallParcel2, smallParcel3, smallParcel4 };
            Assert.AreEqual(courier.processParcel(parcels, false), "Small Parcel: $3Small Parcel: $3Small Parcel: $0Small Parcel: $3. Total Cost: $9");
        }
    }
}
