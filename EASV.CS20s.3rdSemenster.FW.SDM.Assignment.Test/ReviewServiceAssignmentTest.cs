using System;
using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure;
using Moq;
using Xunit;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Test
{
    public class ReviewServiceAssignmentTest
    {
        
        private readonly IReviewService _reviewService;
        private readonly List<Review> _reviews;
        private readonly Mock<IReviewRepository> _mock;

        public ReviewServiceAssignmentTest()
        {
            _reviews = new List<Review>();
            
            _reviews.Add(new Review()
            {
                Grade = 1,Id = 1,Movie = 1,Reviewer = 1
            });
            
            _reviews.Add(new Review()
            {
                Grade = 5,Id = 1,Movie = 1,Reviewer = 1
            });
            
            _reviews.Add(new Review()
            {
                Grade = 3,Id = 1,Movie = 1,Reviewer = 1
            });
            
            _reviews.Add(new Review()
            {
                Grade = 1,Id = 2,Movie = 1,Reviewer = 1
            });
            
            _reviews.Add(new Review()
            {
                Grade = 1,Id = 2,Movie = 1,Reviewer = 1
            });
            _mock = new Mock<IReviewRepository>();
            _reviewService = new ReviewService(_mock.Object);

        }

        /// <summary>
        /// 1. Test get the amount of reviews from the reviewer id
        /// </summary>

        
        [Theory]
        [InlineData(02)]
        public void GetNumberOfReviewsFromReviewerTest(int reviewer)
        {
            _mock.Setup(o => o.FindReviewsByReviewer(reviewer)).Returns(_reviews);
            Assert.Equal(_reviews.Count, _reviewService.GetNumberOfReviewsFromReviewer(reviewer));
        }

        /// <summary>
        /// 2. Test get the average of the grade the reviewer had given
        /// 
        /// </summary>
        [Theory]
        [InlineData(1,2.2)]
        public void GetAverageRateFromReviewerTest(int reviewer,double average)
        {
            _mock.Setup(o => o.FindReviewsByReviewer(reviewer)).Returns(_reviews);
            Assert.Equal(average,_reviewService.GetAverageRateFromReviewer(reviewer));
        }
        
        /// <summary>
        /// 3. Test how many times the reviewer give the same grade
        /// </summary>
        [Theory]
        [InlineData(003,12)]
        [InlineData(004,23)]
        public void GetNumberOfRatesByReviewerTest(int reviewer,int number)
        {
        }
        
        /// <summary>
        /// 4. Test how many reviews for the same movie 
        /// </summary>
        [Theory]
        [InlineData(003,12)]
        [InlineData(004,23)]
        public void GetNumberOfReviewsTest(int review,int number)
        {
            
        }
        
        /// <summary>
        /// 5. Test the average grade of the movie
        /// </summary>
        [Theory]
        [InlineData(003,1.2)]
        [InlineData(004,2.3)]
        public void GetAverageRateOfMovieTest(int movie, double rate)
        {
        }
        
        /// <summary>
        /// 6. Test how many time the movie get the same grade
        /// </summary>
        [Theory]
        [InlineData(003,1.2)]
        [InlineData(004,2.3)]
        public void GetNumberOfRatesTest(int movie, double rate)
        {
            
            
        }
        
        /// <summary>
        /// 7. Test the top grade movies
        /// </summary>
        [Fact]
        public void GetMoviesWithHighestNumberOfTopRatesTest()
        {

        }
        
        /// <summary>
        ///  8. Test the most reviews reviewer
        /// </summary>
        [Fact]
        public void GetMostProductiveReviewersTest()
        {
          
            
        }
        
        /// <summary>
        /// 9. Test for the average grade. which movies is the top amount
        /// </summary>
        [Theory]
        [InlineData(2.3,10)]
        [InlineData(3.5,8)]
        public void GetTopRatedMoviesTest(double grade,int amount)
        {
          
        }
        
        /// <summary>
        /// 10. Test for the reviewer which movies the reviewer has to review
        /// the return item should be sorted decreasing by grade and date secondly
        /// </summary>
        [Theory]
        [InlineData(232)]
        public void GetTopMoviesByReviewerTest(int reviewer)
        {
            
        }

        /// <summary>
        /// 11. Test for the movie, who have been reviewed.
        /// the list should be sorted decreasing by grade, and date secondly
        /// </summary>
        [Theory]
        [InlineData(232)]
        public void GetReviewersByMovieTest(int movie)
        {
         
        }
    }
}