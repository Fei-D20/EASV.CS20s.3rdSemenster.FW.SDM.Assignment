using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure;
using Moq;
using Xunit;

namespace RepositoryTest
{
    public class ReviewRepositoryTest
    {
        [Fact]
        public void ReviewRepository_IsAvailable()
        {
            var mock = new Mock<List<Review>>();
            var reviewRepository = new ReviewRepository(mock.Object);
            Assert.NotNull(reviewRepository);
            Assert.True(reviewRepository is IReviewRepository);
        }

        [Fact]
        public void ReviewRepository_FindAll_WithOutParam_ReturnList()
        {
            var mock = new Mock<List<Review>>();
            var reviewRepository = new ReviewRepository(mock.Object);
            Assert.Equal(new List<Review>(),reviewRepository.FindAll());
        }
    }
}