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

        [TestMethod]
        public void ThirdMediumParcelFreeTest()
        {
            Parcel mediumParcel = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel2 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel3 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel4 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel5 = new Parcel(5, 5, 1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { mediumParcel, mediumParcel2, mediumParcel3, mediumParcel4, mediumParcel5 };
            Assert.AreEqual(courier.processParcel(parcels, false), "Medium Parcel: $8Medium Parcel: $8Medium Parcel: $0Medium Parcel: $8Medium Parcel: $8. Total Cost: $32");
        }

        [TestMethod]
        public void EveryFifthParcelFreeTest()
        {
            Parcel smallParcel = new Parcel(1, 1, 1, 0);
            Parcel smallParcel2 = new Parcel(1, 1, 1, 0);
            Parcel smallParcel3 = new Parcel(1, 1, 1, 0);
            Parcel smallParcel4 = new Parcel(1, 1, 1, 0);
            Parcel smallParcel5 = new Parcel(1, 1, 1, 0);
            Parcel mediumParcel = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel2 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel3 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel4 = new Parcel(5, 5, 1, 0);
            Parcel mediumParcel5 = new Parcel(5, 5, 1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { smallParcel, smallParcel2, smallParcel3, smallParcel4, smallParcel5,  mediumParcel, mediumParcel2, mediumParcel3, mediumParcel4, mediumParcel5 };
            Assert.AreEqual(courier.processParcel(parcels, false), "Small Parcel: $3Small Parcel: $3Small Parcel: $3Small Parcel: $3Small Parcel: $0Medium Parcel: $8Medium Parcel: $8Medium Parcel: $8Medium Parcel: $8Medium Parcel: $0. Total Cost: $44");
        }
    }
}