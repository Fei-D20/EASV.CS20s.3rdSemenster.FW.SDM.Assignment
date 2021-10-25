using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Xunit;

namespace CoreTest.ModelsTest
{
    public class MovieTest
    {
        private readonly Review _review;

        public MovieTest()
        {
            _review = new Review();
        }

        [Fact]
        public void Review_SetMovie_Test()
        {
            _review.Movie = 1;
            Assert.Equal(1, _review.Movie);
        }

        [Fact]
        public void Review_UpdateMovie_Test()
        {
            _review.Movie = 2;
            Assert.Equal(2, _review.Movie);
        }

        [Fact]
        public void Review_MovierMustBeInt_Test()
        {
            Assert.True(_review.Movie is int);
        }
    }
}
    