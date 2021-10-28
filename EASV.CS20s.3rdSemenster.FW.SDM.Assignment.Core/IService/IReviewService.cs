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
        double GetNubmerOfRates(int movie, double rate);
        int[] GetMoviesWithHighestNumberOfTopRates();
        int[] GetMostProductiveReviewers();
        int GetTopRatedMovies(double grade);
        int[] GetTopMoviesByReviewer(int reviewer);
        int[] GetReviewersByMovie(int movie);
    }
}