using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.IService;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Test
{
    public class StartUp
    {
        public void start()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IMovieRepository, MovieRepository>();
            serviceCollection.AddScoped<IReviewRepository, ReviewRepository>();
            serviceCollection.AddScoped<IValuatorRepository, ValuatorRepository>();

           
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var service = serviceProvider.GetRequiredService<IReviewService>();
        }
    }
}