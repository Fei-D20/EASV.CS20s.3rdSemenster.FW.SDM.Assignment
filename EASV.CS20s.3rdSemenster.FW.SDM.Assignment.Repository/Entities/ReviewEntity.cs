using System;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Entities
{
    public class ReviewEntity
    {
        public int ReviewID { get; set; }
        public int? Grade { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ValuatorId { get; set; }
        public int MovieId { get; set; }
    }
}