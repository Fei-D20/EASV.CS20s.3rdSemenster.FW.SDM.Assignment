using System;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IReview
    {
        public int ReviewID { get; set; }
        public int? Grade { get; set; }
        public DateTime ReviewDate { get; set; }
        public Movie Movie { get; set; }
        public Valuator Valuator { get; set; }    }
}