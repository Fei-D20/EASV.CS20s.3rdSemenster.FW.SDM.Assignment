using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Moq;
using Xunit;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Test
{
    public class ReviewAssignmentTest
    {
        private readonly Mock<IReviewRepository> _mock;
            
        public ReviewAssignmentTest()
        {
            _mock = new Mock<IReviewRepository>();

        }

        /// <summary>
        /// 1. Test get the amount of reviews from the reviewer id
        /// </summary>

        
        [Theory]
        [InlineData(001,10)]
        [InlineData(002,20)]
        public void GetNumberOfReviewsFromReviewerTest(int reviewer,int number)
        {
            _mock.Setup(o => o.GetNumberOfReviewsFromReviewer(reviewer)).Returns(number);
            
            Assert.Equal(number,_mock.Object.GetNumberOfReviewsFromReviewer(reviewer));
        }

        /// <summary>
        /// 2. Test get the average of the grade the reviewer had given
        /// 
        /// </summary>
        [Theory]
        [InlineData(1,0.06)]
        [InlineData(0,0.83)]
        public void GetAverageRateFromReviewerTest(int Reviewer,double average)
        {
            _mock.Setup(o => o.GetAverageRateGetAverageRateFromReviewer(Reviewer))
                .Returns(average);
            
            Assert.Equal(average,_mock.Object.GetAverageRateGetAverageRateFromReviewer(Reviewer));
        }
        
        /// <summary>
        /// 3. Test how many times the reviewer give the same grade
        /// </summary>
        [Theory]
        [InlineData(003,12)]
        [InlineData(004,23)]
        public void GetNumberOfRatesByReviewerTest(int reviewer,int number)
        {
            _mock.Setup(o => o.GetNumberOfRatesByReviewer(reviewer)).Returns(number);
            Assert.Equal(number,_mock.Object.GetNumberOfRatesByReviewer(reviewer));
        }
        
        /// <summary>
        /// 4. Test how many reviews for the same movie 
        /// </summary>
        [Theory]
        [InlineData(003,12)]
        [InlineData(004,23)]
        public void GetNumberOfReviewsTest(int review,int number)
        {
            _mock.Setup(o => o.GetNumberOfReviews(review)).Returns(number);
            Assert.Equal(number,_mock.Object.GetNumberOfReviews(review));
        }
        
        /// <summary>
        /// 5. Test the average grade of the movie
        /// </summary>
        [Theory]
        [InlineData(003,1.2)]
        [InlineData(004,2.3)]
        public void GetAverageRateOfMovieTest(int movie, double rate)
        {
            _mock.Setup(o => o.GetAverageRateOfMovie(movie)).Returns(rate);
            Assert.Equal(rate,_mock.Object.GetAverageRateOfMovie(movie));
        }
        
        /// <summary>
        /// 6. Test how many time the movie get the same grade
        /// </summary>
        [Theory]
        [InlineData(003,1.2)]
        [InlineData(004,2.3)]
        public void GetNumberOfRatesTest(int movie, double rate)
        {
            _mock.Setup(o => o.GetNubmerOfRates(movie)).Returns(rate);
            Assert.Equal(rate,_mock.Object.GetNubmerOfRates(movie));
            
        }
        
        /// <summary>
        /// 7. Test the top grade movies
        /// </summary>
        [Fact]
        public void GetMoviesWithHighestNumberOfTopRatesTest()
        {
            var movie = new int[]{1,2,3,4,5};
            _mock.Setup(o => o.GetMoviesWithHighestNumberOfTopRates()).Returns(movie);
            Assert.Equal(movie,_mock.Object.GetMoviesWithHighestNumberOfTopRates());

        }
        
        /// <summary>
        ///  8. Test the most reviews reviewer
        /// </summary>
        [Fact]
        public void GetMostProductiveReviewersTest()
        {
            int[] reviewer = {1,2,3,4,5};
            _mock.Setup(o => o.GetMostProductiveReviewers()).Returns(reviewer);
            Assert.Equal(reviewer,_mock.Object.GetMostProductiveReviewers());
            
        }
        
        /// <summary>
        /// 9. Test for the average grade. which movies is the top amount
        /// </summary>
        [Theory]
        [InlineData(2.3,10)]
        [InlineData(3.5,8)]
        public void GetTopRatedMoviesTest(double grade,int amount)
        {
            _mock.Setup(o => o.GetTopRatedMovies(grade)).Returns(amount);
            Assert.Equal(amount,_mock.Object.GetTopRatedMovies(grade));
        }
        
        /// <summary>
        /// 10. Test for the reviewer which movies the reviewer has to review
        /// the return item should be sorted decreasing by grade and date secondly
        /// </summary>
        [Theory]
        [InlineData(232)]
        public void GetTopMoviesByReviewerTest(int reviewer)
        {
            int[] movies = { 1, 2, 3, 4, 5 };
            _mock.Setup(o => o.GetTopMoviesByReviewer(reviewer)).Returns(movies);
            Assert.Equal(movies,_mock.Object.GetTopMoviesByReviewer(reviewer));
        }

        /// <summary>
        /// 11. Test for the movie, who have been reviewed.
        /// the list should be sorted decreasing by grade, and date secondly
        /// </summary>
        [Theory]
        [InlineData(232)]
        public void GetReviewersByMovieTest(int movie)
        {
            int[] reviewers = { 1, 2, 3, 4, 5 };
            _mock.Setup(o => o.GetReviewersByMovie(movie)).Returns(reviewers);
            Assert.Equal(reviewers,_mock.Object.GetReviewersByMovie(movie));
        }

    }
}