using CourierKataLibrary;

namespace CourierKataTest
{
    [TestClass]
    public class ParcelTest
    {
        [TestMethod]
        public void processParcelSmallParcelTest()
        {
            Parcel smallParcel = new Parcel(1,1,1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { smallParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Small Parcel: $3. Total Cost: $3");
        }

        [TestMethod]
        public void processParcelMediumParcelTest()
        {
            Parcel mediumParcel = new Parcel(5, 5, 1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { mediumParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Medium Parcel: $8. Total Cost: $8");
        }

        [TestMethod]
        public void processParcelLargeParcelTest()
        {
            Parcel largeParcel = new Parcel(5, 5, 3, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { largeParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Large Parcel: $15. Total Cost: $15");
        }

        [TestMethod]
        public void processParcelXLParcelTest()
        {
            Parcel XLParcel = new Parcel(5, 5, 5, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { XLParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "XL Parcel: $25. Total Cost: $25");
        }
        [TestMethod]
        public void processParcelHeavyParcelTest()
        {
            Parcel HeavyParcel = new Parcel(5, 5, 5, 51);
            Courier courier = new Courier();
            Parcel[] parcels = { HeavyParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Heavy Parcel: $50. Total Cost: $50");
        }

        [TestMethod]
        public void processParcelSmallOverweightTest()
        {
            Parcel smallOverweightParcel = new Parcel(1, 1, 1, 3);
            Courier courier = new Courier();
            Parcel[] parcels = { smallOverweightParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Small Parcel: $7. Total Cost: $7");
        }

        [TestMethod]
        public void processParcelMediumOverweightTest()
        {
            Parcel mediumOverweightParcel = new Parcel(5, 5, 1, 5);
            Courier courier = new Courier();
            Parcel[] parcels = { mediumOverweightParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Medium Parcel: $12. Total Cost: $12");
        }

        [TestMethod]
        public void processParcelLargeOverweightTest()
        {
            Parcel largeOverweightParcel = new Parcel(5, 5, 3, 10);
            Courier courier = new Courier();
            Parcel[] parcels = { largeOverweightParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Large Parcel: $23. Total Cost: $23");
        }

        [TestMethod]
        public void processParcelXLOverweightTest()
        {
            Parcel XLOverweightParcel = new Parcel(5, 5, 5, 20);
            Courier courier = new Courier();
            Parcel[] parcels = { XLOverweightParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "XL Parcel: $45. Total Cost: $45");
        }

        [TestMethod]
        public void processParcelHeavyOverweightTest()
        {
            Parcel HeavyParcel = new Parcel(5, 5, 5, 55);
            Courier courier = new Courier();
            Parcel[] parcels = { HeavyParcel };
            Assert.AreEqual(courier.processParcel(parcels, false), "Heavy Parcel: $55. Total Cost: $55");
        }

    }
}