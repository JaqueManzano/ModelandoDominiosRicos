using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var name = new Name("Teste", "Teste");

        foreach (var notification in name.Notifications)
        {
            
        }
        //var student = new Student ("Jaque", "Manzano", "123456789", "jaque@hotmail.com");

        //var subscription = new Subscription(null);
        //student.AddSubscription(subscription);
    }
}