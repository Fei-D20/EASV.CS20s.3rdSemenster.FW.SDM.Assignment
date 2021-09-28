using System.Collections.Generic;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.Services
{
    public class ValuatorService : IValuatorService
    
    {
        private readonly IValuatorRepository _repo;

        public ValuatorService(IValuatorRepository repositoryValuator)
        {
            _repo = repositoryValuator;
        }

        public List<Valuator> GetMostProductiveValuators()
        {
            throw new System.NotImplementedException();
        }

        public List<Valuator> GetValuatorsByMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }
    }
}