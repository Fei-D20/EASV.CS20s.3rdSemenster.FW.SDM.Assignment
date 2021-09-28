using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories
{
    public interface IReviewRepository
    {
        public Review Create(Review review);
        public List<Review> ReadAll();

        public Review ReadById(int id);
        public Review Delete(int id);
        public Review Update(Review review);
    }
}