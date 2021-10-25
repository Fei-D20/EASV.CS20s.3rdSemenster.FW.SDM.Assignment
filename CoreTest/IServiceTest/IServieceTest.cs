using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using Moq;
using Xunit;

namespace CoreTest.IServiceTest
{
    public class IServieceTest
    {
        [Fact]
        public void IService_IsAvailable_Test()
        {
            var mock = new Mock<IReviewService>();
            Assert.NotNull(mock.Object);
        }

        [Fact]
        public void IService_GetAll_WithOutParam_ReturnListOfReview()
        {
            var mock = new Mock<IReviewService>();
            mock.Setup(o => o.GetAll())
                .Returns(new List<Review>());

            var reviewService = mock.Object;
            var reviews = new List<Review>();
            Assert.Equal(reviews,reviewService.GetAll());
        }
    }
}