using System;
using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Infrastructure
{
    public class ReviewRepository:IReviewRepository
    {
        private readonly List<Review> _repo;

        public ReviewRepository()
        {
            var random = new Random();
            var grade = random.Next(0,5);
            var movie = random.Next(0,9);
            var reviewer = random.Next(0,9);
            _repo = new List<Review>();
            for (int i = 0; i < 5; i++)
            {
                _repo.Add(new Review()
                {
                    Grade = grade,
                    Movie = int.Parse("00"+movie),
                    Reviewer = int.Parse("10"+reviewer)
                });
            }
            
        }

        public List<Review> FindAll()
        {
            return null;
        }
    }
}