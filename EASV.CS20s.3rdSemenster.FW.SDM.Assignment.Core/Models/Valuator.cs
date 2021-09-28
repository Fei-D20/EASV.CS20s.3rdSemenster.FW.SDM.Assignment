using System.Collections.Generic;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models
{
    public class Valuator
    {
        public int ValuatorId { get; set; }
        public List<Review> ValuatorReviews { get; set; }
    }
}