using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IValuator
    {
        public int ValuatorId { get; set; }
        public List<Review> ValuatorReviews { get; set; }
    }
}