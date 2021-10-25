using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Xunit;

namespace CoreTest.ModelsTest
{
    public class ReviewTest
    {
        private readonly Review _review;

        public ReviewTest()
        {
            _review = new Review();
        }

        [Fact]
        public void Review_CanBeInitialized_Test()
        {
            Assert.NotNull(_review);
        }

    }
}