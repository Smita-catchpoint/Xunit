using FluentAssertions;
using FluentAssertions.Extensions;
using SimpleConsoleApp.Ping;
using System.Net.NetworkInformation;

namespace XUnitTest.Ping
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
         //SUT-System Under Test
        public NetworkServiceTests()
        {
            _pingService = new NetworkService();
        }

        [Fact]
        public void NetworkService_SendPing_ReurnStrig()
        {
            //Arrange-varialbles,classes
           // var pingService = new NetworkService();

            //Act
           var result = _pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success:Ping Send");
           result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b ,int expected)
        {
            //Arrange
            //var pingService = new NetworkService();
            //Act
            var result = _pingService.PingTimeout(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BePositive();

        }
        [Fact]
        public void NetworkService_LastPingDate_ReurnDate()
        {
            //Arrange-varialbles,classes
            // var pingService = new NetworkService();

            //Act
            var result = _pingService.LastPingDate();
            //Assert
            result.Should().BeAfter(1.November(2023));
            result.Should().BeBefore(31.January(2024));
           
        }

        [Fact]
        public void NetworkServices_GetPingOptions_ReturnObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.GetPingOptions();
            //Assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
           // result.Ttl.Should().Be(expected.Ttl);
           result.Ttl.Should().Be(1);
        }
        [Fact]
        public void NetworkServices_MostRecentPings_ReturnObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            //Act
            var result = _pingService.MostRecentPings();
            //Assert
           result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment==true);          
        }

    }
}
