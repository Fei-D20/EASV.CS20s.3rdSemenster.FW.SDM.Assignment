using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        private readonly List<Review> _reviewList;
        private readonly Mock<IReviewRepository> _mockReviewRepository;

        public ReviewServiceAssignmentTest()
        {
            _reviewList = new List<Review>();
            
            _reviewList.Add(new Review()
            {
                Grade = 1,Id = 1,Movie = 1,Reviewer = 1
            });
            
            _reviewList.Add(new Review()
            {
                Grade = 5,Id = 2,Movie = 2,Reviewer = 1
            });
            
            _reviewList.Add(new Review()
            {
                Grade = 3,Id = 3,Movie = 3,Reviewer = 1
            });
            
            _reviewList.Add(new Review()
            {
                Grade = 2,Id = 4,Movie = 1,Reviewer = 2
            });
            
            _reviewList.Add(new Review()
            {
                Grade = 4,Id = 5,Movie = 2,Reviewer = 3
            });
            
            _reviewList.Add(new Review()
            {
                Grade = 4,Id = 6,Movie = 2,Reviewer = 3
            });
            _reviewList.Add(new Review()
            {
                Grade = 4,Id = 7,Movie = 2,Reviewer = 2
            });
            _reviewList.Add(new Review()
            {
                Grade = 4,Id = 8,Movie = 2,Reviewer = 3
            });
            _mockReviewRepository = new Mock<IReviewRepository>();
            _reviewService = new ReviewService(_mockReviewRepository.Object);

        }

        /// <summary>
        /// 1. Test get the amount of reviews from the reviewer id
        /// </summary>

        
        [Theory]
        [InlineData(02)]
        public void GetNumberOfReviewsFromReviewerTest(int reviewer)
        {
            _mockReviewRepository.Setup(o => o.FindReviewsByReviewer(reviewer)).Returns(_reviewList);
            Assert.Equal(_reviewList.Count, _reviewService.GetNumberOfReviewsFromReviewer(reviewer));
        }

        /// <summary>
        /// 2. Test get the average of the grade the reviewer had given
        /// 
        /// </summary>
        [Theory]
        [InlineData(1,3)]
        [InlineData(2,3)]
        [InlineData(3,4)]
        public void GetAverageRateFromReviewerTest(int reviewer,double average)
        {
            var findAll = _reviewList.FindAll(r => r.Reviewer == reviewer);
            _mockReviewRepository.Setup(o => o.FindReviewsByReviewer(reviewer))
                .Returns(findAll);
            
            Assert.Equal(average,_reviewService.GetAverageRateFromReviewer(reviewer));
        }
        
        /// <summary>
        /// 3. Test how many times the reviewer give the same grade
        /// </summary>
        [Theory]
        [InlineData(1,3)]
        [InlineData(2,2)]
        public void GetNumberOfRatesByReviewerTest(int reviewer,int expect)
        {
            _mockReviewRepository.Setup(o => o.FindReviewsByReviewer(reviewer))
                .Returns(_reviewList.FindAll(r => r.Reviewer == reviewer));
            Assert.Equal(expect,_reviewService.GetNumberOfRatesByReviewer(reviewer));
        }
        
        /// <summary>
        /// 4. Test how many reviews for the same movie 
        /// </summary>
        [Theory]
        [InlineData(1,2)]
        [InlineData(2,5)]
        [InlineData(3,1)]
        public void GetNumberOfReviewsTest(int movie,int expected)
        {
            _mockReviewRepository.Setup(o => o.FindReviewsByMovie(movie))
                .Returns(_reviewList.FindAll(r => r.Movie == movie));
            Assert.Equal(expected,_reviewService.GetNumberOfReviews(movie));
        }
        
        /// <summary>
        /// 5. Test the average grade of the movie
        /// </summary>
        [Theory]
        [InlineData(1,1.5)]
        [InlineData(2,4.2)]
        [InlineData(3,3)]
        public void GetAverageRateOfMovieTest(int movie, double expected)
        {
            _mockReviewRepository.Setup(o => o.FindReviewsByMovie(movie))
                .Returns(_reviewList.FindAll(r => r.Movie == movie));
            Assert.Equal(expected, _reviewService.GetAverageRateOfMovie(movie));
        }
        
        /// <summary>
        /// 6. Test how many time the movie get the same grade
        /// </summary>
        [Theory]
        [InlineData(1,1, 1)]
        [InlineData(2,4, 4)]
        public void GetNumberOfRatesTest(int movie, double rate, int expect)
        {
            _mockReviewRepository.Setup(o => o.FindReviewsByMovie(movie))
                .Returns(_reviewList.FindAll(r => r.Movie == movie));
            Assert.Equal(expect, _reviewService.GetNumberOfRates(movie,rate));

        }
        
        /// <summary>
        /// 7. Test the top grade movies
        /// </summary>
        [Fact]
        public void GetMoviesWithHighestNumberOfTopRatesTest()
        {
            var moviesWithHighestNumberOfTopRates = _reviewService.GetMoviesWithHighestNumberOfTopRates();
            
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