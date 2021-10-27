using System;
using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure
{
    public class ReviewRepository:IReviewRepository
    {
        private readonly List<Review> _repo;

        public ReviewRepository(List<Review> repo)
        {
            _repo = repo;
        }

        public List<Review> FindAll()
        {
            return _repo;
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRateGetAverageRateFromReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfRatesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfReviews(int review)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRateOfMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public double GetNubmerOfRates(int movie)
        {
            throw new NotImplementedException();
        }

        public int[] GetMoviesWithHighestNumberOfTopRates()
        {
            throw new NotImplementedException();
        }

        public int[] GetMostProductiveReviewers()
        {
            throw new NotImplementedException();
        }

        public int GetTopRatedMovies(double grade)
        {
            throw new NotImplementedException();
        }

        public int[] GetTopMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int[] GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }
    }
}