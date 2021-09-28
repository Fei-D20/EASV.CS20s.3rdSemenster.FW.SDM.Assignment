using System;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int? Grade { get; set; }
        public Movie Movie { get; set; }
        public Valuator Valuator { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}