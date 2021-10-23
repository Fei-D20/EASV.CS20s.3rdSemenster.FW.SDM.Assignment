using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IMovie
    {
        public int MovieId { get; set; }
        public List<Review> MovieReviews { get; set; }
    }
}