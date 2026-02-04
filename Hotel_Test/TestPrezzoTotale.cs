using HotelLibrary;

namespace Hotel_Test
{
    [TestClass]
    public sealed class TestServizio
    {
        [TestMethod]
        public void PrezzoTotaleTEST()
        {
            // Arrange
            double result;
            Servizio servizio = new Servizio();
            servizio.Quantita = 3;
            servizio.PrezzoUnitario = 2;

            // Act
            result = servizio.PrezzoTotale();
            // Assert
            Assert.AreEqual(6, result);

        }
    }
}
