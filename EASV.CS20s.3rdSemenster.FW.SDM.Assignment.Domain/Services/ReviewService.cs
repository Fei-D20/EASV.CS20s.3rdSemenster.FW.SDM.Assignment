using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public double GetAverageRateOfMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfRates(int movieId, int grade)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfReviewsFromReviewer(int valuatorId)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfRatesByReviewer(int reviewerId, int grade)
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfReviews(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public int GetAverageRateFromReviewer(int valuatorId)
        {
            throw new System.NotImplementedException();
        }
    }
}