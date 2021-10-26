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
        
    }
}