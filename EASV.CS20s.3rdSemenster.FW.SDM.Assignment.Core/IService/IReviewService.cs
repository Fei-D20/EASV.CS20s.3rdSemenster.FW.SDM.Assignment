using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IReviewService
    {
        public Movie GetMovie(int reviewID);
        public Valuator GetValuator(int reviewID);
        
        int GetNumberOfReviewsFromReviewer(int valuatorId);

    }
}