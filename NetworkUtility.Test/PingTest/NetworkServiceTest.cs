using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Test.PingTest
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            NetworkService nt=new NetworkService();


            //Act
            string s = nt.SendPing();


            //Assert
            s.Should().NotBeNullOrWhiteSpace();
            s.Should().NotBeNull();
            s.Should().BeUpperCased();
           

        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,3,4)]
        public void NetworkService_TimeOut_ReturnInt(int a,int b, int expected)
        {
            //Arrange
            NetworkService nt = new NetworkService();


            //Act
            var s = nt.TimeOut(a,b);

            //Assert
            s.Should().Be(expected);
            s.Should().BeGreaterThanOrEqualTo(3);
            s.Should().NotBeInRange(0, 5);
        }

    }
}
