using System;
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
        private readonly ReviewService _reviewService;

        public ReviewServiceTest()
        {
            _repository = new List<Review>();
            _mock = new Mock<IReviewRepository>();
            _reviewService = new ReviewService(_mock.Object);
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
        public void ReviewService_CallReviewRepositoryGetAll_OnlyOnce_Test()
        {
            _reviewService.GetAll();
            _mock.Verify(r=>r.FindAll(),Times.Once());
        }

        [Fact]
        public void ReviewService_CallReviewRepositoryGetAll_ReturnListOfReview()
        {
            var random = new Random();
            var next = random.Next(0,100);
            
            for (int i = 0; i < 10; i++)
            {
                _repository.Add(new Review()
                {
                    Grade = next,
                    Movie = next,
                    Reviewer = next
                });
            }

            _mock.Setup(r => r.FindAll()).Returns(_repository);
            var reviews = _reviewService.GetAll();
            
            Assert.Equal(_repository,reviews);

        }
    }
}