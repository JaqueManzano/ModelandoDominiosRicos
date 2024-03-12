using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _students = new List<Student>();

        public StudentQueriesTests()
        {
            for (int i = 0; i <= 10; i++)
            {
                _students.Add(new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "@balta.io")));
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExists()
        {
            var expression = StudentQueries.GetStudentInfo("12345678987");
            var student = _students.AsQueryable().Where(expression).FirstOrDefault();
            Assert.AreEqual(null, student);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentNotExists()
        {
            var expression = StudentQueries.GetStudentInfo("11111111111");
            var student = _students.AsQueryable().Where(expression).FirstOrDefault();
            Assert.AreNotEqual(null, student);
        }
    }
}
