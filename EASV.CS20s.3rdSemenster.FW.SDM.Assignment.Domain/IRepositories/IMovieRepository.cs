using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories
{
    public interface IMovieRepository
    {
        public Movie Create(Movie movie);
        public List<Movie> ReadAll();

        public Movie ReadById(int id);
        public Movie Delete(int id);
        public Movie Update(Movie movie);
    }
}