using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IReviewService
    {
        List<Review> GetAll();
        int GetNumberOfReviewsFromReviewer(int reviewer);
        double? GetAverageRateFromReviewer(int reviewer);
        int GetNumberOfRatesByReviewer(int reviewer);
        int GetNumberOfReviews(int movie);
        double? GetAverageRateOfMovie(int movie);
        double GetNumberOfRates(int movie, double rate);
        List<int> GetMoviesWithHighestNumberOfTopRates(double rate);
        List<int> GetMostProductiveReviewers();
        List<int> GetTopRatedMovies(int amount);
        List<int> GetTopMoviesByReviewer(int reviewer);
        List<int> GetReviewersByMovie(int movie);
    }
}