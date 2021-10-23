using System.Collections.Generic;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public List<Review> MovieReviews { get; set; }
        
    }
}