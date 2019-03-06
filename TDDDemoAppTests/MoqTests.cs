using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDDDemoApp;

namespace TDDDemoAppTests
{
    [TestClass]
    public class MoqTests
    {
        
        [DataRow(10058, 1, 1, 2)]
        [DataRow(10058, 2, 0, 2)]
        [DataRow(10058, -1, 1, 0)]
        [DataRow(10058, 10, 10, 20)]
        [DataRow(10058, 100, 100, 200)]
        [DataRow(10058, -10, 100, 90)]
        [DataRow(10058, 2, 3, 5)]
        [DataRow(10058, -9, -90, -99)]

        [TestCategory("Moq")]
        [DataTestMethod]
        public async Task When_passed_an_id_and_a_value_should_add_the_new_value_to_the_current_value(int id, int valueToAdd, int currentValue, int expected)
        {
            // Setup
            var moq = new Mock<IFakeService>();
            moq.Setup(m => m.GetValueAsync(It.IsIn(id)))
               .ReturnsAsync(currentValue)
               .Verifiable();

            var service = new DependantService(moq.Object);

            // Act
            var actual = await service.AddValueAsync(id, valueToAdd);

            // Assert
            actual.Should().Be(expected);
            moq.Verify();
            moq.Verify(m => m.SetValueAsync(It.IsIn(id), It.IsIn(expected)));
            moq.VerifyNoOtherCalls();
        }
    }
}