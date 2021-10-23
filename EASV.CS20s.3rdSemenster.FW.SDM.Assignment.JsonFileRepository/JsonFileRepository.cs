using System.Collections.Generic;
using System.IO;
using EASV.CS20s._3rdSemenster.FW.SDM.Assignment.Domain.IRepositories;
using Newtonsoft.Json;

namespace EASV.CS20s._3rdSemenster.FW.SDM.Assignment.JsonFileRepository
{
    public abstract class JsonFileRepository<T> : IRepository<T>
    {
        private TextReader _textReader; // init TestReader to read the json file
        public T[] Items { get; private set; } // implement interface property
        
        public T[] GetAllItems() { return Items ??= LoadAllItems(); } // implement interface method
        
        /// <summary>
        /// Constructor inject the TextReader object into this class.
        /// </summary>
        /// <param name="textReader"></param>
        public JsonFileRepository(TextReader textReader)
        {
            this._textReader = textReader;
            Items = JsonConvert.DeserializeObject<T[]>(this._textReader.ReadToEnd()); 
            // read the json file to the end and deserialized to array object T[]  
        }

       
        private T[] LoadAllItems()
        {
            var itemList = new List<T>(); // init a list to contain the items
            
            using (JsonTextReader jsonTextReader = new JsonTextReader(_textReader)) // same as try-catch-final 
            // final( if( reader != null)) then close it and dispose it
            {
                var jsonSerializer = new JsonSerializer();
                while (jsonTextReader.Read())
                {
                    if (jsonTextReader.TokenType == JsonToken.StartObject)
                    {
                        var readOneItem = ReadOneItem(jsonTextReader);
                        itemList.Add(readOneItem);
                    }
                }
            }

            return itemList.ToArray();
        }

        public abstract T ReadOneItem(JsonTextReader jsonTextReader);

    }

}