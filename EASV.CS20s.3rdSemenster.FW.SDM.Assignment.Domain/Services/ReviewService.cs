using System;
using System.Collections.Generic;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services
{
    public class ReviewService:IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            if (reviewRepository == null)
            {
                throw new InvalidDataException("the review repository should not be null");
            }
            _reviewRepository = reviewRepository;
        }

        public List<Review> GetAll()
        {
            
            return _reviewRepository.FindAll();
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            var findReviewsByReviewer = _reviewRepository.FindReviewsByReviewer(reviewer);
            var count = findReviewsByReviewer.Count;
            return count;
        }

        public double? GetAverageRateFromReviewer(int reviewer)
        {
            var findReviewsByReviewer = _reviewRepository.FindReviewsByReviewer(reviewer);
            if (findReviewsByReviewer == null)
            {
                return null;
            }
            
            double count = 0;
            double totle = 0;

            foreach (var review in findReviewsByReviewer)
            {
                count++;
                totle = totle + review.Grade;
            }

            double rate = totle/count;
            return rate;
        }

        public int GetNumberOfRatesByReviewer(int reviewer)
        {
            var findReviewsByReviewer = _reviewRepository.FindReviewsByReviewer(reviewer);
            return findReviewsByReviewer.Count;
        }

        public int GetNumberOfReviews(int movie)
        {
            var findReviewsByMovie = _reviewRepository.FindReviewsByMovie(movie);
            return findReviewsByMovie.Count;
        }

        public double? GetAverageRateOfMovie(int movie)
        {
            var findReviewsByMovie = _reviewRepository.FindReviewsByMovie(movie);
            
            if (findReviewsByMovie == null)
                return null;
            
            double count = 0;
            double totle = 0;
            
            foreach (var review in findReviewsByMovie)
            {
                count++;
                totle += review.Grade;
            }

            return totle / count;
        }

        public double GetNumberOfRates(int movie, double rate)
        {
            var findReviewsByMovie = _reviewRepository.FindReviewsByMovie(movie);
            int count = 0;
            foreach (var review in findReviewsByMovie)
            {
                if (review.Grade == rate)
                {
                    count++;
                }
            }

            return count;
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