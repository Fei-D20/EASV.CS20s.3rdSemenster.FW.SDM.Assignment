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