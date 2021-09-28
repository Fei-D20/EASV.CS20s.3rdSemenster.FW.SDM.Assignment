using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IMovieService
    {
        public List<Movie> GetMoviesWithHighestNumberOfTopRates();

        public List<Movie> GetTopRatedMovies(int amount);

        public List<Movie> GetTopMoviesByReviewer(int reviewerId);
    }
}