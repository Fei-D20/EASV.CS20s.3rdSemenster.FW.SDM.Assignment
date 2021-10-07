using System;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Repositories;
using Xunit;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Test
{
    public class UnitTest1
    {
        
        /// <summary>
        /// 1. Test get the amount of reviews from the reviewer id
        ///     the reviewer should exist
        /// 
        /// </summary>
        [Fact]
        public void GetNumberOfReviewsFromReviewerTest()
        {
            IReviewService reviewService = new ReviewService();
            // min valid data as 1
            Assert.Equal(547,reviewService.GetNumberOfReviewsFromReviewer(1));
            
            // max valid data as 999
            Assert.Equal(1155,reviewService.GetNumberOfReviewsFromReviewer(999));
            
            // test the invalid 0
            var ex = Assert.Throws<InvalidOperationException>(() => reviewService.GetNumberOfReviewsFromReviewer(0));
            Assert.Equal("the reviewer is not exist!! ", ex.Message);
            


        }

        /// <summary>
        /// 2. Test get the average of the grade the reviewer had given
        /// 
        /// </summary>
        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        public void GetAverageRateFromReviewerTest(int valuatorId)
        {
            IReviewService reviewService = new ReviewService();

            var actual = reviewService.GetAverageRateFromReviewer(valuatorId);
            var expected = 10;
            
            Assert.Equal(expected,actual);
        }
        
        /// <summary>
        /// 3. Test how many times the reviewer give the same grade
        /// </summary>
        [Fact]
        public void GetNumberOfRatesByReviewerTest()
        {
        }
        
        /// <summary>
        /// 4. Test how many reviews for the same movie 
        /// </summary>
        [Fact]
        public void GetNumberOfReviewsTest()
        {
        }
        
        /// <summary>
        /// 5. Test the average grade of the movie
        /// </summary>
        [Fact]
        public void GetAverageRateOfMovieTest()
        {
        }
        
        /// <summary>
        /// 6. Test how many time the movie get the same grade
        /// </summary>
        [Fact]
        public void GetNumberOfRatesTest()
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
        [Fact]
        public void GetTopRatedMoviesTest()
        {
        }
        
        /// <summary>
        /// 10. Test for the reviewer which movies the reviewer has to review
        /// the return item should be sorted decreasing by grade and date secondly
        /// </summary>
        [Fact]
        public void GetTopMoviesByReviewerTest()
        {
        }

        /// <summary>
        /// 11. Test for the movie, who have been reviewed.
        /// the list should be sorted decreasing by grade, and date secondly
        /// </summary>
        [Fact]
        public void GetReviewersByMovieTest()
        {
        }

    }
}