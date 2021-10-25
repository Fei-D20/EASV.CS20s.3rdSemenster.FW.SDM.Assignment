using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories
{
    public interface IReviewRepository
    {
        List<Review> FindAll();
    }
}