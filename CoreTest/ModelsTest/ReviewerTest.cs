using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Xunit;

namespace CoreTest.ModelsTest
{
    public class ReviewerTest
    {
        private readonly Review _review;

        public ReviewerTest()
        { 
            _review = new Review();
        }
        

        [Fact]
        public void Review_SetReviewer_Test()
        {
            _review.Reviewer = 1;
            Assert.Equal(1,_review.Reviewer);
        }

        [Fact]
        public void Review_UpdateReviewer_Test()
        {
            _review.Reviewer = 2;
            Assert.Equal(2,_review.Reviewer);
        }

        [Fact]
        public void Review_ReviewerMustBeInt_Test()
        {
            Assert.True(_review.Reviewer is int);
        }
    }
}