using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using Xunit;

namespace DomainTest.IReviewRepositoryTest
{
    public class IReviewRepositoryTest
    {
        private readonly ReviewRepository _reviewRepository;

        public IReviewRepositoryTest()
        {
            _reviewRepository = new ReviewRepository();
        }

        [Fact]
        public void ReviewRepositoryIsAvailable()
        {
            
            Assert.NotNull(_reviewRepository);
            Assert.True(_reviewRepository is IReviewRepository);
        }

        [Fact]
        public void ReviewRepository_FindAll_Test()
        {
            
        }
    }

    public class ReviewRepository:IReviewRepository
    {
        public List<Review> FindAll()
        {
            throw new System.NotImplementedException();
        }
    }
}