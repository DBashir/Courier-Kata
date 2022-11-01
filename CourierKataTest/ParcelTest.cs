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
            Assert.Equals(courier.processParcel(parcels), "Small Parcel: $3.Total Cost: $3");
        }
    }
}