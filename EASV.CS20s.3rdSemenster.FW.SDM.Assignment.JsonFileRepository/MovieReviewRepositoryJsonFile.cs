using System;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using Newtonsoft.Json;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.JsonFileRepository
{
    public class MovieReviewRepositoryJsonFile : JsonFileRepository<MovieReview>
    {
        public MovieReviewRepositoryJsonFile(TextReader textReader) : base(textReader)
        {
        }


        public override MovieReview ReadOneItem(JsonTextReader jsonTextReader)
        {
            jsonTextReader.Read();
            var Reviewer = (int)jsonTextReader.ReadAsInt32();

            jsonTextReader.Read();
            var Movie = (int)jsonTextReader.ReadAsInt32();

            jsonTextReader.Read();
            var Grade = (int)jsonTextReader.ReadAsInt32();

            jsonTextReader.Read();
            var DateTime = (DateTime)jsonTextReader.ReadAsDateTime();

            return new MovieReview(Reviewer, Movie, Grade, DateTime);
        }
    }
}