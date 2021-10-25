using System.Collections.Generic;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services;
using Moq;
using Xunit;

namespace DomainTest.ServiecesTest
{
    public class ReviewServiceTest
    {
        private readonly List<Review> _repository;
        private readonly Mock<IReviewRepository> _mock;

        public ReviewServiceTest()
        {
            _repository = new List<Review>();
            _mock = new Mock<IReviewRepository>();
        }

        [Fact]
        public void ReviewServiceIsIReviewService_Test()
        {
            var reviewService = new ReviewService(_mock.Object);
            
            Assert.True(reviewService is IReviewService);
        }

        [Fact]
        public void ReviewService_WithNullParam_ThrowExceptionWithMessage()
        {
            var invalidDataException = Assert.Throws<InvalidDataException>(() => new ReviewService(null));
            Assert.Equal("the review repository should not be null",invalidDataException.Message);
        }

        [Fact]
        public void ReviewService_CallReviewRepositoryGetAll_ReturnNull_Test()
        {
            var mock = new Mock<IReviewRepository>();
            var reviewService = new ReviewService(mock.Object);
            var invalidDataException = Assert.Throws<InvalidDataException>(() => reviewService.GetAll());
            Assert.Equal("The Repository doesn't have any data!", invalidDataException.Message);
        }
    }
}