using CourierKataLibrary;

namespace CourierKataTest
{
    [TestClass]
    public class SpeedyShippingTest
    {
        [TestMethod]
        public void speedyShippingDoublesOrder()
        {
            Parcel smallParcel = new Parcel(1, 1, 1, 0);
            Courier courier = new Courier();
            Parcel[] parcels = { smallParcel };
            Assert.AreEqual(courier.processParcel(parcels, true), "Small Parcel: $3. Total Cost: $3. Speedy Shipping: $6");
        }
    }
}