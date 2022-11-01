using CourierKataLibrary;

namespace CourierKataTest
{
    [TestClass]
    public class ParcelTest
    {
        [TestMethod]
        public void processParcelSmallParcelTest()
        {
            Parcel smallParcel = new Parcel(1,1,1);
            Courier courier = new Courier();
            Parcel[] parcels = { smallParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Small Parcel: $3. Total Cost: $3");
        }

        [TestMethod]
        public void processParcelMediumParcelTest()
        {
            Parcel mediumParcel = new Parcel(5, 5, 1);
            Courier courier = new Courier();
            Parcel[] parcels = { mediumParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Medium Parcel: $8. Total Cost: $8");
        }

        [TestMethod]
        public void processParcelLargeParcelTest()
        {
            Parcel largeParcel = new Parcel(5, 5, 3);
            Courier courier = new Courier();
            Parcel[] parcels = { largeParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Large Parcel: $15. Total Cost: $15");
        }

        [TestMethod]
        public void processParcelXLParcelTest()
        {
            Parcel XLParcel = new Parcel(5, 5, 5);
            Courier courier = new Courier();
            Parcel[] parcels = { XLParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "XL Parcel: $25. Total Cost: $25");
        }
    }
}