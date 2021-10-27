using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Moq;
using Xunit;

namespace CoreTest.IServiceTest
{
    public class IServieceTest
    {
        private readonly Mock<IReviewService> _mock;

        public IServieceTest()
        {
            _mock = new Mock<IReviewService>();

        }

        [Fact]
        public void IService_IsAvailable_Test()
        {
            Assert.NotNull(_mock.Object);
        }

        [Fact]
        public void IService_GetAll_WithOutParam_ReturnListOfReview()
        {
            _mock.Setup(o => o.GetAll())
                .Returns(new List<Review>());

            var reviewService = _mock.Object;
            var reviews = new List<Review>();
            Assert.Equal(reviews,reviewService.GetAll());
        }
    }
}