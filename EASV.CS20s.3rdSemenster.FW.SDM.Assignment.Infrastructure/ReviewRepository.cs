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

        public Review Create()
        {
            throw new NotImplementedException();
        }

        public Review Read()
        {
            throw new NotImplementedException();
        }

        public Review Update()
        {
            throw new NotImplementedException();
        }

        public Review Delete()
        {
            throw new NotImplementedException();
        }

        public List<Review> FindReviewsByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }
        
    }
}