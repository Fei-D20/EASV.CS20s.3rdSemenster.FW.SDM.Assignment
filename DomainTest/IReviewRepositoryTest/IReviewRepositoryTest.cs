using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure;
using Moq;
using Xunit;

namespace DomainTest.IReviewRepositoryTest
{
    public class IReviewRepositoryTest
    {
        [Fact]
        public void ReviewRepositoryIsAvailable()
        {
            var mock = new Mock<IReviewRepository>();
            Assert.NotNull(mock.Object );
        }

        [Fact]
        public void ReviewRepository_FindAll_WithOutParam_ReturnList()
        {
            var mock = new Mock<IReviewRepository>();
            mock.Setup(r => r.FindAll()).Returns(new List<Review>());
            
            Assert.Equal(new List<Review>(),mock.Object.FindAll());

        }
    }
}