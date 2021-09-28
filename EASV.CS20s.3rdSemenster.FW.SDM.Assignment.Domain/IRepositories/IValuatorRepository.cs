using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories
{
    public interface IValuatorRepository
    {
        public Valuator Create(Valuator valuator);
        public List<Valuator> ReadAll();

        public Valuator ReadById(int id);
        public Valuator Delete(int id);
        public Valuator Update(Valuator valuator);
    }
}