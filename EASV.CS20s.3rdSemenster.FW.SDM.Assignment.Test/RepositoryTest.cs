using System;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.JsonFileRepository;
using Xunit;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Test
{
    public class RepositoryTest
    {
        [Fact]
        public void reTest()
        {
            IRepository<MovieReview> repo = new MovieReviewRepositoryJsonFile(
                new StreamReader(
                    "/Users/Evens/EASV/3.semenster/SDM-Software Developlment Method/Code/2021/EASV.CS20s.3rdSemenster.FW.SDM.Assignment/EASV.CS20s.3rdSemenster.FW.SDM.Assignment.JsonFileRepository/Data/ratings.json"));

            var movieReviews = repo.GetAllItems();  
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(movieReviews[i].ToString());
            }
        }
    }
}