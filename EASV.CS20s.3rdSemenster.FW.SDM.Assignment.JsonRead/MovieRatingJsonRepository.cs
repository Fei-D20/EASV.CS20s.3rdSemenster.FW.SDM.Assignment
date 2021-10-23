using Newtonsoft.Json;
using System;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Core.Models;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.JsonRead;

namespace JsonReaderExample
{
    public class MovieRatingJsonRepository : JsonFileRepository<Review>
    {
        public MovieRatingJsonRepository(TextReader reader) : base(reader)
        {

        }

        public override Review ReadOneItem(JsonTextReader reader)
        {
            reader.Read();
            int r = (int)reader.ReadAsInt32();

            reader.Read();
            int m = (int) reader.ReadAsInt32();

            reader.Read();
            int g = (int) reader.ReadAsInt32();

            reader.Read();
            DateTime d = (DateTime) reader.ReadAsDateTime();

            return new Review(g, d, m,r);
        }
    }
}
