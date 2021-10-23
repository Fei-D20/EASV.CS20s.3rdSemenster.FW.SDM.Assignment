using System.Collections.Generic;
using System.Linq;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Entities;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ReviewApplicationContext _ctx;

        public ReviewRepository(ReviewApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Review Create(Review review)
        {
            ReviewEntity reviewEntity = new ReviewEntity
            {
                ReviewID = review.ReviewID,
                Grade = review.Grade,
                ReviewDate = review.ReviewDate,
                ValuatorId = review.Valuator.ValuatorId
            };
            _ctx.Reviews.Add(reviewEntity);
            return review;
        }

        public List<Review> ReadAll()
        {
            var selectQuery = _ctx.Reviews.Select(reviewEntity => new Review
            {
                ReviewID = reviewEntity.ReviewID,
                Grade = reviewEntity.Grade,
                Movie = new Movie
                {
                    MovieId = reviewEntity.MovieId
                }
            }).ToList();
            return selectQuery;
        }

        public Review ReadById(int id)
        {
            return _ctx.Reviews.Select(entity => new Review{
                ReviewID = entity.ReviewID,
                Grade = entity.Grade,
                Movie = new Movie
                {
                   MovieId = entity.MovieId
                },
                ReviewDate = entity.ReviewDate,
                Valuator = new Valuator
                {
                    ValuatorId = entity.ValuatorId
                }
            }).FirstOrDefault(r => r.ReviewID == id);
        }

        public Review Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Review Update(Review review)
        {
            throw new System.NotImplementedException();
        }

        public int ReadByReviewer(int reviewerId)
        {
            throw new System.NotImplementedException();
        }
    }
}