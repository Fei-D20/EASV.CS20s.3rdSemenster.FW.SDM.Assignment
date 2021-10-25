using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Xunit;

namespace CoreTest.ModelsTest
{
    public class GradeTest
    {
    
        private readonly Review _review;

        public GradeTest()
        {
            _review = new Review();
        }

        [Fact]
        public void Review_SetGrade_Test()
        {
            _review.Grade = 1;
            Assert.Equal(1, _review.Grade);
        }

        [Fact]
        public void Review_UpdateGrade_Test()
        {
            _review.Grade = 2;
            Assert.Equal(2, _review.Grade);
        }

        [Fact]
        public void Review_GradeMustBeInt_Test()
        {
            Assert.True(_review.Grade is int);
        }
    }
}
