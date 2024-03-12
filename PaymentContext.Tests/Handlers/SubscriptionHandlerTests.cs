using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists() 
        { 
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";
            command.BarCode = "123456789123";
            command.BoletoNumber = "1235656555";
            command.PaymentNumber = "554454";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE CORP";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "baltman@dc.com";
            command.Street = "Street teste";
            command.Number = "Number teste";
            command.Neigborhood = "Neigborhood teste";
            command.City = "City teste";
            command.State = "State teste";
            command.Country = "Country teste";
            command.ZipCode = "1098755";

            handler.Handle(command);
            Assert.AreEqual(false, handler.IsValid);
        }
    }
}
