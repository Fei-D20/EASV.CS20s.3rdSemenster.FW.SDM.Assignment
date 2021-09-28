using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService
{
    public interface IValuatorService
    {
        public List<Valuator> GetMostProductiveValuators();

        public List<Valuator> GetValuatorsByMovie(int movieId);

    }
}