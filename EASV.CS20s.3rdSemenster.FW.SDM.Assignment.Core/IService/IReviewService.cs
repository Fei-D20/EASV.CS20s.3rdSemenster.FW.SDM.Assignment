using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IReviewService
    {
        public double GetAverageRateOfMovie(int movieId);
        
        public int GetNumberOfRates(int movieId, int grade);
        
        public int GetNumberOfReviewsFromReviewer(int valuatorId);

        public int GetNumberOfRatesByReviewer(int reviewerId, int grade);
        
        public int GetNumberOfReviews(int movieId);

        int GetAverageRateFromReviewer(int valuatorId);
    }
}