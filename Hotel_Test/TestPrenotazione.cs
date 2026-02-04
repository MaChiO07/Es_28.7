using HotelLibrary;

namespace Hotel_Test
{
    [TestClass]
    public sealed class TestPrenotazione
    {
        [TestMethod]
        public void CalcolaGiorniSoggiornoTEST()
        {
            // Arrange
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.CheckIn = new DateTime(2026, 2, 2);
            prenotazione.CheckOut = new DateTime(2026, 2, 4);
            int result;
            // Act
            result = prenotazione.CalcolaGiorniSoggiorno();

            // Assert
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void CalcolaPrezzoTotaleCameraTEST()
        {
            // Arrange
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.CheckIn = new DateTime(2026, 2, 2);
            prenotazione.CheckOut = new DateTime(2026, 2, 4);
            prenotazione.TariffaGiornaliera = 3;
            double result;
            // Act
            result = prenotazione.CalcolaPrezzoTotaleCamera();

            // Assert
            Assert.AreEqual(6, result);

        }

        [TestMethod]
        public void CalcolaPrezzoTotaleServiziTEST()
        {
            // Arrange
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.Servizi = new List<Servizio>();

            Servizio s1 = new Servizio();
            s1.Quantita = 3;
            s1.PrezzoUnitario = 2;

            Servizio s2 = new Servizio();
            s2.Quantita = 6;
            s2.PrezzoUnitario = 3;

            Servizio s3 = new Servizio();
            s3.Quantita = 9;
            s3.PrezzoUnitario = 5;
            
            prenotazione.Servizi.Add(s1);
            prenotazione.Servizi.Add(s2);
            prenotazione.Servizi.Add(s3);

            double result;

            // Act

            result = prenotazione.CalcolaPrezzoTotaleServizi();

            // Assert
            
            Assert.AreEqual(69, result);

        }

        [TestMethod]
        public void CalcolaPrezzoTotalePrenotazioneTEST()
        {
            // Arrange
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.CheckIn = new DateTime(2026, 2, 2);
            prenotazione.CheckOut = new DateTime(2026, 2, 4);
            prenotazione.TariffaGiornaliera = 3;
            prenotazione.Servizi = new List<Servizio>();

            Servizio s1 = new Servizio();
            s1.Quantita = 3;
            s1.PrezzoUnitario = 2;

            Servizio s2 = new Servizio();
            s2.Quantita = 6;
            s2.PrezzoUnitario = 3;

            Servizio s3 = new Servizio();
            s3.Quantita = 9;
            s3.PrezzoUnitario = 5;

            prenotazione.Servizi.Add(s1);
            prenotazione.Servizi.Add(s2);
            prenotazione.Servizi.Add(s3);

            double result;


            // Act
            result = prenotazione.CalcolaPrezzoTotaleCamera() + prenotazione.CalcolaPrezzoTotaleServizi();

            // Assert
            Assert.AreEqual(75, result);

        }

        [TestMethod]
        public void CalcolaSaldoTEST()
        {
            // Arrange
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.CheckIn = new DateTime(2026, 2, 2);
            prenotazione.CheckOut = new DateTime(2026, 2, 4);
            prenotazione.TariffaGiornaliera = 3;
            prenotazione.Servizi = new List<Servizio>();
            prenotazione.Caparra = 75;

            Servizio s1 = new Servizio();
            s1.Quantita = 3;
            s1.PrezzoUnitario = 2;

            Servizio s2 = new Servizio();
            s2.Quantita = 6;
            s2.PrezzoUnitario = 3;

            Servizio s3 = new Servizio();
            s3.Quantita = 9;
            s3.PrezzoUnitario = 5;

            prenotazione.Servizi.Add(s1);
            prenotazione.Servizi.Add(s2);
            prenotazione.Servizi.Add(s3);

            double result;


            // Act
            result = prenotazione.CalcolaSaldo();

            // Assert
            Assert.AreEqual(0, result);

        }







    }
}
