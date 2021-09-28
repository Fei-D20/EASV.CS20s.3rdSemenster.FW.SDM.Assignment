using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetMoviesWithHighestNumberOfTopRates()
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> GetTopRatedMovies(int amount)
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> GetTopMoviesByReviewer(int reviewerId)
        {
            throw new System.NotImplementedException();
        }
    }
}